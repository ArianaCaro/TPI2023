using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace Data.DataBase
{
    public class EspecialidadesDAO
    {
        // Cadena de conexión a la base de datos
        private string connectionString = "Server=DESKTOP-QJEDU21;Database=TPI2023M07; Uid=sa; Pwd=sql2023";

        // Método para insertar un nuevo plan en la base de datos
        public bool InsertarEspecialidad(string descripcion)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Especialidades (desc_especialidad) VALUES (@desc_especialidad)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@desc_especialidad", descripcion);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)  //no se ejecuta nunca creo
            {
                // Manejo de excepciones (opcional)
                Console.WriteLine("Error al insertar el especialidad anda?: " + ex.Message);
                return false;
            }
        }


        public DataTable ObtenerTodasLasEspecialidades()
        {
            DataTable dtEspecialidades = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT  id_especialidad, desc_especialidad FROM Especialidades";

                using (SqlCommand commnad = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(commnad);
                    adapter.Fill(dtEspecialidades);
                }
            }
            return dtEspecialidades;
        }

        public string ObtenerDescripcionEspecialidad(int idEspecialidad)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT desc_especialidad FROM Especialidades WHERE id_especialidad = @idEspecialidad";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idEspecialidad", idEspecialidad);
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
                // Manejo de excepciones (opcional)
                Console.WriteLine("Error al obtener la descripción de la especialidad: " + ex.Message);
            }

            return null; // Devolver null si no se encuentra la descripción
        }




    public bool ModificarEspecialidad(int id, string desc)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Especialidades SET desc_especialidad = @NuevaDescripcion WHERE id_especialidad = @id_especialidad";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_especialidad", id);
                        command.Parameters.AddWithValue("@NuevaDescripcion", desc);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)  //entra?
            {
                // Manejar el error
                Console.WriteLine("Error al modificar el plan : " + ex.Message);/*entra???*/
                return false;
            }
        }




        public bool EliminarEspecialidad(int id_especialidad, string descripcion)
        {
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Definir la consulta SQL para eliminar el plan
                        string query = "DELETE FROM Especialidades WHERE id_especialidad = @id_especialidad AND desc_especialidad = @desc_especialidad";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Agregar los parámetros a la consulta
                            command.Parameters.AddWithValue("@id_especialidad", id_especialidad);
                            command.Parameters.AddWithValue("@desc_especialidad", descripcion);

                            // Ejecutar la consulta
                            int rowsAffected = command.ExecuteNonQuery();

                            // Si se eliminó al menos una fila, significa que el plan se elimino
                            return rowsAffected > 0;
                        }
                    }
                }
                catch/* (SqlException ex)*/
                {
                    // Aquí puedes manejar el error
                    return false;
                }
            }
        }
    }
}