﻿using Entidades;
using System;
using System.Data.SqlClient;
using System.Data;

namespace Data.DataBase
{
    public class InscripcionesDAO
    {
        // Cadena de conexión a la base de datos
        private string connectionString = "Server=DESKTOP-QJEDU21;Database=TPI2023M07; Uid=sa; Pwd=sql2023";
        // private string connectionString = "Server=MS-12\\SQLEXPRESS;Database=TPI2023M07; Uid=net; Pwd=net";

        public bool InsertarInscripcion(Comision comision)     // Método para insertar una nueva comision en la base de datos
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Comisiones (desc_comision, anio_especialidad, id_plan) VALUES (@desc_comision, @anio_especialidad, @id_plan)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@desc_comision", comision.DescComision);
                        command.Parameters.AddWithValue("@anio_especialidad", comision.AnioEspecialidad);
                        command.Parameters.AddWithValue(@"id_plan", comision.IdPlan);
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

        public DataTable ObtenerTodasLasInscripciones()
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


        public bool ModificarInscripcion(Comision comision)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Comisiones SET desc_comision = @NuevaDescripcion, anio_especialidad = @NuevoAnioEspecialidad,  id_plan = @NuevoPlan WHERE id_comision = @IDComision";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IDComision", comision.IdComision);
                        command.Parameters.AddWithValue("@NuevaDescripcion", comision.DescComision);
                        command.Parameters.AddWithValue("@NuevoAnioEspecialidad", comision.AnioEspecialidad);
                        command.Parameters.AddWithValue("@NuevoPlan", comision.IdPlan);

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


        public bool EliminarInscripcion(Comision comision)
        {
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Comisiones WHERE id_comision = @id_comision AND desc_comision = @desc_comision AND anio_especialidad = @anio_especialidad AND id_plan = @id_plan";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id_comision", comision.IdComision);
                            command.Parameters.AddWithValue("@desc_comision", comision.DescComision);
                            command.Parameters.AddWithValue("@anio_especialidad", comision.AnioEspecialidad);
                            command.Parameters.AddWithValue("@id_plan", comision.IdPlan);

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