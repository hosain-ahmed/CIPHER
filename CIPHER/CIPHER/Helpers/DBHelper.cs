using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CIPHER.Helpers
{
    public static class DBHelper
    {
        private static readonly string _conn=  @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CIPHER;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;";
        
        public static SqlConnection Getconnection()
        {
            var conn = new SqlConnection(_conn);
            conn.Open();
            return conn;
        }
    }
}
