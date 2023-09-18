namespace Entidades
{
    public class Plan
    {
        private int id_plan;
        private string desc_plan;
        private int id_especialidad;

        public int IdPlan
        {
            get { return id_plan; }
            set { id_plan = value; }
        }

        public string DescPlan
        {
            get { return desc_plan; }
            set { desc_plan = value; }
        }

        public int IdEspecialidad
        {
            get { return id_especialidad; }
            set { id_especialidad = value; }
        }
    }
}