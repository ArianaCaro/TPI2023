using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using Data.DataBase;

namespace Servicios
{
    public class S_Plan
    {
        PlanesDAO PlanData = new PlanesDAO();

        public DataTable ObtenerTodosLosPlanes()
        {
            return PlanData.ObtenerTodosLosPlanes();
        }

        public bool InsertarPlan(Plan plan)
        {
            return PlanData.InsertarPlan(plan);
        }

        public bool EliminarPlan(Plan plan)
        {
            return PlanData.EliminarPlan(plan);
        }

        public bool ModificarPlan(Plan plan)
        {
            return PlanData.ModificarPlan(plan);
        }

        public string ObtenerDescripcionPlanes(int idPlan)
        {
            return PlanData.ObtenerDescripcionPlanes(idPlan);
        }
    }
}
