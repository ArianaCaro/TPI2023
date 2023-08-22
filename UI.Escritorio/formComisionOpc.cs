using Data.DataBase;
using DataDAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UI.Escritorio
{
    public partial class formComisionOpc : Form
    {
        bool band = false;
        int id_comision;

        public formComisionOpc(int idComision, string descComision, int anioEspecialidad, int id_plan)
        {
            InitializeComponent();
            cargar_planes();

            if (idComision != 0)          //recibo como parametro el idplan y una x y pregunto si el id es un numero es porque estoy modificando, todo esto para reciclar el formulario de alta y usar el mismo
            {
                this.txtDescripcion.Text = descComision.ToString();
                this.txtAnioEspecialidad.Text = anioEspecialidad.ToString();
                PlanesDAO planDAO = new PlanesDAO();
                this.cmbPlanes.Text = planDAO.ObtenerDescripcionPlanes(id_plan);
                this.btnAceptar.Text = "MODIFICAR";
                this.Text = "Formulario MODIFICAR Comisión";
                band = true;
                id_comision = idComision;
            }
            else
            {
                this.Text = "Formulario ALTA Comisión";
                this.btnAceptar.Text = "AGREGAR";
                // this.cmbEspecialidades.Text = "Seleccione una especialidad";
            }
        }

        //SqlConnection con = new SqlConnection("Server=DESKTOP-QJEDU21;Database=TPI2023M07; Uid=sa; Pwd=sql2023");
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
            if (cmbPlanes.Text.Length == 0 || txtDescripcion.Text.Length == 0/* || txtAnioEspecialidad.Text !=*/)
            {
                MessageBox.Show("Cargar datos correctamente");
            }
            else
            {
                bool resultado;
                if (band == true)       //el band es para saber si es un formulario de modificar o de alta, si es true es de modificar
                {
                    string desc = txtDescripcion.Text;
                    int anio = int.Parse(txtAnioEspecialidad.Text);
                    int plan = (int)cmbPlanes.SelectedValue;

                    ComisionesDAO comisionDAO = new ComisionesDAO();
                    resultado = comisionDAO.ModificarComision(id_comision,desc, anio, plan);
                }
                else
                {
                    string desc = txtDescripcion.Text;
                    int anio = int.Parse(txtAnioEspecialidad.Text);
                    int plan = (int)cmbPlanes.SelectedValue;
                    ComisionesDAO comisionDAO = new ComisionesDAO();
                    resultado = comisionDAO.InsertarComision(desc, anio, plan);
                }

                if (resultado)      //los metodos modificarplan e insertarplan devuelven booleanos, si funciona todo ok muestro cartel
                {
                    MessageBox.Show("La comisión se agrego correctamente");
                }
                else
                {
                    MessageBox.Show("Error al cargar comisión");
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
