using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Data.DataBase
{
    public class UsuariosDAO
    {
        // Cadena de conexión a la base de datos
       // private string connectionString = "Server=DESKTOP-QJEDU21;Database=TPI2023M07; Uid=sa; Pwd=sql2023";
        //private string connectionString = "Data Source=(localdb)\\NBX;Integrated Security=True";
        private string connectionString = "Server=MS-12\\SQLEXPRESS;Database=TPI2023M07; Uid=net; Pwd=net";

        public bool InsertarUsuario(Usuario usuario)        // Método para insertar un nuevo usuario en la base de datos
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Usuarios (nombre_usuario, clave, tipo, id_persona) VALUES (@nombre_usuario, @clave, @tipo, @id_persona)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre_usuario", usuario.NombreUsuario);
                        command.Parameters.AddWithValue("@clave", usuario.Clave);
                        command.Parameters.AddWithValue("@tipo", usuario.Tipo);
                        command.Parameters.AddWithValue("@id_persona", usuario.IdPersona);
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


        public DataTable ObtenerTodosLosUsuarios()
        {
            DataTable dtUsuarios = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id_usuario,nombre_usuario, clave, tipo, id_persona FROM Usuarios";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dtUsuarios);
                }
            }
            return dtUsuarios;
        }


        public DataTable BusquedaFiltrada(string apellido)
        {
            DataTable dtUsuariosFiltrados = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                   // string query = "SELECT id_persona,nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan FROM Personas WHERE tipo_persona = @tipo AND apellido = @apellido";//personas
                    string query = "SELECT U.id_usuario,U.nombre_usuario, U.clave, U.tipo, U.id_persona FROM Usuarios U INNER JOIN Personas P ON P.id_persona = U.id_persona WHERE  P.apellido = @apellido";
                   // string query = "SELECT U.id_usuario,U.usuario, U.clave, U.tipo_usuario, U.id_persona FROM Usuarios U INNER JOIN Personas P ON P.id_persona = U.id_persona WHERE  P.apellido = @apellido";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@apellido", apellido);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dtUsuariosFiltrados);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al realizar la búsqueda: " + ex.Message);
            }
            return dtUsuariosFiltrados;
        }

       
        public string existeUsuario(string nombreUsuario, string clave)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT tipo FROM Usuarios WHERE nombre_usuario = @nombreUsuario AND clave = @clave";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                        command.Parameters.AddWithValue("@clave", clave);

                        object result = command.ExecuteScalar();

                        // Si result es diferente de null, significa que se encontró una coincidencia, devuelvo el tipo de usuario como string
                        if (result != null)
                        {
                            return result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al realizar la búsqueda: " + ex.Message);
            }

            // Si no se encontró ninguna coincidencia o si ocurrió una excepción, retornamos null
            return null;
        }


        public string ObtenerId(string nombreUsuario)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id_usuario FROM Usuarios WHERE nombre_usuario = @nombreUsuario";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                        object result = command.ExecuteScalar();
                        return result.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al realizar la búsqueda: " + ex.Message);
            }

            // Si no se encontró ninguna coincidencia o si ocurrió una excepción, retornamos null
            return null;
        }



        public bool ModificarUsuario(Usuario usuario)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Usuarios SET nombre_usuario = @NuevoNombre, clave = @NuevaClave,tipo = @NuevoTipo, id_persona = @NuevoTipoPersona WHERE id_usuario = @IDUsuario";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IDUsuario", usuario.IdUsuario);
                        command.Parameters.AddWithValue("@NuevoNombre", usuario.NombreUsuario);
                        command.Parameters.AddWithValue("@NuevaClave", usuario.Clave);
                        command.Parameters.AddWithValue("@NuevoTipo", usuario.Tipo);
                        command.Parameters.AddWithValue("@NuevoTipoPersona", usuario.IdPersona);

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


        public bool EliminarUsuario(Usuario usuario)
        {
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Usuarios WHERE id_usuario = @id_usuario AND nombre_usuario = @nombre_usuario AND clave = @clave AND tipo=@tipo AND id_persona=@id_persona";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id_usuario", usuario.IdUsuario);
                            command.Parameters.AddWithValue("@nombre_usuario", usuario.NombreUsuario);
                            command.Parameters.AddWithValue("@clave", usuario.Clave);
                            command.Parameters.AddWithValue("@tipo", usuario.Tipo);
                            command.Parameters.AddWithValue("@id_persona", usuario.IdPersona);

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