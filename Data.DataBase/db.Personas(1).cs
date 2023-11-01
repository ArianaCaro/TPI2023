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
    public class PersonasDAO
    {
        // Cadena de conexión a la base de datos
       // private string connectionString = "Server=DESKTOP-QJEDU21;Database=TPI2023M07; Uid=sa; Pwd=sql2023";
        //private string connectionString = "Data Source=(localdb)\\NBX;Integrated Security=True";
        private string connectionString = "Server=MS-12\\SQLEXPRESS;Database=TPI2023M07; Uid=net; Pwd=net";

     //   public bool InsertarPersona(Persona persona)        // Método para insertar una nueva persona en la base de datos
        public int InsertarPersona(Persona persona)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) VALUES (@nombre, @apellido, @direccion, @email, @telefono, @fecha_nac, @legajo, @tipo_persona, @id_plan)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", persona.Nombre);
                        command.Parameters.AddWithValue("@apellido", persona.Apellido);
                        command.Parameters.AddWithValue("@direccion", persona.Direccion);
                        command.Parameters.AddWithValue("@email", persona.Email);
                        command.Parameters.AddWithValue("@telefono", persona.Telefono);
                        command.Parameters.AddWithValue("@fecha_nac", persona.FechaNac);
                        command.Parameters.AddWithValue("@legajo", persona.Legajo);
                        command.Parameters.AddWithValue("@tipo_persona", persona.TipoPersona);
                        command.Parameters.AddWithValue("@id_plan", persona.IdPlan);

                        int rowsAffected = command.ExecuteNonQuery();

                        query = "SELECT MAX(id_persona) FROM Personas";
                        using (SqlCommand idCommand = new SqlCommand(query, connection))
                        {
                            object result = idCommand.ExecuteScalar();
                            return Convert.ToInt32(result);
                        }                 
                                                                                    
                        //return 
                        /* if (rowsAffected > 0)
                         {
                             query = "SELECT SCOPE_IDENTITY()";
                             using (SqlCommand idCommand = new SqlCommand(query, connection))
                             {
                                 object result = idCommand.ExecuteScalar();
                                 if (result != null)
                                 {
                                     return Convert.ToInt32(result);         // Retorna el IdPersona generado
                                 }
                             }
                         }*/
                    }
                }
            }
            catch
            {
                return 0;
            }
          //  return 0;
        }
    




        public DataTable ObtenerTodasLasPersonas(int tipo)
        {
            DataTable dtPersonas = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id_persona,nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan FROM Personas WHERE tipo_persona = @tipo";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tipo", tipo); // Usamos un parámetro para el valor de tipo.

                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dtPersonas);
                }
            }
            return dtPersonas;
        }

        public string ObtenerApellidoEmail(int idPersona)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT apellido, email FROM Personas WHERE id_persona = @id_persona";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_persona", idPersona);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read()) {
                            string apellido = reader["apellido"].ToString();
                            string email = reader["email"].ToString();
                            return $"{apellido},{email}";
                        }                       
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (opcional)
                Console.WriteLine("Error al obtener el apellido y correo electrónico: " + ex.Message);
            }
            return null; // Devolver null si no se encuentra la descripción
        }

        public string ObtenerNombreApellido(int idPersona)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT nombre, apellido FROM Personas WHERE id_persona = @id_persona";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_persona", idPersona);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string nombre = reader["nombre"].ToString();
                            string apellido = reader["apellido"].ToString();
                            return $"{nombre},{apellido}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el nombre y apellido: " + ex.Message);
            }
            return null; // Devolver null si no se encuentran
        }

        public DataTable BusquedaFiltrada(int tipo, string apellido)
        {
            DataTable dtPersonasFiltradas = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id_persona,nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan FROM Personas WHERE tipo_persona = @tipo AND apellido = @apellido";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@tipo", tipo);
                        command.Parameters.AddWithValue("@apellido", apellido);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dtPersonasFiltradas);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones: muestra un mensaje al usuario o registra la excepción
                Console.WriteLine("Error al realizar la búsqueda: " + ex.Message);
            }
            return dtPersonasFiltradas;
        }


        // public bool ModificarPersona(Persona persona)
        public int ModificarPersona(Persona persona)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Personas SET nombre = @NuevoNombre, apellido = @NuevoApellido, direccion = @NuevaDireccion, email = @NuevoEmail, telefono = @NuevoTelefono, fecha_nac = @NuevaFechaNac, legajo = @NuevoLegajo, tipo_persona = @NuevoTipoPersona, id_plan = @NuevoIdPlan WHERE id_persona = @IDPersona";


                    using (SqlCommand command = new SqlCommand(query, connection))                                                                                                                                 
                    {
                        command.Parameters.AddWithValue("@IDPersona", persona.IdPersona);
                        command.Parameters.AddWithValue("@NuevoNombre", persona.Nombre);
                        command.Parameters.AddWithValue("@NuevoApellido", persona.Apellido);
                        command.Parameters.AddWithValue("@NuevaDireccion", persona.Direccion);
                        command.Parameters.AddWithValue("@NuevoEmail", persona.Email);
                        command.Parameters.AddWithValue("@NuevoTelefono", persona.Telefono);
                        command.Parameters.AddWithValue("@NuevaFechaNac", persona.FechaNac);
                        command.Parameters.AddWithValue("@NuevoLegajo", persona.Legajo);
                        command.Parameters.AddWithValue("@NuevoTipoPersona", persona.TipoPersona);
                        command.Parameters.AddWithValue("@NuevoIdPlan", persona.IdPlan);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected;
                    }
                }
            }
            catch
            {
                return 0;
            }
        }


        public bool EliminarPersona(Persona persona)
        {
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Personas WHERE id_persona = @id_persona AND nombre = @nombre AND apellido = @apellido AND direccion=@direccion AND email=@email AND telefono=@telefono AND fecha_nac=@fecha_nac AND legajo=@legajo AND tipo_persona=@tipo_persona AND id_plan=@id_plan";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id_persona", persona.IdPersona);
                            command.Parameters.AddWithValue("@nombre", persona.Nombre);
                            command.Parameters.AddWithValue("@apellido", persona.Apellido);
                            command.Parameters.AddWithValue("@direccion", persona.Direccion);
                            command.Parameters.AddWithValue("@email", persona.Email);
                            command.Parameters.AddWithValue("@telefono", persona.Telefono);
                            command.Parameters.AddWithValue("@fecha_nac", persona.FechaNac);
                            command.Parameters.AddWithValue("@legajo", persona.Legajo);
                            command.Parameters.AddWithValue("@tipo_persona", persona.TipoPersona);
                            command.Parameters.AddWithValue("@id_plan", persona.IdPlan);
                            
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