﻿using Bhcirs.Class;
using Bhcirs.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace Bhcirs.Services
{
    public class ImmunizationServices
    {
        private readonly AppDb _constring;
        public IConfiguration Configuration;

        public ImmunizationServices(AppDb constring, IConfiguration configuration)
        {
            _constring = constring;
            Configuration = configuration;
        }


        public async Task<List<immunization>> BCG()
        {
            List<immunization> ximm = new List<immunization>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("BCG", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    var rdr = await com.ExecuteReaderAsync().ConfigureAwait(false);
                    while (await rdr.ReadAsync().ConfigureAwait(false))
                    {
                        ximm.Add(new immunization
                        {
                            immunizationID = rdr["immunizationID"].ToString(),
                            childID = rdr["childID"].ToString(),
                            date = Convert.ToDateTime(rdr["date"].ToString()),
                            vaccine = rdr["vaccine"].ToString(),
                            fullname = rdr["fullname"].ToString(),
                            status = rdr["status"].ToString(),
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
            return ximm;
        }

        public async Task<int> AddImmunization(immunization ximm)
        {
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("AddImmunization", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };

                    com.Parameters.AddWithValue("_immunizationID", ximm.immunizationID);
                    com.Parameters.AddWithValue("_childID", ximm.childID);
                    com.Parameters.AddWithValue("_date", ximm.date);
                    com.Parameters.AddWithValue("_vaccine", ximm.vaccine);
                    com.Parameters.AddWithValue("_status", ximm.status);
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
