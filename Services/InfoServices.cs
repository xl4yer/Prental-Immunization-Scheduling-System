using Bhcirs.Class;
using Bhcirs.Models;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using static MudBlazor.CategoryTypes;

namespace Bhcirs.Services
{
    public class InfoServices
    {
        private readonly AppDb _constring;
        public IConfiguration Configuration;

        public InfoServices(AppDb constring, IConfiguration configuration)
        {
            _constring = constring;
            Configuration = configuration;
        }

        public async Task<List<info>> Info()
        {
            List<info> xinfo = new List<info>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("ViewInfo", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    var rdr = await com.ExecuteReaderAsync().ConfigureAwait(false);
                    while (await rdr.ReadAsync().ConfigureAwait(false))
                    {
                        xinfo.Add(new info
                        {
                            infoID = rdr["infoID"].ToString(),
                            fname = rdr["fname"].ToString(),
                            mname = rdr["mname"].ToString(),
                            lname = rdr["lname"].ToString(),
                            bdate = Convert.ToDateTime(rdr["bdate"].ToString()),
                            contact = rdr["contact"].ToString(),
                            address = rdr["address"].ToString(),
                            hname = rdr["hname"].ToString(),
                            occupation = rdr["occupation"].ToString(),
                            fullname = rdr["fullname"].ToString(),
                            age = rdr["age"].ToString()
                        });
                    }
                    await rdr.CloseAsync().ConfigureAwait(false);
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
            return xinfo;
        }

        public async Task<int> CountInfo()
        {
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                await con.OpenAsync().ConfigureAwait(false);
                var com = new MySqlCommand("CountInfo", con)
                {
                    CommandType = CommandType.StoredProcedure,
                };
                return Convert.ToInt32(await com.ExecuteScalarAsync().ConfigureAwait(false));
            }
        }

        public async Task<List<info>> SearchInfo(string search)
        {
            List<info> xinfo = new List<info>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("SearchInfo", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("search", search);
                    com.Parameters.AddWithValue("@searchWildcard", $"{search}%");
                    var rdr = await com.ExecuteReaderAsync().ConfigureAwait(false);
                    while (await rdr.ReadAsync().ConfigureAwait(false))
                    {
                        xinfo.Add(new info
                        {
                            infoID = rdr["infoID"].ToString(),
                            fname = rdr["fname"].ToString(),
                            mname = rdr["mname"].ToString(),
                            lname = rdr["lname"].ToString(),
                            bdate = Convert.ToDateTime(rdr["bdate"].ToString()),
                            contact = rdr["contact"].ToString(),
                            address = rdr["address"].ToString(),
                            hname = rdr["hname"].ToString(),
                            occupation = rdr["occupation"].ToString(),
                            fullname = rdr["fullname"].ToString(),
                            age = rdr["age"].ToString()
                        });
                    }
                    await rdr.CloseAsync().ConfigureAwait(false);
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
            return xinfo;
        }
        public async Task<int> AddInfo(info xinfo)
        {
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("AddInfo", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    com.Parameters.AddWithValue("_infoID", xinfo.infoID);
                    com.Parameters.AddWithValue("_fname", xinfo.fname);
                    com.Parameters.AddWithValue("_mname", xinfo.mname);
                    com.Parameters.AddWithValue("_lname", xinfo.lname);
                    com.Parameters.AddWithValue("_bdate", xinfo.bdate);
                    com.Parameters.AddWithValue("_contact", xinfo.contact);
                    com.Parameters.AddWithValue("_address", xinfo.address);
                    com.Parameters.AddWithValue("_hname", xinfo.hname);
                    com.Parameters.AddWithValue("_occupation", xinfo.occupation);
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

        public async Task<int> UpdateInfo(info xinfo)
        {
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("UpdateInfo", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    com.Parameters.AddWithValue("_infoID", xinfo.infoID);
                    com.Parameters.AddWithValue("_fname", xinfo.fname);
                    com.Parameters.AddWithValue("_mname", xinfo.mname);
                    com.Parameters.AddWithValue("_lname", xinfo.lname);
                    com.Parameters.AddWithValue("_bdate", xinfo.bdate);
                    com.Parameters.AddWithValue("_contact", xinfo.contact);
                    com.Parameters.AddWithValue("_address", xinfo.address);
                    com.Parameters.AddWithValue("_hname", xinfo.hname);
                    com.Parameters.AddWithValue("_occupation", xinfo.occupation);
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
    }

}


