using Data.DataBase;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace UI.Escritorio
{
    public partial class formMateriaOpc : Form
    {
        bool band = false;
        Materia materiaN;
        public formMateriaOpc(Materia materia)
        {
            InitializeComponent();
            cargar_planes();

            if (materia == null)
            {
                this.Text = "Formulario ALTA materia";
                this.btnAceptar.Text = "AGREGAR";
            }
            else
            {
                this.Text = "Formulario MODIFICAR materia";
                this.textBoxDescripMateria.Text = materia.DescMateria.ToString();
                this.textBoxHsSem.Text = materia.HsSemanales.ToString();
                PlanesDAO planDAO = new PlanesDAO();
                this.comboBoxDescPlan.Text = planDAO.ObtenerDescripcionPlanes(materia.IdPlan);
                this.btnAceptar.Text = "MODIFICAR";
                band = true;
                materiaN = materia;
            }
        }

        public void cargar_planes()
        {
            PlanesDAO planesDAO = new PlanesDAO();
            DataTable dtPlanes = planesDAO.ObtenerTodosLosPlanes();

            comboBoxDescPlan.ValueMember = "id_plan";
            comboBoxDescPlan.DisplayMember = "desc_plan";
            comboBoxDescPlan.DataSource = dtPlanes;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (comboBoxDescPlan.SelectedIndex < 0 || textBoxDescripMateria.Text.Length == 0 || textBoxHsSem.Text.Length == 0)
            {
                MessageBox.Show("Complete todos los campos antes de continuar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MateriasDAO materiasDAO = new MateriasDAO();
                if (band == true)            //el band es para saber si es un formulario de modificar o de alta, si es true es de modificar
                {
                    materiaN.DescMateria = textBoxDescripMateria.Text;
                    materiaN.HsSemanales = int.Parse(textBoxHsSem.Text);
                    materiaN.IdPlan = (int)comboBoxDescPlan.SelectedValue;
                    materiaN.HsTotales = (materiaN.HsSemanales * 40);           // 4 semanas en 10 meses son 40 semanas
                    band = materiasDAO.ModificarMateria(materiaN);
                }
                else
                {
                    Materia materia = new Materia
                    {
                        DescMateria = textBoxDescripMateria.Text,
                        HsSemanales = int.Parse(textBoxHsSem.Text),
                        IdPlan = (int)comboBoxDescPlan.SelectedValue,
                        HsTotales = (int.Parse(textBoxHsSem.Text) * 40),
                    };
                    band = materiasDAO.AgregarMateria(materia);
                }

                if (band)
                {
                    MessageBox.Show("La materia se agrego correctamente");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al cargar materia");
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}