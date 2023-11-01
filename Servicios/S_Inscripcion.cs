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
    public class S_Inscripcion
    {
        InscripcionesDAO InscripcionesData = new InscripcionesDAO();

        public DataTable ObtenerTodasLasInscripciones()
        {
            return InscripcionesData.ObtenerTodasLasInscripciones();
        }
        public bool ModificarInscripcion(Inscripcion inscripcion)
        {
            return InscripcionesData.ModificarInscripcion(inscripcion);
        }
        public bool InsertarInscripcion(Inscripcion inscripcion)
        {
            return InscripcionesData.InsertarInscripcion(inscripcion);
        }
        public bool EliminarInscripcion(Inscripcion inscripcion)
        {
            return InscripcionesData.EliminarInscripcion(inscripcion);
        }

        public DataTable BusquedaFiltrada(int curso)
        {
            return InscripcionesData.BusquedaFiltrada(curso);
        }

        public DataTable ObtenerInscripcionesAlumno(int id)
        {
            return InscripcionesData.ObtenerInscripcionesAlumno(id);
        }
    }
}
