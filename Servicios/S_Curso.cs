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
    public class S_Curso
    {
        CursosDAO CursosData = new CursosDAO();

        public DataTable ObtenerTodasLosCursos()
        {
            return CursosData.ObtenerTodasLosCursos();
        }
        public bool ModificarCurso(Curso curso)
        {
            return CursosData.ModificarCurso(curso);
        }
        public bool InsertarCursos(Curso curso)
        {
            return CursosData.InsertarCursos(curso);
        }
        public bool EliminarCurso(Curso curso)
        {
            return CursosData.EliminarCurso(curso);
        }
    }
}
