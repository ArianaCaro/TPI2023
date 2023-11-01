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
    public class S_Persona
    {
        PersonasDAO PersonasData = new PersonasDAO();

        public DataTable ObtenerTodasLasPersonas(int tipo)
        {
            return PersonasData.ObtenerTodasLasPersonas(tipo);
        }
        public int ModificarPersona(Persona persona)
        {
            return PersonasData.ModificarPersona(persona);
        }
        public int InsertarPersona(Persona persona)
        {
            return PersonasData.InsertarPersona(persona);
        }
        public bool EliminarPersona(Persona persona)
        {
            return PersonasData.EliminarPersona(persona);
        }

        public string ObtenerApellidoEmail(int idPersona)
        {
            return PersonasData.ObtenerApellidoEmail(idPersona);
        }

        public string ObtenerNombreApellido(int idPersona)
        {
            return PersonasData.ObtenerNombreApellido(idPersona);
        }

        public DataTable BusquedaFiltrada(int tipo, string apellido)
        {
            return PersonasData.BusquedaFiltrada(tipo, apellido);
        }
    }
}
