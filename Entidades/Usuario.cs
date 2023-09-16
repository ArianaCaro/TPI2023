using System;

namespace Entidades
{
    public class Usuario
    {
        private int id_usuario;
        private string nombre_usuario;
        private string clave;
        private int id_persona;

        public int IdUsuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

        public string NombreUsuario
        {
            get { return nombre_usuario; }
            set { nombre_usuario = value; }
        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public int IdPersona
        {
            get { return id_persona; }
            set { id_persona = value; }
        }
    }
}         