using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataDAO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PLANES
            DataTable dtPlanes = new DataTable("Planes");

            dtPlanes.Columns.Add("id_plan", typeof(int)); // Cambio de columna
            dtPlanes.Columns.Add("descripcion", typeof(string)); // Cambio de columna
            dtPlanes.Columns.Add("id_especialidad", typeof(int)); // Nueva columna*/

            SqlConnection myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=DESKTOP-QJEDU21; Initial Catalog=TPI2023M07;User ID=sa;Pwd=sql2023";

            SqlCommand mycomando = new SqlCommand();
            mycomando.CommandText = "SELECT id_plan, descripcion, id_especialidad FROM Planes"; // Cambio de nombres de columna
            mycomando.Connection = myconn;

            SqlDataAdapter myadap = new SqlDataAdapter("SELECT id_plan, descripcion, id_especialidad FROM Planes", myconn); // Cambio de nombres de columna

            myconn.Open();
            SqlDataReader mydr = mycomando.ExecuteReader();
            dtPlanes.Load(mydr);
            myconn.Close();

            foreach (DataRow rowPlanes in dtPlanes.Rows)
            {
                int idPlan = (int)rowPlanes["id_plan"];
                string descripcion = rowPlanes["descripcion"].ToString();
                int idEspecialidad = (int)rowPlanes["id_especialidad"];

                Console.WriteLine($"ID Plan: {idPlan}, Descripción: {descripcion}, ID Especialidad: {idEspecialidad}");
            }
            Console.ReadLine();
            #endregion



            #region ESPECIALIDADES
            /* DataTable dtEspecialidades = new DataTable("Especialidades");

             dtEspecialidades.Columns.Add("id_especialidad", typeof(int)); // Cambio de columna
             dtEspecialidades.Columns.Add("descripcion", typeof(string)); // Cambio de columna


             SqlConnection myconn2 = new SqlConnection();
             myconn2.ConnectionString = "Data Source=DESKTOP-QJEDU21; Initial Catalog=TPI2023M07;User ID=sa;Pwd=sql2023";

             SqlCommand mycomando2 = new SqlCommand();
             mycomando2.CommandText = "SELECT id_especialidades, descripcion FROM Especialidades"; // Cambio de nombres de columna
             mycomando2.Connection = myconn2;

             SqlDataAdapter myadap2 = new SqlDataAdapter("SELECT id_especialidades, descripcion FROM Especialidades", myconn2); // Cambio de nombres de columna

             myconn2.Open();
             SqlDataReader mydr2 = mycomando2.ExecuteReader();
             dtEspecialidades.Load(mydr2);
             myconn2.Close();

             foreach (DataRow rowEspecialidades in dtEspecialidades.Rows)
             {
                 int idEspecialidad = (int)rowEspecialidades["id_especialidad"];
                 string descripcion = rowEspecialidades["descripcion"].ToString();

                 Console.WriteLine($"ID Especialidad: {idEspecialidad}, Descripción: {descripcion}");
             }
             Console.ReadLine();*/
            #endregion

        }
    }
}