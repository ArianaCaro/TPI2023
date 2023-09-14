using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDAO
{ 
    public class PersonasDAO
    {
        // Cadena de conexión a la base de datos
        private string connectionString = "Server=DESKTOP-QJEDU21;Database=TPI2023M07; Uid=sa; Pwd=sql2023";
        //private string connectionString = "Data Source=(localdb)\\NBX;Integrated Security=True";
        //private string connectionString = "Server=MS-12\\SQLEXPRESS;Database=TPI2023M07; Uid=net; Pwd=net";

        public bool InsertarPersona(Persona persona)        // Método para insertar una nueva persona en la base de datos
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
                        return rowsAffected > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
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
                   
    
        public bool ModificarPersona(Persona persona)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Personas SET nombre = @nuevoNombre, apellido = @NuevoApellido, direccion = @NuevaDireccion, email = @NuevoEmail, telefono = @NuevoTelefono, fecha_nac = @NuevaFechaNac, legajo = @NuevoLegajo, tipo_persona = @NuevoTipoPersona, id_plan = @NuevoIdPlan WHERE id_persona = @IDPersona";


                    using (SqlCommand command = new SqlCommand(query, connection))                                                                                                                                 
                    {
                        command.Parameters.AddWithValue("@IDPersona", persona.IdPersona);
                        command.Parameters.AddWithValue("@NuevoApellido", persona.Apellido);
                        command.Parameters.AddWithValue("@NuevaDireccion", persona.Direccion);
                        command.Parameters.AddWithValue("@NuevoEmail", persona.Email);
                        command.Parameters.AddWithValue("@NuevoTelefono", persona.Telefono);
                        command.Parameters.AddWithValue("@NuevaFechaNac", persona.FechaNac);
                        command.Parameters.AddWithValue("@NuevoLegajo", persona.Legajo);
                        command.Parameters.AddWithValue("@NuevoTipoPersona", persona.TipoPersona);
                        command.Parameters.AddWithValue("@NuevoIdPlan", persona.IdPlan);

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