using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Data.DataBase
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
        //private string connectionString = "Data Source=(localdb)\\NBX;Integrated Security=True";
        //private string connectionString = "Server=MS-12\\SQLEXPRESS;Database=TPI2023M07; Uid=net; Pwd=net";

        public bool InsertarPlan(Plan plan)        // Método para insertar un nuevo plan en la base de datos
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Planes (desc_plan, id_especialidad) VALUES (@desc_plan, @id_especialidad)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@desc_plan", plan.DescPlan);
                        command.Parameters.AddWithValue("@id_especialidad", plan.IdEspecialidad);
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





        public bool ModificarPlan(Plan plan)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Planes SET desc_plan = @NuevaDescripcion, id_especialidad = @NuevoIdEspecialidad WHERE id_plan = @IDPlan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IDPlan", plan.IdPlan);
                        command.Parameters.AddWithValue("@NuevaDescripcion", plan.DescPlan);
                        command.Parameters.AddWithValue("@NuevoIdEspecialidad", plan.IdEspecialidad);

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




        public bool EliminarPlan(Plan plan)
        {
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Planes WHERE id_plan = @id_plan AND desc_plan = @desc_plan AND id_especialidad = @id_especialidad";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id_plan", plan.IdPlan);
                            command.Parameters.AddWithValue("@desc_plan", plan.DescPlan);
                            command.Parameters.AddWithValue("@id_especialidad", plan.IdEspecialidad);

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