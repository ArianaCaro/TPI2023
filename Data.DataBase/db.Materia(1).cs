using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;


namespace Data.DataBase
{
    public class MateriasDAO
    {
       // private string connectionString = "Server=DESKTOP-QJEDU21;Database=TPI2023M07; Uid=sa; Pwd=sql2023";
        // private string connectionString = "Data Source=(localdb)\\NBX;Database=TPI2023M07; Integrated Security=True";
        private string connectionString = "Server=MS-12\\SQLEXPRESS;Database=TPI2023M07; Uid=net; Pwd=net";

        public DataTable ObtenerTodasLasMaterias()
        {
            DataTable dtMaterias = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id_materia, desc_materia,hs_semanales, hs_totales, id_plan FROM Materias";
                using (SqlCommand commnad = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(commnad);
                    da.Fill(dtMaterias);
                }
            }
            return dtMaterias;
        }
        public bool AgregarMateria(Materia materia)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Materias (desc_materia, hs_semanales, hs_totales, id_plan) VALUES (@desc_materia, @hs_semanales, @hs_totales, @id_plan)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@desc_materia", materia.DescMateria);
                        command.Parameters.AddWithValue("@hs_semanales", materia.HsSemanales);
                        command.Parameters.AddWithValue("@hs_totales", materia.HsTotales);
                        command.Parameters.AddWithValue("@id_plan", materia.IdPlan);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (opcional)
                Console.WriteLine("Error al insertar la materia: " + ex.Message);
                return false;
            }
        }

        public bool ModificarMateria(Materia materia)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Materias SET desc_materia = @Nueva_desc_materia, hs_semanales = @Nuevo_hs_semanales, hs_totales = @Nuevo_hs_totales, id_plan = @Nuevo_id_plan WHERE id_materia = @IDMateria";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IDMateria", materia.IdMateria);
                        command.Parameters.AddWithValue("@Nueva_desc_materia", materia.DescMateria);
                        command.Parameters.AddWithValue("@Nuevo_hs_semanales", materia.HsSemanales);
                        command.Parameters.AddWithValue("@Nuevo_hs_totales", materia.HsTotales);
                        command.Parameters.AddWithValue("@Nuevo_id_plan", materia.IdPlan);
                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error como consideres necesario (log, mostrar mensaje, etc.)
                Console.WriteLine("Error al modificar la materia: " + ex.Message);
                return false;
            }
        }
        public bool EliminarMateria(Materia materia)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Materias WHERE id_materia = @id_materia";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_materia", materia.IdMateria);

                        int rowsAffected = command.ExecuteNonQuery();

                        // Si se eliminó al menos una fila, significa que el plan se eliminó correctamente
                        return rowsAffected > 0;
                    }
                }
            }
            catch
            {
                return false;
            }   
        }



        public string ObtenerDescripcionMateria(int id_materia)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT desc_materia FROM Materias WHERE id_materia = @id_materia";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_materia", id_materia);
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
                Console.WriteLine("Error al obtener la descripción de la materia: " + ex.Message);
            }

            return null; // Devolver null si no se encuentra la descripción
        }
    }
}
