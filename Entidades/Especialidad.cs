using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Especialidad/*:Entidad*/
    {
        private int idEspecialidad;
        private string descripcion;

        public int IdEspecialidad
        {
            get { return idEspecialidad; }
            set { idEspecialidad = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
