using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Materia
    {
        int Id_materia, Hs_semanales, Hs_totales, Id_plan;
        string Desc_materia;

        public int id_materia
        {
            get { return Id_materia; }
            set { Id_materia = value; }
        }

        public int hs_semanales
        {
            get { return Hs_semanales; }
            set { Hs_semanales = value; }
        }
        public int hs_totales
        {
            get { return Hs_totales; }
            set { Hs_totales = value; }
        }

        public int id_plan
        {
            get { return Id_plan; }
            set { Id_plan = value; }
        }
        
        public string desc_materia
        {
            get { return Desc_materia; }
            set { Desc_materia = value; }
        }
    }
}
