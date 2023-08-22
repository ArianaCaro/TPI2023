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
        int IdComision,AnioEspecialidad,IdPlan;
        string DescComision;

        public formComision()
        {
            InitializeComponent();
        }

        private void formComision_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tPI2023M07DataSet5.Comisiones' Puede moverla o quitarla según sea necesario.
            ActualizarDataGridView();
        }


        private void ActualizarDataGridView()
        {
            ComisionesDAO comisionesDAO = new ComisionesDAO();
            DataTable dtComisiones = comisionesDAO.ObtenerTodasLasComisiones();

            DataColumn descripcionPlanColumn = new DataColumn("Plan", typeof(string));
            dtComisiones.Columns.Add(descripcionPlanColumn);

            // Recorrer las filas y obtener las descripciones de las especialidades
            PlanesDAO planDAO = new PlanesDAO();

            foreach (DataRow row in dtComisiones.Rows)
            {
                int idPlan = Convert.ToInt32(row["id_plan"]);
                string descripcionPlan = planDAO.ObtenerDescripcionPlanes(idPlan);
                row["Plan"] = descripcionPlan;
            }
            dgvComisiones.AutoGenerateColumns = true;
            dgvComisiones.DataSource = dtComisiones;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            formComisionOpc frmComisionOp = new formComisionOpc(0,"x",0,0);
            if (DialogResult.OK == frmComisionOp.ShowDialog()) ;
            ActualizarDataGridView();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            formComisionOpc frmComisionOp = new formComisionOpc(IdComision, DescComision, AnioEspecialidad, IdPlan);
            if (DialogResult.OK == frmComisionOp.ShowDialog()) ;
            ActualizarDataGridView();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Desea borrar {DescComision}", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                ComisionesDAO comisionesDAO = new ComisionesDAO();
                bool eliminado = comisionesDAO.EliminarComision(IdComision, DescComision, AnioEspecialidad, IdPlan);   //eliminado es mi variable bandera para saber si el metodo de eliminar funciono bien
                if (eliminado)                          //si uso el try catch del metodo dentro de db no haria falta todo esto me parece
                {
                    MessageBox.Show("La comisión ha sido eliminada correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar la comisión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Debe seleccionar una comisión antes de realizar la baja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ActualizarDataGridView();
        }

        private void dgvComisiones_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IdComision = int.Parse(dgvComisiones.CurrentRow.Cells[0].Value.ToString());
            DescComision = dgvComisiones.CurrentRow.Cells[1].Value.ToString();
            AnioEspecialidad = int.Parse(dgvComisiones.CurrentRow.Cells[2].Value.ToString());
            IdPlan = int.Parse(dgvComisiones.CurrentRow.Cells[3].Value.ToString());
        }

    }
}
