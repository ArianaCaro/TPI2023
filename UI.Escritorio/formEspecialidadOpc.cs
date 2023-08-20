using Data.DataBase;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UI.Escritorio
{
    public partial class formEspecialidadOpc : Form
    {
        bool band = false;
        int id_espec;
        public formEspecialidadOpc(int idEspecialidad, string descripcion)
        {
            InitializeComponent();

            if (idEspecialidad != 0)          //recibo como parametro el idplan y una x y pregunto si el id es un numero es porque estoy modificando, todo esto para reciclar el formulario de alta y usar el mismo
            {
                this.txtDescripcion.Text = descripcion.ToString();
                this.btnAceptar.Text = "MODIFICAR";
                this.Text = "Formulario MODIFICAR Especialidad   " + descripcion;
                band = true;
                id_espec = idEspecialidad;
            }
            else
            {
                this.Text = "Formulario ALTA Especialidad";
                this.btnAceptar.Text = "AGREGAR";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (/*txtIdEspecialidad.Text.Length == 0 ||*/ txtDescripcion.Text.Length == 0)
            {
                MessageBox.Show("Cargar datos correctamente");
            }
            else
            {
                bool resultado;
                if (band == true)       //el band es para saber si es un formulario de modificar o de alta, si es true es de modificar
                {
                    //int id = int.Parse(txtIdEspecialidad.Text);
                    //int idEspecialidad = idEspecialidad;
                    string desc = txtDescripcion.Text;

                    EspecialidadesDAO especialidadesDAO = new EspecialidadesDAO();
                    resultado = especialidadesDAO.ModificarEspecialidad(id_espec, desc);
                }
                else
                {
                    string desc = txtDescripcion.Text;

                    EspecialidadesDAO especialidadesDAO = new EspecialidadesDAO();
                    resultado = especialidadesDAO.InsertarEspecialidad(desc);
                }

                if (resultado)      //los metodos modificarplan e insertarplan devuelven booleanos, si funciona todo ok muestro cartel
                {
                    MessageBox.Show("La especialidad se agrego correctamente");
                }
                else
                {
                    MessageBox.Show("Error al cargar Especialidad");
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
