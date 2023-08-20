using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Plan
    {
        private int idPlan;
        private int idEspecialidad;
        private string descripcion;

        public int IdPlan
        {
            get { return idPlan; }
            set { idPlan = value; }
        }

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