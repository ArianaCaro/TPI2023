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
    public partial class formMateriaOpc : Form
    {
        bool band = false;
        int id_materia;
        public formMateriaOpc(int idMateria, string descMateria, int hsSemanales, int hsTotales, int id_plan)
        {
            InitializeComponent();
            cargar_planes();

            if (idMateria != 0)          //recibo como parametro el idplan y una x y pregunto si el id es un numero es porque estoy modificando, todo esto para reciclar el formulario de alta y usar el mismo
            {
                this.textBoxDescripMateria.Text = descMateria.ToString();
                this.textBoxHsSem.Text = hsSemanales.ToString();
                PlanesDAO planDAO = new PlanesDAO();
                this.comboBoxDescPlan.Text = planDAO.ObtenerDescripcionPlanes(id_plan);
                this.btnAceptar.Text = "MODIFICAR";
                this.Text = "Formulario MODIFICAR materia";
                band = true;
                id_materia = idMateria;
            }
            else
            {
                this.Text = "Formulario ALTA materia";
                this.btnAceptar.Text = "AGREGAR";
                // this.cmbEspecialidades.Text = "Seleccione una especialidad";
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

        private void formMateriaOpc_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (comboBoxDescPlan.Text.Length == 0 || textBoxDescripMateria.Text.Length == 0/* || textBoxHsSem.Text.Length  == 0*/)
            {
                MessageBox.Show("Completar todos los campos correctamente");
            }
            else
            {
                bool resultado;
                if (band == true)       //el band es para saber si es un formulario de modificar o de alta, si es true es de modificar
                {
                    string desc = textBoxDescripMateria.Text;
                    int hsSemanales = int.Parse(textBoxHsSem.Text);
                    int plan = (int)comboBoxDescPlan.SelectedValue;
                    int hsTotales = (hsSemanales * 40); // 4 semanas en 10 meses son 40 semanas
                    MateriasDAO materiasDAO = new MateriasDAO();
                    resultado = materiasDAO.ModificarMateria(id_materia, desc, hsSemanales, hsTotales, plan);
                }
                else
                {
                    string desc = textBoxDescripMateria.Text;
                    int hsSemanales = int.Parse(textBoxHsSem.Text);
                    int plan = (int)comboBoxDescPlan.SelectedValue;
                    int hsTotales = (hsSemanales * 40); // 4 semanas en 10 meses son 40 semanas
                    MateriasDAO materiasDAO = new MateriasDAO();
                    resultado = materiasDAO.AgregarMateria(desc, hsSemanales, hsTotales, plan);
                }

                if (resultado)      //la var resultado es booleanos, si funciona todo ok muestro cartel
                {
                    MessageBox.Show("La materia se agrego correctamente");
                }
                else
                {
                    MessageBox.Show("Error al cargar materia");
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
