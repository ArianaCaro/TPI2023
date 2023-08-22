using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Data.DataBase
{
    public class ComisionesDAO
    {
        // Cadena de conexión a la base de datos
        private string connectionString = "Server=DESKTOP-QJEDU21;Database=TPI2023M07; Uid=sa; Pwd=sql2023";


        // Método para insertar una nueva comision en la base de datos
        public bool InsertarComision(string descripcion, int anio, int idplan)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Comisiones (desc_comision, anio_especialidad, id_plan) VALUES (@desc_comision, @anio_especialidad, @id_plan)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@desc_comision", descripcion);
                        command.Parameters.AddWithValue("@anio_especialidad", anio);
                        command.Parameters.AddWithValue(@"id_plan", idplan);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (opcional)
                Console.WriteLine("Error al insertar la comision: " + ex.Message);
                return false;
            }
        }


        public DataTable ObtenerTodasLasComisiones()
        {
            DataTable dtComisiones = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id_comision, desc_comision,anio_especialidad, id_plan FROM Comisiones";


                using (SqlCommand commnad = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(commnad);
                    adapter.Fill(dtComisiones);
                }
            }
            return dtComisiones;
        }


        public bool ModificarComision(int idcom, string descripcion, int anio, int idplan)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Comisiones SET desc_comision = @NuevaDescripcion, anio_especialidad = @NuevoAnioEspecialidad,  id_plan = @NuevoPlan WHERE id_comision = @IDComision";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IDComision", idcom);
                        command.Parameters.AddWithValue("@NuevaDescripcion", descripcion);
                        command.Parameters.AddWithValue("@NuevoAnioEspecialidad", anio);
                        command.Parameters.AddWithValue("@NuevoPlan",idplan);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error como consideres necesario (log, mostrar mensaje, etc.)
                Console.WriteLine("Error al modificar la comisión: " + ex.Message);
                return false;
            }
        }




        public bool EliminarComision(int idcom, string descripcion, int anio, int idplan)
        {
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Definir la consulta SQL para eliminar la comision
                        string query = "DELETE FROM Comisiones WHERE id_comision = @id_comision AND desc_comision = @desc_comision AND anio_especialidad = @anio_especialidad AND id_plan = @id_plan";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Agregar los parámetros a la consulta
                            command.Parameters.AddWithValue("@id_comision", idcom);
                            command.Parameters.AddWithValue("@desc_comision", descripcion);
                            command.Parameters.AddWithValue("@anio_especialidad", anio);
                            command.Parameters.AddWithValue("@id_plan", idplan);

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
