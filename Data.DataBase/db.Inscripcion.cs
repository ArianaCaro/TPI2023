using Entidades;
using System;
using System.Data.SqlClient;
using System.Data;

namespace Data.DataBase
{
    public class InscripcionesDAO
    {
        // Cadena de conexión a la base de datos
      //  private string connectionString = "Server=DESKTOP-QJEDU21;Database=TPI2023M07; Uid=sa; Pwd=sql2023";
       //  private string connectionString = "Server=MS-12\\SQLEXPRESS;Database=TPI2023M07; Uid=net; Pwd=net";

        public bool InsertarInscripcion(Inscripcion inscripcion)     // Método para insertar una nueva inscripcion en la base de datos
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Adaptador.GetConnection()))
                {
                    connection.Open();
                    string query = "INSERT INTO Alumnos_Inscripciones (id_alumno,id_curso,condicion,nota) VALUES (@id_alumno,@id_curso,@condicion,@nota)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_alumno", inscripcion.IdAlumno);
                        command.Parameters.AddWithValue("@id_curso", inscripcion.IdCurso);
                        command.Parameters.AddWithValue("@condicion", inscripcion.Condicion);
                        command.Parameters.AddWithValue("@nota", inscripcion.Nota);
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
            DataTable dtInscripciones = new DataTable();

            using (SqlConnection connection = new SqlConnection(Adaptador.GetConnection()))
            {
                string query = "SELECT id_inscripcion, id_alumno, id_curso, condicion,nota FROM Alumnos_Inscripciones";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dtInscripciones);
                }
            }
            return dtInscripciones;
        }

        public DataTable ObtenerInscripcionesAlumno(int id)
        {
            DataTable dtInscripciones = new DataTable();

            using (SqlConnection connection = new SqlConnection(Adaptador.GetConnection()))
            {
                string query = "SELECT id_inscripcion, id_alumno, id_curso, condicion,nota FROM Alumnos_Inscripciones WHERE id_alumno = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dtInscripciones);
                }
            }
            return dtInscripciones;
        }


        public DataTable BusquedaFiltrada(int curso)
        {
            DataTable dtInscripcionesFiltradas = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Adaptador.GetConnection()))
                {
                    connection.Open();
                    string query = "SELECT id_inscripcion, id_alumno, id_curso, condicion,nota FROM Alumnos_Inscripciones WHERE id_curso = @curso";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@curso", curso);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dtInscripcionesFiltradas);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones: muestra un mensaje al usuario o registra la excepción
                Console.WriteLine("Error al realizar la búsqueda: " + ex.Message);
            }
            return dtInscripcionesFiltradas;
        }



        public bool ModificarInscripcion(Inscripcion inscripcion)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Adaptador.GetConnection()))
                {
                    connection.Open();

                    string query = "UPDATE Alumnos_Inscripciones SET id_alumno = @NuevoIdAlumno, id_curso = @NuevoIdCurso, condicion = @NuevaCondicion,  nota = @NuevaNota WHERE id_inscripcion = @id_inscripcion";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_inscripcion", inscripcion.IdInscripcion);
                        command.Parameters.AddWithValue("@NuevoIdAlumno", inscripcion.IdAlumno);
                        command.Parameters.AddWithValue("@NuevoIdCurso", inscripcion.IdCurso);
                        command.Parameters.AddWithValue("@NuevaCondicion", inscripcion.Condicion);
                        command.Parameters.AddWithValue("@NuevaNota", inscripcion.Nota);

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


        public bool EliminarInscripcion(Inscripcion inscripcion)
        {
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(Adaptador.GetConnection()))
                    {
                        connection.Open();
                        string query = "DELETE FROM Alumnos_Inscripciones WHERE id_inscripcion = @id_inscripcion AND id_alumno = @id_alumno AND id_curso = @id_curso AND condicion = @condicion AND nota = @nota";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {   
                            command.Parameters.AddWithValue("@id_inscripcion", inscripcion.IdInscripcion);
                            command.Parameters.AddWithValue("@id_alumno", inscripcion.IdAlumno);
                            command.Parameters.AddWithValue("@id_curso", inscripcion.IdCurso);
                            command.Parameters.AddWithValue("@condicion", inscripcion.Condicion);
                            command.Parameters.AddWithValue("@nota", inscripcion.Nota);

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