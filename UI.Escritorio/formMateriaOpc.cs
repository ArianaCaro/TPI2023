using Data.DataBase;
using DataDAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        Materia materiaN;
        public formMateriaOpc(Materia materia)
        {
            InitializeComponent();
            cargar_planes();

            if (materia == null)          //recibo como parametro el idplan y una x y pregunto si el id es un numero es porque estoy modificando, todo esto para reciclar el formulario de alta y usar el mismo
            {
                this.Text = "Formulario ALTA materia";
                this.btnAceptar.Text = "AGREGAR";
                // this.cmbEspecialidades.Text = "Seleccione una especialidad";
            }
            else
            {
                this.Text = "Formulario ALTA materia";
                this.btnAceptar.Text = "AGREGAR";
                // this.cmbEspecialidades.Text = "Seleccione una especialidad";
                this.textBoxDescripMateria.Text = materia.DescMateria.ToString();
                this.textBoxHsSem.Text = materia.HsSemanales.ToString();
                PlanesDAO planDAO = new PlanesDAO();
                this.comboBoxDescPlan.Text = planDAO.ObtenerDescripcionPlanes(materia.IdPlan);
                this.btnAceptar.Text = "MODIFICAR";
                this.Text = "Formulario MODIFICAR materia";
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
                MateriasDAO materiasDAO = new MateriasDAO();
                if (band == true)       //el band es para saber si es un formulario de modificar o de alta, si es true es de modificar
                {
                    materiaN.DescMateria = textBoxDescripMateria.Text;
                    materiaN.HsSemanales = int.Parse(textBoxHsSem.Text);
                    materiaN.IdPlan = (int)comboBoxDescPlan.SelectedValue;
                    materiaN.HsTotales = (materiaN.HsSemanales * 40); // 4 semanas en 10 meses son 40 semanas
                    band = materiasDAO.ModificarMateria(materiaN);
                }
                else
                {

                    materiaN = new Materia
                    {
                        DescMateria = textBoxDescripMateria.Text,
                        HsSemanales = int.Parse(textBoxHsSem.Text),
                        IdPlan = (int)comboBoxDescPlan.SelectedValue,
                        HsTotales = (int.Parse(textBoxHsSem.Text) * 40), // 4 semanas en 10 meses son 40 semanas


                    };
                    band = materiasDAO.AgregarMateria(materiaN);
                }

                if (band)      //la var resultado es booleanos, si funciona todo ok muestro cartel
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
