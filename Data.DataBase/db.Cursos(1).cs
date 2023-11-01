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
    public class CursosDAO
    {
        // Cadena de conexión a la base de datos
        //private string connectionString = "Server=DESKTOP-QJEDU21;Database=TPI2023M07; Uid=sa; Pwd=sql2023";
        private string connectionString = "Server=MS-12\\SQLEXPRESS;Database=TPI2023M07; Uid=net; Pwd=net";
        //private string connectionString = "Data Source=(localdb)\\NBX;Database=TPI2023M07; Integrated Security=True";

        public bool InsertarCursos(Curso curso)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Cursos (anio_calendario, cupo, id_comision, id_materia) VALUES (@anio_calendario, @cupo, @id_comision, @id_materia)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@anio_calendario", curso.AnioCalendario);
                        command.Parameters.AddWithValue("@cupo", curso.Cupo);
                        command.Parameters.AddWithValue("@id_comision", curso.IdComision);
                        command.Parameters.AddWithValue("@id_materia", curso.IdMateria);
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

        public DataTable ObtenerTodasLosCursos()
        {
            DataTable dtCursos = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id_curso, anio_calendario, cupo, id_comision, id_materia FROM Cursos";


                using (SqlCommand commnad = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(commnad);
                    adapter.Fill(dtCursos);
                }
            }
            return dtCursos;
        }
        public bool ModificarCurso(Curso curso)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Cursos SET id_comision = @NuevaIdComision, id_materia = @NuevaIdMateria, anio_calendario = @NuevoAnioCalendario,  cupo = @NuevoCupo WHERE id_curso = @IdCurso";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCurso", curso.IdCurso);
                        command.Parameters.AddWithValue("@NuevaIdComision", curso.IdComision);
                        command.Parameters.AddWithValue("@NuevaIdMateria", curso.IdMateria);
                        command.Parameters.AddWithValue("@NuevoAnioCalendario", curso.AnioCalendario);
                        command.Parameters.AddWithValue("@NuevoCupo", curso.Cupo);

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
        public bool EliminarCurso(Curso curso)
        {
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Cursos WHERE  id_curso = @id_curso";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id_curso", curso.IdCurso);
                            command.Parameters.AddWithValue("@id_comision", curso.IdComision);
                            command.Parameters.AddWithValue("@id_materia", curso.IdMateria);
                            command.Parameters.AddWithValue("@anio_calendario", curso.AnioCalendario);
                            command.Parameters.AddWithValue("@cupo", curso.Cupo);

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
