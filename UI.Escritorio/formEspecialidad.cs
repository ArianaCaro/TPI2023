using System;
using System.Data;
using System.Windows.Forms;
using Data.DataBase;
using Entidades;

namespace UI.Escritorio
{
    public partial class formEspecialidad : Form
    {
        private Especialidad especialidadSeleccionada;

        public formEspecialidad()
        {
            InitializeComponent();
            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()                   //metodo para actualizar la grilla
        {
            EspecialidadesDAO especialidadesDAO = new EspecialidadesDAO();
            DataTable dtEspecialidades = especialidadesDAO.ObtenerTodasLasEspecialidades();
            dgvEspecialidad.DataSource = dtEspecialidades;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Especialidad nuevaEspecialidad = null;
            formEspecialidadOpc frmEspecialidadOp = new formEspecialidadOpc(nuevaEspecialidad);
            frmEspecialidadOp.ShowDialog();
            ActualizarDataGridView();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            formEspecialidadOpc frmEspecialidadOp = new formEspecialidadOpc(especialidadSeleccionada);
            frmEspecialidadOp.ShowDialog();
            ActualizarDataGridView();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Desea borrar {especialidadSeleccionada.DescEspecialidad}", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                EspecialidadesDAO especialidadesDAO = new EspecialidadesDAO();
                bool resultado = especialidadesDAO.EliminarEspecialidad(especialidadSeleccionada);      //el metodo eliminar devuelve bool, true si esta ok

                if (resultado)
                {
                    MessageBox.Show("La especialidad ha sido eliminada correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Operacion cancelada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ActualizarDataGridView();
        }
        
        private void dgvEspecialidad_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)        //metodo para seleccionar clickeando en la grilla
        {
            especialidadSeleccionada = new Especialidad
            {
                IdEspecialidad = int.Parse(dgvEspecialidad.CurrentRow.Cells[0].Value.ToString()),
                DescEspecialidad = dgvEspecialidad.CurrentRow.Cells[1].Value.ToString()
            };
        }
    }
}
