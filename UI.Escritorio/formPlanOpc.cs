using System;
using System.Data;
using System.Windows.Forms;
using Entidades;
using Servicios;

namespace UI.Escritorio
{
    public partial class formPlanOpc : Form
    {
        Plan planM;

        public formPlanOpc()
        {
            InitializeComponent();
            cargar_especialidades();
            this.Text = "Formulario ALTA Plan";
            this.btnAgregar.Text = "AGREGAR";
        }

        public formPlanOpc(Plan plan)
        {
            InitializeComponent();
            cargar_especialidades();

            this.txtDescPlan.Text = plan.DescPlan;
            S_Especialidad espDAO = new S_Especialidad();
            this.cmbEspecialidades.Text = espDAO.ObtenerDescripcionEspecialidad(plan.IdEspecialidad);
            this.btnAgregar.Text = "MODIFICAR";
            this.Text = "Formulario MODIFICAR Plan";
            planM = plan;
        }
                          
        
        public void cargar_especialidades() 
        {
            S_Especialidad especialidadesDAO = new S_Especialidad();
            DataTable dtEspecialidades = especialidadesDAO.ObtenerTodasLasEspecialidades();

            cmbEspecialidades.ValueMember = "id_especialidad";
            cmbEspecialidades.DisplayMember = "desc_especialidad";
            cmbEspecialidades.DataSource = dtEspecialidades;           
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbEspecialidades.SelectedIndex < 0 || txtDescPlan.Text.Length == 0)
            {
                MessageBox.Show("Complete todos los campos antes de continuar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool band;
                S_Plan planesDAO = new S_Plan();

                if (this.btnAgregar.Text == "MODIFICAR")      
                {
                    planM.DescPlan = txtDescPlan.Text;
                    planM.IdEspecialidad = (int)cmbEspecialidades.SelectedValue;
                    band = planesDAO.ModificarPlan(planM);
                }
                else
                {
                    Plan plan = new Plan
                    {
                        DescPlan = txtDescPlan.Text,
                        IdEspecialidad = (int)cmbEspecialidades.SelectedValue
                    };
                    band = planesDAO.InsertarPlan(plan);
                }

                if (band)
                {
                    MessageBox.Show("El plan se agregó correctamente");
                    this.DialogResult = DialogResult.OK;
                    this.Close();           // Cierra el formulario después de agregar/modificar exitosamente.
                }
                else
                {
                    MessageBox.Show("Error al cargar el plan");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}    