using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Shopping.DAL.Implement
{
    public class BaseRepository
    {
        //private readonly IConfiguration configuration;
        protected IDbConnection connection;
        public BaseRepository()
        {
            //configuration = new Configuration();
            connection = new SqlConnection(@"Data Source=admin\sqlexpress;Initial Catalog=Shopping;Integrated Security=True");
            
        }
    }
}
