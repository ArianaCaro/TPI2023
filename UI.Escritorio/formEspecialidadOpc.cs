using Data.DataBase;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Entidades;

namespace UI.Escritorio
{
    public partial class formEspecialidadOpc : Form
    {
        bool band = false;
        Especialidad especialidadM;

          public formEspecialidadOpc(Especialidad especialidad)
        {
            InitializeComponent();

            if (especialidad == null )
            {
                this.Text = "Formulario ALTA Especialidad";
                this.btnAceptar.Text = "AGREGAR";
            }
            else
            {
                this.txtDescripcion.Text = especialidad.DescEspecialidad;
                this.btnAceptar.Text = "MODIFICAR";
                this.Text = "Formulario MODIFICAR Especialidad   " + especialidad.DescEspecialidad;
                band = true;
                especialidadM = especialidad;

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (/*txtIdEspecialidad.Text.Length == 0 ||*/ txtDescripcion.Text.Length == 0)
            {
                MessageBox.Show("Cargar datos correctamente"); //cambiar msj
            }
            else
            {
                EspecialidadesDAO especialidadesDAO = new EspecialidadesDAO();
                Especialidad especialidad = new Especialidad();
                
                if (band == true)       //el band es para saber si es un formulario de modificar o de alta, si es true es de modificar
                {
                   especialidadM.DescEspecialidad = txtDescripcion.Text;
                   band = especialidadesDAO.ModificarEspecialidad(especialidadM);
                }
                else
                {
                    especialidad = new Especialidad
                    {
                        DescEspecialidad = txtDescripcion.Text
                    };
                    band = especialidadesDAO.InsertarEspecialidad(especialidad);
                }
            }

            if (band)      //los metodos modificarplan e insertarplan devuelven booleanos, si funciona todo ok muestro cartel
            {
                MessageBox.Show("La especialidad se agrego correctamente");
            }
            else
            {
                MessageBox.Show("Error al cargar Especialidad");
            }

            this.DialogResult = DialogResult.OK;   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
