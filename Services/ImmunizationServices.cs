using Bhcirs.Class;
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

        public async Task<List<immunization>> PCV131()
        {
            List<immunization> ximm = new List<immunization>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("PCV131", con)
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

        public async Task<List<immunization>> PCV132()
        {
            List<immunization> ximm = new List<immunization>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("PCV132", con)
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

        public async Task<List<immunization>> PCV133()
        {
            List<immunization> ximm = new List<immunization>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("PCV133", con)
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

        public async Task<List<immunization>> MCV1()
        {
            List<immunization> ximm = new List<immunization>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("MCV1", con)
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

        public async Task<List<immunization>> MCV2()
        {
            List<immunization> ximm = new List<immunization>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("MCV2", con)
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

        public async Task<List<immunization>> IPV1()
        {
            List<immunization> ximm = new List<immunization>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("IPV1", con)
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

        public async Task<List<immunization>> IPV2()
        {
            List<immunization> ximm = new List<immunization>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("IPV2", con)
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

        public async Task<List<immunization>> BOPV1()
        {
            List<immunization> ximm = new List<immunization>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("BOPV1", con)
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

        public async Task<List<immunization>> BOPV2()
        {
            List<immunization> ximm = new List<immunization>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("BOPV2", con)
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

        public async Task<List<immunization>> BOPV3()
        {
            List<immunization> ximm = new List<immunization>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("BOPV3", con)
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

        public async Task<List<immunization>> Penta1()
        {
            List<immunization> ximm = new List<immunization>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("Penta1", con)
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

        public async Task<List<immunization>> Penta2()
        {
            List<immunization> ximm = new List<immunization>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("Penta2", con)
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


        public async Task<List<immunization>> Penta3()
        {
            List<immunization> ximm = new List<immunization>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("Penta3", con)
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

        public async Task<int> UpdateImmunization(immunization ximm)
        {
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("UpdateImmunization", con)
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


        public async Task<List<immunization>> SearchBOPV1(string search)
        {
            List<immunization> ximm = new List<immunization>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("SearchBOPV1", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("search", search);
                    com.Parameters.AddWithValue("@searchWildcard", $"{search}%");
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


        public async Task<List<immunization>> SearchBCG(string search)
        {
            List<immunization> ximm = new List<immunization>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("SearchBCG", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("search", search);
                    com.Parameters.AddWithValue("@searchWildcard", $"{search}%");
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

    }
}
