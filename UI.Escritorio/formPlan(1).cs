using System;
using System.Data;
using System.Windows.Forms;
using Data.DataBase;
using Entidades;

namespace UI.Escritorio
{
    public partial class formPlan : Form
    {
        private Plan planSeleccionado;

        public formPlan()
        {
            InitializeComponent();
            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {          
            PlanesDAO planesDao = new PlanesDAO();
            DataTable dtPlanes = planesDao.ObtenerTodosLosPlanes();

            DataColumn descripcionEspecialidadColumn = new DataColumn("Especialidad", typeof(string));
            dtPlanes.Columns.Add(descripcionEspecialidadColumn);

            EspecialidadesDAO espDAO = new EspecialidadesDAO();
            foreach (DataRow row in dtPlanes.Rows)
            {
                int idEspecialidad = Convert.ToInt32(row["id_Especialidad"]);
                string descripcionEspecialidad = espDAO.ObtenerDescripcionEspecialidad(idEspecialidad); 
                row["Especialidad"] = descripcionEspecialidad;
                
            }       
            dgvPlanes.AutoGenerateColumns = true;          
            dgvPlanes.DataSource = dtPlanes;
            dgvPlanes.Columns["Especialidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Plan nuevoPlan = null;                                            
            formPlanOpc frmPlanOp = new formPlanOpc(nuevoPlan);
            frmPlanOp.ShowDialog();
            ActualizarDataGridView();
        }
     
        private void btnModifica_Click(object sender, EventArgs e)
        {
            formPlanOpc frmPlanOp = new formPlanOpc(planSeleccionado);
            frmPlanOp.ShowDialog();
            ActualizarDataGridView();
        }


        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Desea borrar {planSeleccionado.DescPlan}", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                PlanesDAO planesDAO = new PlanesDAO();
                bool eliminado = planesDAO.EliminarPlan(planSeleccionado);      //eliminado es mi variable bandera para saber si el metodo de eliminar funciono bien

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
                MessageBox.Show("Operación cancelada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ActualizarDataGridView();
        }


        private void dgvPlanes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            planSeleccionado = new Plan
            {
                IdPlan = int.Parse(dgvPlanes.CurrentRow.Cells[0].Value.ToString()),
                DescPlan = dgvPlanes.CurrentRow.Cells[1].Value.ToString(),
                IdEspecialidad = int.Parse(dgvPlanes.CurrentRow.Cells[2].Value.ToString())
            };
        }
    }
}
