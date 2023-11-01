using Data.DataBase;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class S_Comision
    {
        ComisionesDAO ComisionData = new ComisionesDAO();
        public string ObtenerDescripcionComision(int id_comision)
        {
            return ComisionData.ObtenerDescripcionComision(id_comision);
        }


        public DataTable ObtenerTodasLasComisiones()
        {
            return ComisionData.ObtenerTodasLasComisiones();
        }

        public bool InsertarComision(Comision comision)
        {
            return ComisionData.InsertarComision(comision);
        }

        public bool ModificarComision(Comision comision)
        {
            return ComisionData.ModificarComision(comision);
        }
        public bool EliminarComision(Comision comision)
        {
            return ComisionData.EliminarComision(comision);
        }
    }
}
