using HappyVillageProject.Libraries.config;
using HappyVillageProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyVillageProject.Data
{
    public class StoredProcedures
    {
        private readonly string _connectionstring;
       // private readonly DbConfig dbConfig;
        //public ValuesRepository(IOptions< context)
        //  public ValuesRepository(IOptions<DbConfig> dbConfig)
        public StoredProcedures(IConfiguration configuration)
        {
            //this.dbConfig = dbConfig.Value;
         //  _connectionstring = context;
            _connectionstring = configuration.GetConnectionString("defaultConnection");
        }
    
        public async Task<ActionResult<IEnumerable<Images>>> GetAll()
        {
           using (SqlConnection sql = new SqlConnection(_connectionstring))
            {
                using(SqlCommand cmd = new SqlCommand("[dbo].[ImagesRetrieve]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    var response = new List<Images>();
                    await sql.OpenAsync();
                    using(var reader = await cmd.ExecuteReaderAsync())
                    {
                        while(await reader.ReadAsync())
                        {
                            response.Add(MapToImages(reader));
                        }
                    }
                    return response;
                }
            }
        }

        private Images MapToImages(SqlDataReader reader)
        {
            return new Images()
            {
                Id = (int)reader["Id"],
                Title = (string)reader["Title"]
            };
        }

       
    }
}



    