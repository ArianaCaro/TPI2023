using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private int id_curso, id_comision, id_materia, anio_calendario, cupo;

        public int IdCurso
        {
            get { return id_curso; }
            set { id_curso = value; }
        }

        public int IdComision
        {
            get { return id_comision; }
            set { id_comision = value; }
        }

        public int IdMateria
        {
            get { return id_materia; }
            set { id_materia = value; }
        }

        public int AnioCalendario
        {
            get { return anio_calendario; }
            set { anio_calendario = value; }
        }

        public int Cupo
        {
            get { return cupo; }
            set { cupo = value; }
        }
    }
}

