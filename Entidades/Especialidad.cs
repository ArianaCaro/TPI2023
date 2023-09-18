namespace Entidades
{
    public class Especialidad
    {
        private int id_especialidad;
        private string desc_especialidad;

        public int IdEspecialidad
        {
            get { return id_especialidad; }
            set { id_especialidad = value; }
        }

        public string DescEspecialidad
        {
            get { return desc_especialidad; }
            set { desc_especialidad = value; }
        }
    }
}