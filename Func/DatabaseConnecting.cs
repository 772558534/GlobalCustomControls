using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalCustomControls
{
    public class DatabaseConnecting
    {
        DatabaseModel? model;

        string sql = "server=jiashili-PC;Database=test;user id=sa;password=123456;Encrypt=True;TrustServerCertificate=True;";

        public DatabaseConnecting()
        {
            model = new DatabaseModel();
            Task.Run(() =>
            {
                using SqlConnection sqlcon = new SqlConnection(sql);
                sqlcon.Open();
            });
            
        }

    }
}
