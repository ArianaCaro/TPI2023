using Servicios;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI.Escritorio
{
    public partial class formPersona : Form
    {
        int tipo_per;
        private Persona personaSeleccionada;
        public formPersona(int tipo)
        {
            InitializeComponent();
            ActualizarDataGridView(tipo);
            tipo_per = tipo;
        }

        private void ActualizarDataGridView(int tipo)
        {
            S_Persona personaDAO = new S_Persona();
            DataTable dtPersonas = personaDAO.ObtenerTodasLasPersonas(tipo);

            DataColumn descripcionPlanColumn = new DataColumn("Plan", typeof(string));
            dtPersonas.Columns.Add(descripcionPlanColumn);

            S_Plan planDAO = new S_Plan();
            foreach (DataRow row in dtPersonas.Rows)
            {
                int idPlan = Convert.ToInt32(row["id_plan"]);
                string descripcionPlan = planDAO.ObtenerDescripcionPlanes(idPlan);
                row["Plan"] = descripcionPlan;
            }
            dgvPersonas.AutoGenerateColumns = true;
            dgvPersonas.DataSource = dtPersonas;
        }


        private void btnAlta_Click(object sender, EventArgs e)
        {
            formPersonaOpc frmPersonaOp = new formPersonaOpc(tipo_per);
            if(DialogResult.OK == frmPersonaOp.ShowDialog())
            ActualizarDataGridView(tipo_per);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            formPersonaOpc frmPersonaOp = new formPersonaOpc(personaSeleccionada,tipo_per);
            if (DialogResult.OK == frmPersonaOp.ShowDialog())
            ActualizarDataGridView(tipo_per);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            {
                DialogResult res = MessageBox.Show($"Desea borrar {personaSeleccionada.Apellido}", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    S_Persona personaDAO = new S_Persona();
                    bool eliminado = personaDAO.EliminarPersona(personaSeleccionada);  //eliminado es mi variable bandera para saber si el metodo de eliminar funciono bien

                    if (eliminado)
                    {
                        MessageBox.Show("Se elimino correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Operacion cancelada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ActualizarDataGridView(tipo_per);
            }
        }

        private void dgvUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            personaSeleccionada = new Persona
            {
                IdPersona = int.Parse(dgvPersonas.CurrentRow.Cells[0].Value.ToString()),
                Nombre = dgvPersonas.CurrentRow.Cells[1].Value.ToString(),
                Apellido = dgvPersonas.CurrentRow.Cells[2].Value.ToString(),
                Direccion = dgvPersonas.CurrentRow.Cells[3].Value.ToString(),
                Email = dgvPersonas.CurrentRow.Cells[4].Value.ToString(),
                Telefono = dgvPersonas.CurrentRow.Cells[5].Value.ToString(),
                FechaNac = (DateTime)dgvPersonas.CurrentRow.Cells[6].Value,
                Legajo = int.Parse(dgvPersonas.CurrentRow.Cells[7].Value.ToString()),
                TipoPersona = tipo_per,
                IdPlan = int.Parse(dgvPersonas.CurrentRow.Cells[9].Value.ToString()),
            };
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvPersonas.DataSource = null;
            ActualizarDataGridView(tipo_per);
            dgvPersonas.Columns["tipo_persona"].Visible = false;
            dgvPersonas.Columns["id_plan"].Visible = false;    
            dgvPersonas.Columns["id_persona"].HeaderText = "ID Persona";
            dgvPersonas.Columns["nombre"].HeaderText = "Nombre";
            dgvPersonas.Columns["apellido"].HeaderText = "Apellido";
            dgvPersonas.Columns["direccion"].HeaderText = "Direccion";
            dgvPersonas.Columns["email"].HeaderText = "Email";
            dgvPersonas.Columns["telefono"].HeaderText = "Telefono";
            dgvPersonas.Columns["fecha_nac"].HeaderText = "FechaNacimiento";
            dgvPersonas.Columns["legajo"].HeaderText = "Legajo";           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string apellidoBusqueda = txtApellidoBusca.Text;
            S_Persona personaDAO = new S_Persona();
            DataTable dtBusqueda = personaDAO.BusquedaFiltrada(tipo_per,apellidoBusqueda);

            DataColumn descripcioPlanColumn = new DataColumn("Plan", typeof(string));
            dtBusqueda.Columns.Add(descripcioPlanColumn);

            S_Plan planDAO = new S_Plan();
            foreach (DataRow row in dtBusqueda.Rows)
            {
                int idPlan = Convert.ToInt32(row["id_plan"]);
                string descripcionPlan = planDAO.ObtenerDescripcionPlanes(idPlan);
                row["Plan"] = descripcionPlan;
            }
            dgvPersonas.AutoGenerateColumns = true;
            dgvPersonas.DataSource = dtBusqueda;
        }
    }
}
