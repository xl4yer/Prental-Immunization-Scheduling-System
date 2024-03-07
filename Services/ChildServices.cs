using Bhcirs.Class;
using Bhcirs.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace Bhcirs.Services
{
    public class ChildServices
    {
        private readonly AppDb _constring;
        public IConfiguration Configuration;

        public ChildServices(AppDb constring, IConfiguration configuration)
        {
            _constring = constring;
            Configuration = configuration;
        }

        public async Task<List<child>> Child()
        {
            List<child> xchild = new List<child>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("viewchild", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    var rdr = await com.ExecuteReaderAsync().ConfigureAwait(false);
                    while (await rdr.ReadAsync().ConfigureAwait(false))
                    {
                        xchild.Add(new child
                        {
                            childID = rdr["childID"].ToString(),
                            infoID = rdr["infoID"].ToString(),
                            fname = rdr["fname"].ToString(),
                            mname = rdr["mname"].ToString(),
                            lname = rdr["lname"].ToString(),
                            bdate = Convert.ToDateTime(rdr["bdate"].ToString()),
                            feeding = rdr["feeding"].ToString(),
                            allergy = rdr["allergy"].ToString(),
                            delivery = rdr["delivery"].ToString(),
                            fullname = rdr["fullname"].ToString(),
                            mothersname = rdr["mothersname"].ToString(),
                            age = rdr["age"].ToString(),
                            contact = rdr["contact"].ToString(),
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
            return xchild;
        }

        public async Task<int> CountChild()
        {
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                await con.OpenAsync().ConfigureAwait(false);
                var com = new MySqlCommand("CountChild", con)
                {
                    CommandType = CommandType.StoredProcedure,
                };
                return Convert.ToInt32(await com.ExecuteScalarAsync().ConfigureAwait(false));
            }
        }

        public async Task<List<child>> SearchChild(string search)
        {
            List<child> xchild = new List<child>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("searchchild", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("search", search);
                    com.Parameters.AddWithValue("@searchWildcard", $"{search}%");
                    var rdr = await com.ExecuteReaderAsync().ConfigureAwait(false);
                    while (await rdr.ReadAsync().ConfigureAwait(false))
                    {
                        xchild.Add(new child
                        {
                            childID = rdr["childID"].ToString(),
                            infoID = rdr["infoID"].ToString(),
                            fname = rdr["fname"].ToString(),
                            mname = rdr["mname"].ToString(),
                            lname = rdr["lname"].ToString(),
                            bdate = Convert.ToDateTime(rdr["bdate"].ToString()),
                            feeding = rdr["feeding"].ToString(),
                            allergy = rdr["allergy"].ToString(),
                            delivery = rdr["delivery"].ToString(),
                            fullname = rdr["fullname"].ToString(),
                            age = rdr["age"].ToString(),
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
            return xchild;
        }

        public async Task<int> AddChild(child xchild)
        {
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("AddChild", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    com.Parameters.AddWithValue("_childID", xchild.infoID);
                    com.Parameters.AddWithValue("_infoID", xchild.infoID);
                    com.Parameters.AddWithValue("_fname", xchild.fname);
                    com.Parameters.AddWithValue("_mname", xchild.mname);
                    com.Parameters.AddWithValue("_lname", xchild.lname);
                    com.Parameters.AddWithValue("_bdate", xchild.bdate);
                    com.Parameters.AddWithValue("_feeding", xchild.feeding);
                    com.Parameters.AddWithValue("_allergy", xchild.allergy);
                    com.Parameters.AddWithValue("_delivery", xchild.delivery);
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
        public async Task<int> UpdateChild(child xchild)
        {
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("UpdateChild", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    com.Parameters.AddWithValue("_childID", xchild.childID);
                    com.Parameters.AddWithValue("_infoID", xchild.infoID);
                    com.Parameters.AddWithValue("_fname", xchild.fname);
                    com.Parameters.AddWithValue("_mname", xchild.mname);
                    com.Parameters.AddWithValue("_lname", xchild.lname);
                    com.Parameters.AddWithValue("_bdate", xchild.bdate);
                    com.Parameters.AddWithValue("_feeding", xchild.feeding);
                    com.Parameters.AddWithValue("_allergy", xchild.allergy);
                    com.Parameters.AddWithValue("_delivery", xchild.delivery);
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