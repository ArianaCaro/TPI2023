using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


/*
namespace DataDAO
{
    public class Adaptador
    {

        private SqlConnection sqlCon;

        const string claveConexionDefecto = "probando";

        public SqlConnection SqlCon
        {
            get { return sqlCon; }
            set { sqlCon = value; }
        }

        protected void AbrirConexion()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings[claveConexionDefecto].ConnectionString;
            sqlCon = new SqlConnection(cadenaConexion);
            sqlCon.Open();
        }

        protected void CerrarConexion()
        {
            sqlCon.Close();
            sqlCon = null;
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
*/