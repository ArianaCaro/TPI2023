using System;

namespace Entidades
{
    public class Persona
    {
        private int id_persona;
        private string nombre;
        private string apellido;
        private string direccion;
        private string email;
        private string telefono;
        private DateTime fecha_nac;
        private int legajo;
        private int tipo_persona;
        private int id_plan;

        public int IdPersona
        {
            get { return id_persona; }
            set { id_persona = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public DateTime FechaNac
        {
            get { return fecha_nac; }
            set { fecha_nac = value; }
        }

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public int TipoPersona
        {
            get { return tipo_persona; }
            set { tipo_persona = value; }
        }
        public int IdPlan
        {
            get { return id_plan; }
            set { id_plan = value; }
        }
    }
}