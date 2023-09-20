using Data.DataBase;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI.Escritorio
{
    public partial class formComisionOpc : Form
    {
        bool band = false;
        Comision comisionM;

        public formComisionOpc(Comision comision)
        {
            InitializeComponent();
            cargar_planes();

            if (comision == null)
            {
                this.Text = "Formulario ALTA Comisión";
                this.btnAceptar.Text = "AGREGAR";
            }
            else
            { 
                this.txtDescripcion.Text = comision.DescComision;
                this.txtAnioEspecialidad.Text = comision.AnioEspecialidad.ToString();
                PlanesDAO planDAO = new PlanesDAO();
                this.cmbPlanes.Text = planDAO.ObtenerDescripcionPlanes(comision.IdPlan);
                this.btnAceptar.Text = "MODIFICAR";
                this.Text = "Formulario MODIFICAR Comisión";
                band = true;
                comisionM = comision;
            }
        }
                           
        public void cargar_planes()
        {
            PlanesDAO planesDAO = new PlanesDAO();
            DataTable dtPlanes = planesDAO.ObtenerTodosLosPlanes();

            cmbPlanes.ValueMember = "id_plan";
            cmbPlanes.DisplayMember = "desc_plan";
            cmbPlanes.DataSource = dtPlanes;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbPlanes.SelectedIndex < 0 || txtDescripcion.Text.Length == 0 || txtAnioEspecialidad.Text.Length == 0)
            {
                MessageBox.Show("Complete todos los campos antes de continuar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ComisionesDAO comisionDAO = new ComisionesDAO();   
                
                if (band == true)       //el band es para saber si es un formulario de modificar o de alta, si es true es de modificar
                {
                    comisionM.DescComision = txtDescripcion.Text;
                    comisionM.AnioEspecialidad = int.Parse(txtAnioEspecialidad.Text);
                    comisionM.IdPlan = (int)cmbPlanes.SelectedValue;
                    band = comisionDAO.ModificarComision(comisionM);
                }
                else
                {
                    Comision comision = new Comision
                    {
                        DescComision = txtDescripcion.Text,
                        AnioEspecialidad = int.Parse(txtAnioEspecialidad.Text),
                        IdPlan = (int)cmbPlanes.SelectedValue
                    };
                    band = comisionDAO.InsertarComision(comision);
                }

                if (band)      //los metodos modificarplan e insertarplan devuelven booleanos, si funciona todo ok muestro cartel
                {
                    MessageBox.Show("La comisión se agrego correctamente");
                    this.DialogResult = DialogResult.OK;
                    this.Close();          
                }
                else
                {
                    MessageBox.Show("Error al cargar comisión");
                }         
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
