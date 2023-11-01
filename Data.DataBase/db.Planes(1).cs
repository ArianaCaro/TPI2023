using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Data.DataBase
{
    public class PlanesDAO
    {
        // Cadena de conexión a la base de datos
       // private string connectionString = "Server=DESKTOP-QJEDU21;Database=TPI2023M07; Uid=sa; Pwd=sql2023";
        //private string connectionString = "Data Source=(localdb)\\NBX;Integrated Security=True";
        private string connectionString = "Server=MS-12\\SQLEXPRESS;Database=TPI2023M07; Uid=net; Pwd=net";

        public bool InsertarPlan(Plan plan)        // Método para insertar un nuevo plan en la base de datos
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Planes (desc_plan, id_especialidad) VALUES (@desc_plan, @id_especialidad)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@desc_plan", plan.DescPlan);
                        command.Parameters.AddWithValue("@id_especialidad", plan.IdEspecialidad);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        
        public DataTable ObtenerTodosLosPlanes()
        {
            DataTable dtPlanes = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id_plan, desc_plan, id_especialidad FROM Planes";
                                                    

                using (SqlCommand commnad = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(commnad);
                    adapter.Fill(dtPlanes);
                }
            }
            return dtPlanes;
        }

        public string ObtenerDescripcionPlanes(int idPlan)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT desc_plan FROM Planes WHERE id_plan = @id_plan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_plan", idPlan);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la descripción de la especialidad: " + ex.Message);
            }

            return null; // Devolver null si no se encuentra la descripción
        }





        public bool ModificarPlan(Plan plan)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Planes SET desc_plan = @NuevaDescripcion, id_especialidad = @NuevoIdEspecialidad WHERE id_plan = @IDPlan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IDPlan", plan.IdPlan);
                        command.Parameters.AddWithValue("@NuevaDescripcion", plan.DescPlan);
                        command.Parameters.AddWithValue("@NuevoIdEspecialidad", plan.IdEspecialidad);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }


        public bool EliminarPlan(Plan plan)
        {
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Planes WHERE id_plan = @id_plan AND desc_plan = @desc_plan AND id_especialidad = @id_especialidad";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id_plan", plan.IdPlan);
                            command.Parameters.AddWithValue("@desc_plan", plan.DescPlan);
                            command.Parameters.AddWithValue("@id_especialidad", plan.IdEspecialidad);

                            int rowsAffected = command.ExecuteNonQuery();

                            return rowsAffected > 0;
                        }
                    }
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}