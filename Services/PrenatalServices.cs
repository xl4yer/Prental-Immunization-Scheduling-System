using Bhcirs.Class;
using Bhcirs.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace Bhcirs.Services
{
    public class PrenatalServices
    {
        private readonly AppDb _constring;
        public IConfiguration Configuration;

        public PrenatalServices(AppDb constring, IConfiguration configuration)
        {
            _constring = constring;
            Configuration = configuration;
        }

        public async Task<List<prenatal>> Teta1()
        {
            List<prenatal> xpre = new List<prenatal>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("Teta1", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    var rdr = await com.ExecuteReaderAsync().ConfigureAwait(false);
                    while (await rdr.ReadAsync().ConfigureAwait(false))
                    {
                        xpre.Add(new prenatal
                        {
                            prenatalID = rdr["prenatalID"].ToString(),
                            infoID = rdr["infoID"].ToString(),
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
            return xpre;
        }

        public async Task<List<prenatal>> Teta2()
        {
            List<prenatal> xpre = new List<prenatal>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("Teta2", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    var rdr = await com.ExecuteReaderAsync().ConfigureAwait(false);
                    while (await rdr.ReadAsync().ConfigureAwait(false))
                    {
                        xpre.Add(new prenatal
                        {
                            prenatalID = rdr["prenatalID"].ToString(),
                            infoID = rdr["infoID"].ToString(),
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
            return xpre;
        }


        public async Task<int> AddPrenatal(prenatal xpre)
        {
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("AddPrenatal", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };

                    com.Parameters.AddWithValue("_prenatalID", xpre.prenatalID);
                    com.Parameters.AddWithValue("_infoID", xpre.infoID);
                    com.Parameters.AddWithValue("_date", xpre.date);
                    com.Parameters.AddWithValue("_vaccine", xpre.vaccine);
                    com.Parameters.AddWithValue("_status", xpre.status);
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


        public async Task<int> UpdatePrenatal(prenatal xpre)
        {
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("UpdatePrenatal", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };

                    com.Parameters.AddWithValue("_prenatalID", xpre.prenatalID);
                    com.Parameters.AddWithValue("_infoID", xpre.infoID);
                    com.Parameters.AddWithValue("_date", xpre.date);
                    com.Parameters.AddWithValue("_vaccine", xpre.vaccine);
                    com.Parameters.AddWithValue("_status", xpre.status);
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

