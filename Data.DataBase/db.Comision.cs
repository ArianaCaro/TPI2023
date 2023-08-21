using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataBase
{
    public class ComisionesDAO
    {
        // Cadena de conexión a la base de datos
        private string connectionString = "Server=DESKTOP-QJEDU21;Database=TPI2023M07; Uid=sa; Pwd=sql2023";

        // Método para insertar un nuevo plan en la base de datos
        public bool InsertarPlan(string descripcion, int idEspecialidad)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Planes (descripcion, id_Especialidad) VALUES (@descripcion, @id_Especialidad)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@descripcion", descripcion);
                        command.Parameters.AddWithValue("@id_Especialidad", idEspecialidad);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (opcional)
                Console.WriteLine("Error al insertar el plan: " + ex.Message);
                return false;
            }
        }


        public DataTable ObtenerTodosLosPlanes()
        {
            DataTable dtPlanes = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id_plan, descripcion, id_Especialidad FROM Planes";


                using (SqlCommand commnad = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(commnad);
                    adapter.Fill(dtPlanes);
                }
            }
            return dtPlanes;
        }


        public bool ModificarPlan(int id, string desc, int id_espec)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Planes SET Descripcion = @NuevaDescripcion, id_especialidad = @NuevoIdEspecialidad WHERE id_plan = @IDPlan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IDPlan", id);
                        command.Parameters.AddWithValue("@NuevaDescripcion", desc);
                        command.Parameters.AddWithValue("@NuevoIdEspecialidad", id_espec);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error como consideres necesario (log, mostrar mensaje, etc.)
                Console.WriteLine("Error al modificar el plan: " + ex.Message);
                return false;
            }
        }




        public bool EliminarPlan(int id_plan, string descripcion, int id_especialidad)
        {
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Definir la consulta SQL para eliminar el plan
                        string query = "DELETE FROM Planes WHERE id_plan = @id_plan AND descripcion = @descripcion AND id_Especialidad = @id_Especialidad";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Agregar los parámetros a la consulta
                            command.Parameters.AddWithValue("@id_plan", id_plan);
                            command.Parameters.AddWithValue("@descripcion", descripcion);
                            command.Parameters.AddWithValue("@id_Especialidad", id_especialidad);

                            // Ejecutar la consulta
                            int rowsAffected = command.ExecuteNonQuery();

                            // Si se eliminó al menos una fila, significa que el plan se eliminó correctamente
                            return rowsAffected > 0;
                        }
                    }
                }
                catch/* (SqlException ex)*/
                {
                    //mostrar un mensaje de error o escribir el error en un archivo de registro
                    // y devolver false para indicar que no se pudo eliminar el plan.
                    return false;
                }
            }
        }
    }
}
