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
    public class S_Usuario
    {
        UsuariosDAO UsuariosData = new UsuariosDAO();

        public DataTable ObtenerTodosLosUsuarios()
        {
            return UsuariosData.ObtenerTodosLosUsuarios();
        }
        public bool ModificarUsuario(Usuario usuario)
        {
            return UsuariosData.ModificarUsuario(usuario);
        }
        public bool InsertarUsuario(Usuario usuario)
        {
            return UsuariosData.InsertarUsuario(usuario);
        }
        public bool EliminarUsuario(Usuario usuario)
        {
            return UsuariosData.EliminarUsuario(usuario);
        }

        public string existeUsuario(string nombreUsuario, string clave)
        {
            return UsuariosData.existeUsuario(nombreUsuario, clave);
        }

        public string ObtenerId(string nombreUsuario)
        {
            return UsuariosData.ObtenerId(nombreUsuario);
        }
        public DataTable BusquedaFiltrada(string apellido)
        {
            return UsuariosData.BusquedaFiltrada(apellido);
        }
    }
}
