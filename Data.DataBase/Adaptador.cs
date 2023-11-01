using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Data.DataBase
{
    public class Adaptador
    {
        private static string connectionString;

        static Adaptador()
        {
            // cadena de conexion
            //connectionString = "Server=DESKTOP-QJEDU21;Database=TPI2023M07; Uid=sa; Pwd=sql2023";
            //connectionString = "Server=MS-12\\SQLEXPRESS;Database=TPI2023M07; Uid=net; Pwd=net";
            //connectionString = "Data Source=(localdb)\\NBX;Database=TPI2023M07; Integrated Security=True";
            connectionString = "Data Source=TOMASLARDIZABAL\\SQLEXPRESS;Initial Catalog=Academia_tp;Integrated Security=True";
    }

        public static string GetConnection()
        {
            return connectionString;
        }
    }
}