namespace Entidades
{
    public class Comision
    {
        private int id_comision;
        private string desc_comision;
        private int anio_especialidad;
        private int id_plan;

        public int IdComision
        {
            get { return id_comision; }
            set { id_comision = value; }
        }

        public string DescComision
        {
            get { return desc_comision; }
            set { desc_comision = value; }
        }

        public int AnioEspecialidad
        {
            get { return anio_especialidad; }
            set { anio_especialidad = value; }
        }

        public int IdPlan
        {
            get { return id_plan; }
            set { id_plan = value; }
        }
    }
}