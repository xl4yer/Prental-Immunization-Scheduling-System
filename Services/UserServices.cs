﻿using Bhcirs.Class;
using Bhcirs.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MySql.Data.MySqlClient;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Bhcirs.Services
{
    public class UserServices
    {
        private readonly AppDb _constring;
        public IConfiguration Configuration;
        private readonly AppSettings _appSetting;

        public UserServices(AppDb constring, IConfiguration configuration, IOptions<AppSettings> appSettings)
        {
            _constring = constring;
            Configuration = configuration;
            _appSetting = appSettings.Value;
        }

        public async Task<int> UpdateAdminPassword(users xuser)
        {
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("UpdateAdminPassword", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    com.Parameters.AddWithValue("_userID", xuser.userID);
                    com.Parameters.AddWithValue("_password", xuser.password);
                    return await com.ExecuteNonQueryAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    // Handle the exception here
                }
                finally
                {
                    await con.CloseAsync().ConfigureAwait(false);
                }
            }
            return 0;
        }
        public async Task<List<users>> Login(string user, string pwd)
        {
            List<users> xuser = new();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                await con.OpenAsync().ConfigureAwait(false);
                var com = new MySqlCommand("userlogin", con)
                {
                    CommandType = CommandType.StoredProcedure,
                };
                com.Parameters.Clear();
                com.Parameters.AddWithValue("_user", user);
                com.Parameters.AddWithValue("_pass", pwd);

                var rdr = await com.ExecuteReaderAsync().ConfigureAwait(false);
                while (await rdr.ReadAsync().ConfigureAwait(false))
                {
                    xuser.Add(new users
                    {
                        userID = rdr["userID"].ToString(),
                        name = rdr["name"].ToString(),
                        username = rdr["username"].ToString(),
                        password = rdr["password"].ToString(),
                        role = rdr["role"].ToString(),
                    });
                }
                if (xuser.Count > 0)
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var key = Encoding.ASCII.GetBytes(_appSetting.Secret);
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                    new Claim (ClaimTypes.Name ,user),
                    new Claim (JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
                        }),
                        Expires = DateTime.UtcNow.AddDays(1),
                        SigningCredentials = new SigningCredentials(new
                        SymmetricSecurityKey(key), SecurityAlgorithms.Aes128CbcHmacSha256)

                    };
                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    xuser[0].token = tokenHandler.WriteToken(token);
                }
                return xuser;
            }
        }
    }
}