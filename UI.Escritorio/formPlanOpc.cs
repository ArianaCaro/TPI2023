using System;
using System.Data;
using System.Windows.Forms;
using Entidades;
using Data.DataBase;

namespace UI.Escritorio
{
    public partial class formPlanOpc : Form
    {
        bool band = false;
        Plan planM;

        public formPlanOpc(Plan plan)
        {
            InitializeComponent();
            cargar_especialidades();

            if (plan == null)
            {
                this.Text = "Formulario ALTA Plan";
                this.btnAgregar.Text = "AGREGAR";
            }
            else
            {
                this.txtDescPlan.Text = plan.DescPlan;
                EspecialidadesDAO espDAO = new EspecialidadesDAO();
                this.cmbEspecialidades.Text = espDAO.ObtenerDescripcionEspecialidad(plan.IdEspecialidad);
                this.btnAgregar.Text = "MODIFICAR";
                this.Text = "Formulario MODIFICAR Plan";
                band = true;
                planM = plan;
            }               
        }
        public void cargar_especialidades() 
        {        
            EspecialidadesDAO especialidadesDAO = new EspecialidadesDAO();
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
                PlanesDAO planesDAO = new PlanesDAO();

                if (band == true)       //el band es para saber si es un formulario de modificar o de alta, si es true es de modificar
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