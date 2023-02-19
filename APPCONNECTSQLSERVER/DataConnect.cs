using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace APPCONNECTSQLSERVER
{
    internal class DataConnect
    {
        public static SqlConnection DataCon { get; set; }
        public static void ConnectionDB(string ip, string dbName)
        {
            DataCon = new SqlConnection($"Server={ip};Database={dbName};Trusted_Connection=True;");
            DataCon.Open();
        }

        public static  void ConnectionDB(string ip, string dbName,string user,string pass)
        {
            DataCon = new SqlConnection($"Server={ip};Database={dbName};User Id={user};Password={pass};");
            DataCon.Open();
        }
    }
}
