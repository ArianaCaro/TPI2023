using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia
    {
        int id_materia, hs_semanales, hs_totales, id_plan;
        string desc_materia;

        public int IdMateria
        {
            get { return id_materia; }
            set { id_materia = value; }
        }

        public int HsSemanales
        {
            get { return hs_semanales; }
            set { hs_semanales = value; }
        }
        public int HsTotales
        {
            get { return hs_totales; }
            set { hs_totales = value; }
        }

        public int IdPlan
        {
            get { return id_plan; }
            set { id_plan = value; }
        }
        
        public string DescMateria
        {
            get { return desc_materia; }
            set { desc_materia = value; }
        }
    }
}
