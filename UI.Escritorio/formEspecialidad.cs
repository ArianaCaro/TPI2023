using Data.DataBase;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI.Escritorio
{
    public partial class formEspecialidad : Form
    {
        int idEspecialidad;
        string descripcion;
        public formEspecialidad()
        {
            InitializeComponent();
        }

        private void formEspecialidad_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {
            // Aquí debes volver a cargar los datos desde la base de datos y asignarlos al DataGridView
            EspecialidadesDAO especialidadesDAO = new EspecialidadesDAO();
            DataTable dtEspecialidades = especialidadesDAO.ObtenerTodasLasEspecialidades();
            dgvEspecialidad.DataSource = dtEspecialidades;
        }

        //cambian los parametros del alta y modifica en formEspecialidadOPC()
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            formEspecialidadOpc frmEspecialidadOp = new formEspecialidadOpc(0,"x");
            if (DialogResult.OK == frmEspecialidadOp.ShowDialog()) ;
            ActualizarDataGridView();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            formEspecialidadOpc frmEspecialidadOp = new formEspecialidadOpc(idEspecialidad,descripcion);
            if (DialogResult.OK == frmEspecialidadOp.ShowDialog()) ;
            ActualizarDataGridView();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Desea borrar {descripcion}", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                EspecialidadesDAO especialidadesDAO = new EspecialidadesDAO();
                bool eliminado = especialidadesDAO.EliminarEspecialidad(idEspecialidad,descripcion);      //eliminado es mi variable bandera para saber si el metodo de eliminar funciono bien

                if (eliminado)
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
                MessageBox.Show("Debe seleccionar una especialidad antes de realizar la baja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ActualizarDataGridView();
        }
        
        private void dgvEspecialidad_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idEspecialidad = int.Parse(dgvEspecialidad.CurrentRow.Cells[0].Value.ToString()); //se crashea si aprieto la null
            descripcion = dgvEspecialidad.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
