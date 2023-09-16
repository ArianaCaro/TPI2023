using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataBase
{
    public class UsuariosDAO
    {
        // Cadena de conexión a la base de datos
        private string connectionString = "Server=DESKTOP-QJEDU21;Database=TPI2023M07; Uid=sa; Pwd=sql2023";
        //private string connectionString = "Data Source=(localdb)\\NBX;Integrated Security=True";
        //private string connectionString = "Server=MS-12\\SQLEXPRESS;Database=TPI2023M07; Uid=net; Pwd=net";

        public bool InsertarUsuario(Usuario usuario)        // Método para insertar un nuevo usuario en la base de datos
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Usuarios (nombre_usuario, clave, id_persona) VALUES (@nombre_usuario, @clave, @id_persona)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre_usuario", usuario.NombreUsuario);
                        command.Parameters.AddWithValue("@clave", usuario.Clave);
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
                string query = "SELECT id_usuario,nombre_usuario, clave, id_persona FROM Usuarios";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dtUsuarios);
                }
            }
            return dtUsuarios;
        }


        public bool ModificarUsuario(Usuario usuario)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Usuarios SET nombre_usuario = @NuevoNombre, clave = @NuevaClave, id_persona = @NuevoTipoPersona WHERE id_usuario = @IDUsuario";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IDUsuario", usuario.IdUsuario);
                        command.Parameters.AddWithValue("@NuevoNombre", usuario.NombreUsuario);
                        command.Parameters.AddWithValue("@NuevaClave", usuario.Clave);
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
                        string query = "DELETE FROM Usuarios WHERE id_usuario = @id_usuario AND nombre_usuario = @nombre_usuario AND clave = @clave AND id_persona=@id_persona";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id_usuario", usuario.IdUsuario);
                            command.Parameters.AddWithValue("@nombre_usuario", usuario.NombreUsuario);
                            command.Parameters.AddWithValue("@clave", usuario.Clave);
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