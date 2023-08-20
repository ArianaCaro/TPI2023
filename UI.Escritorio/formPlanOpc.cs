using Entidades;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DataDAO;
using Data.DataBase;
using System.Data.SqlClient;
using Entidades;

namespace UI.Escritorio
{
    public partial class formPlanOpc : Form
    {
        bool band = false;
        int id_plan;

        public formPlanOpc(int idPlan, string descPlan, int idEspecialidad)
        {
            InitializeComponent();
            cargar_especialidades();

            if (idPlan != 0)          //recibo como parametro el idplan y una x y pregunto si el id es un numero es porque estoy modificando, todo esto para reciclar el formulario de alta y usar el mismo
            {
                this.txtDescPlan.Text = descPlan.ToString();
                EspecialidadesDAO espDAO = new EspecialidadesDAO();
                this.cmbEspecialidades.Text = espDAO.ObtenerDescripcionEspecialidad(idEspecialidad);
                this.btnAgregar.Text = "MODIFICAR";
                this.Text = "Formulario MODIFICAR Plan   " + descPlan;
                band = true;
                id_plan = idPlan;
            }
            else
            {
                this.Text = "Formulario ALTA Plan";
                this.btnAgregar.Text = "AGREGAR";
               // this.cmbEspecialidades.Text = "Seleccione una especialidad";
            }
        }


        /*          //donde se usa esto?
        public Plan ObtenerPlan
        {
            get { return auxPlan; }
            set { auxPlan = value; }
        }*/


        SqlConnection con = new SqlConnection("Server=DESKTOP-QJEDU21;Database=TPI2023M07; Uid=sa; Pwd=sql2023");
        public void cargar_especialidades() {        

            EspecialidadesDAO especialidadesDAO = new EspecialidadesDAO();
            DataTable dtEspecialidades = especialidadesDAO.ObtenerTodasLasEspecialidades();

            cmbEspecialidades.ValueMember = "id_especialidad";
            cmbEspecialidades.DisplayMember = "desc_especialidad";
            cmbEspecialidades.DataSource = dtEspecialidades;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbEspecialidades.Text.Length == 0 || txtDescPlan.Text.Length == 0)
            {
                MessageBox.Show("Cargar datos correctamente");
            }
            else
            {
                bool resultado;
                if (band == true)       //el band es para saber si es un formulario de modificar o de alta, si es true es de modificar
                {
                    string desc = txtDescPlan.Text;
                    int espec = (int)cmbEspecialidades.SelectedValue;

                    PlanesDAO planesDAO = new PlanesDAO();
                    resultado = planesDAO.ModificarPlan(id_plan,desc,espec);
                }
                else
                {
                    string descripcion = txtDescPlan.Text;
                    int id_especialidad = (int)cmbEspecialidades.SelectedValue;
                    PlanesDAO planesDAO = new PlanesDAO();
                    resultado = planesDAO.InsertarPlan(descripcion,id_especialidad);
                }

                if (resultado)      //los metodos modificarplan e insertarplan devuelven booleanos, si funciona todo ok muestro cartel
                {
                    MessageBox.Show("El plan se agrego correctamente");
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
