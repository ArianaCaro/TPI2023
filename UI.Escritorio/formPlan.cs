using System;
using System.Data;
using System.Windows.Forms;
using Data.DataBase;
using DataDAO;
using Entidades;

namespace UI.Escritorio
{
    public partial class formPlan : Form
    {
        int IdPlan;
        string DescPlan;
        int IdEspecialidad;

        public formPlan()
        {
            InitializeComponent();
        }

        private void formPlan_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tPI2023M07DataSet.Planes' Puede moverla o quitarla según sea necesario.
            this.planesTableAdapter.Fill(this.tPI2023M07DataSet.Planes);
            ActualizarDataGridView();
        }


        private void ActualizarDataGridView()
        {          
            PlanesDAO planesDao = new PlanesDAO();
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
            dataGridView1.DataSource = dtPlanes;
        }

        private void aLTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPlanOpc frmPlanOp = new formPlanOpc(0,"x",0);
            if (DialogResult.OK == frmPlanOp.ShowDialog());
            ActualizarDataGridView();
        }


        private void mODIFICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPlanOpc frmPlanOp = new formPlanOpc(IdPlan, DescPlan,IdEspecialidad);
            if (DialogResult.OK == frmPlanOp.ShowDialog());
            ActualizarDataGridView();
        }


        private void bAJAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Desea borrar {DescPlan}", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                PlanesDAO planesDAO = new PlanesDAO();
                bool eliminado = planesDAO.EliminarPlan(IdPlan,DescPlan,IdEspecialidad);      //eliminado es mi variable bandera para saber si el metodo de eliminar funciono bien

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




        //estos 2 metodos es el mismo, el de abajo soluciona el problema de clikear la fila nula que se corta el programa cuando la clikeas

        /*
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          IdPlan = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
          DescPlan = dataGridView1.CurrentRow.Cells[1].Value.ToString();
          IdEspecialidad = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
        }
        */

        
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             if (dataGridView1.CurrentRow.Cells[0].Value != null)
             {
                int parsedIdPlan;
                if (int.TryParse(dataGridView1.CurrentRow.Cells[0].Value.ToString(), out parsedIdPlan))
                    {
                        IdPlan = parsedIdPlan;
                    }
                else
                {
                    // Manejar el caso en el que la conversión no fue exitosa (por ejemplo, mostrar un mensaje de error)
                    MessageBox.Show("El valor de IdPlan no es un número válido.");
                    return;
                }
             }
             else
             {
                // Manejar el caso en el que la celda está vacía (por ejemplo, mostrar un mensaje de error)
                MessageBox.Show("La celda de IdPlan está vacía.");
                return;
             }

             DescPlan = dataGridView1.CurrentRow.Cells[1].Value.ToString();

             if (dataGridView1.CurrentRow.Cells[2].Value != null)
             {
                int parsedIdEspecialidad;
                if (int.TryParse(dataGridView1.CurrentRow.Cells[2].Value.ToString(), out parsedIdEspecialidad))
                {
                    IdEspecialidad = parsedIdEspecialidad;
                }
                else
                {
                    // Manejar el caso en el que la conversión no fue exitosa (por ejemplo, mostrar un mensaje de error)
                    MessageBox.Show("El valor de IdEspecialidad no es un número válido.");
                }
             }
             else
             {
                // Manejar el caso en el que la celda está vacía (por ejemplo, mostrar un mensaje de error)
                MessageBox.Show("La celda de IdEspecialidad está vacía.");
             }
        }
    }
}
