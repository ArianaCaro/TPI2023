using Data.DataBase;
using DataDAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Escritorio
{
    public partial class formComision : Form
    {
        int IdPlan;
        string DescPlan;
        int IdEspecialidad;
        public formComision()
        {
            InitializeComponent();
        }

        private void formComision_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }


        private void ActualizarDataGridView()
        {
         /*   PlanesDAO planesDao = new PlanesDAO();
            DataTable dtPlanes = planesDao.ObtenerTodosLosPlanes();

            DataColumn descripcionEspecialidadColumn = new DataColumn("Especialidad", typeof(string));
            dtPlanes.Columns.Add(descripcionEspecialidadColumn);

            // Recorrer las filas y obtener las descripciones de las especialidades
            EspecialidadesDAO espDAO = new EspecialidadesDAO();

            foreach (DataRow row in dtPlanes.Rows)
            {
                int idEspecialidad = Convert.ToInt32(row["id_Especialidad"]);
                string descripcionEspecialidad = espDAO.ObtenerDescripcionEspecialidad(idEspecialidad);
                row["Especialidad"] = descripcionEspecialidad;
            }
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dtPlanes;*/
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            formComisionOpc frmComisionOp = new formComisionOpc(0,"x",0);
            if (DialogResult.OK == frmComisionOp.ShowDialog()) ;
            ActualizarDataGridView();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            formPlanOpc frmPlanOp = new formPlanOpc(IdPlan, DescPlan, IdEspecialidad);
            formComisionOpc frmComisionOp = new formComisionOpc(0, "x",0);
            if (DialogResult.OK == frmComisionOp.ShowDialog()) ;
            ActualizarDataGridView();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Desea borrar {DescPlan}", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                PlanesDAO planesDAO = new PlanesDAO();
                bool eliminado = planesDAO.EliminarPlan(IdPlan, DescPlan, IdEspecialidad);      //eliminado es mi variable bandera para saber si el metodo de eliminar funciono bien

                if (eliminado)
                {
                    MessageBox.Show("El plan ha sido eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Debe seleccionar un plan antes de realizar la baja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ActualizarDataGridView();
        }
    }
}
