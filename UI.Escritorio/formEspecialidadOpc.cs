using System;
using System.Data;
using System.Windows.Forms;
using Servicios;
using Entidades;

namespace UI.Escritorio
{
    public partial class formEspecialidadOpc : Form
    {
        Especialidad especialidadM;

        public formEspecialidadOpc()
        {
            InitializeComponent();
            this.Text = "Formulario ALTA Especialidad";
            this.btnAceptar.Text = "AGREGAR";
        }

        public formEspecialidadOpc(Especialidad especialidad)
        {
            InitializeComponent();

            this.txtDescripcion.Text = especialidad.DescEspecialidad;
            this.btnAceptar.Text = "MODIFICAR";
            this.Text = "Formulario MODIFICAR Especialidad";
            especialidadM = especialidad;
        }
            
        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Length == 0)
            {
                MessageBox.Show("Complete el campo antes de continuar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool band;
                S_Especialidad especialidadesDAO = new S_Especialidad();

                if (this.btnAceptar.Text == "MODIFICAR")      
                {
                    especialidadM.DescEspecialidad = txtDescripcion.Text;
                    band = especialidadesDAO.ModificarEspecialidad(especialidadM);
                }
                else
                {
                    Especialidad especialidad = new Especialidad
                    {
                        DescEspecialidad = txtDescripcion.Text
                    };
                    band = especialidadesDAO.InsertarEspecialidad(especialidad);
                }

                if (band)
                {
                    MessageBox.Show("La especialidad se agrego correctamente");      //los metodos modificarplan e insertarplan devuelven booleanos, si funciona todo ok muestro cartel
                    this.DialogResult = DialogResult.OK;
                    this.Close();           // Cierra el formulario después de agregar/modificar exitosamente.
                }
                else
                {
                    MessageBox.Show("Error al cargar la especialidad");
                }
            }
        }
                
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
