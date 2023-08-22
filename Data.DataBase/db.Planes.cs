using System;
using System.Data;
using System.Data.SqlClient; 

namespace DataDAO
{
    /*
    public class dbPlanes : Adaptador
    {
        public List<Plan> TraerTodos()
        {
            List<Plan> planes = new List<Plan>();
            try
            {
                this.AbrirConexion();
                SqlCommand cmdPlanes = new SqlCommand("select * from Planes", SqlCon);
                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();
                while (drPlanes.Read())
                {
                    Plan pl = new Plan();
                  //  pl.ID = (int)drPlanes["id_plan"];
                    pl.Descripcion = (string)drPlanes["desc_plan"];
                    pl.IdEspecialidad = (int)drPlanes["id_especialidad"];

                    planes.Add(pl);
                }
                drPlanes.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de planes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CerrarConexion();
            }
            return planes;
        }

        public Plan TraerUno(int ID)
        {
            Plan pl = new Plan();
            try
            {
                this.AbrirConexion();
                SqlCommand cmdPlanes = new SqlCommand("select * from planes where id_plan = @id", SqlCon);
                cmdPlanes.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();
                if (drPlanes.Read())
                {
                   // pl.ID = (int)drPlanes["id_plan"];
                    pl.Descripcion = (string)drPlanes["desc_plan"];
                    pl.IdEspecialidad = (int)drPlanes["id_especialidad"];
                }
                drPlanes.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar los datos de plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CerrarConexion();
            }
            return pl;
        }

        public void Borrar(int ID)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdBorrar =
                    new SqlCommand("delete planes where id_plan = @id", SqlCon);
                cmdBorrar.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdBorrar.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Actualizar(Plan plan)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdActualizar = new SqlCommand("update planes set desc_plan = @desc_plan, id_especialidad = @id_especialidad WHERE id_plan = @id", SqlCon);

                cmdActualizar.Parameters.Add("@id", SqlDbType.Int).Value = plan.ID;
                cmdActualizar.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdActualizar.Parameters.Add("@id_especialidad", SqlDbType.Int, 50).Value = plan.IdEspecialidad;

                cmdActualizar.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public void Agregar(Plan plan)
        {
            try
            {
                this.AbrirConexion();
                SqlCommand cmdAgregar = new SqlCommand(
                    "insert into planes(desc_plan, id_especialidad) " +
                    "values(@desc_plan, @id_especialidad) " +
                    "select @@identity", SqlCon);

                cmdAgregar.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdAgregar.Parameters.Add("@id_especialidad", SqlDbType.Int, 50).Value = plan.IdEspecialidad;

                //Obtengo el ID que asignó la BD automáticamente
                plan.ID = Decimal.ToInt32((decimal)cmdAgregar.ExecuteScalar());

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear el plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CerrarConexion();
            }
        }
    }
    */



    public class PlanesDAO
    {
        // Cadena de conexión a la base de datos
        private string connectionString = "Server=DESKTOP-QJEDU21;Database=TPI2023M07; Uid=sa; Pwd=sql2023";

        // Método para insertar un nuevo plan en la base de datos
        public bool InsertarPlan(string descripcion, int idEspecialidad)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Planes (desc_plan, id_especialidad) VALUES (@desc_plan, @id_especialidad)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@desc_plan", descripcion);
                        command.Parameters.AddWithValue("@id_especialidad", idEspecialidad);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (opcional)
                Console.WriteLine("Error al insertar el plan: " + ex.Message);
                return false;
            }
        }

        
        public DataTable ObtenerTodosLosPlanes()
        {
            DataTable dtPlanes = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id_plan, desc_plan, id_especialidad FROM Planes";
                                                    

                using (SqlCommand commnad = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(commnad);
                    adapter.Fill(dtPlanes);
                }
            }
            return dtPlanes;
        }

        public string ObtenerDescripcionPlanes(int idPlan)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT desc_plan FROM Planes WHERE id_plan = @id_plan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_plan", idPlan);
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





        public bool ModificarPlan(int id, string desc, int id_espec)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Planes SET desc_plan = @NuevaDescripcion, id_especialidad = @NuevoIdEspecialidad WHERE id_plan = @IDPlan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IDPlan", id);
                        command.Parameters.AddWithValue("@NuevaDescripcion", desc);
                        command.Parameters.AddWithValue("@NuevoIdEspecialidad", id_espec);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error como consideres necesario (log, mostrar mensaje, etc.)
                Console.WriteLine("Error al modificar el plan: " + ex.Message);
                return false;
            }
        }




        public bool EliminarPlan(int id_plan, string descripcion, int id_especialidad)
        {
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Definir la consulta SQL para eliminar el plan
                        string query = "DELETE FROM Planes WHERE id_plan = @id_plan AND desc_plan = @desc_plan AND id_especialidad = @id_especialidad";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Agregar los parámetros a la consulta
                            command.Parameters.AddWithValue("@id_plan", id_plan);
                            command.Parameters.AddWithValue("@desc_plan", descripcion);
                            command.Parameters.AddWithValue("@id_especialidad", id_especialidad);

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


