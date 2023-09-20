using Data.DataBase;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;


namespace UI.Escritorio
{
    public partial class formInscripcion : Form
    {
        private Inscripcion inscripcionSeleccionada;
        public formInscripcion()
        {
            InitializeComponent();
            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {
            InscripcionesDAO inscripcionDAO = new InscripcionesDAO();
            DataTable dtInscripciones = inscripcionDAO.ObtenerTodasLasInscripciones();

            dtInscripciones.Columns.Add("Nombre", typeof(string));
            dtInscripciones.Columns.Add("Apellido", typeof(string));

            PersonasDAO personaDAO = new PersonasDAO();
            foreach (DataRow row in dtInscripciones.Rows)
            {
                int idAlumno = Convert.ToInt32(row["id_alumno"]);
                string[] nombreApellido = personaDAO.ObtenerNombreApellido(idAlumno).Split(',');

                row["Nombre"] = nombreApellido[0];
                row["Apellido"] = nombreApellido[1];
            }
            dgvInscripciones.AutoGenerateColumns = true;
            dgvInscripciones.DataSource = dtInscripciones;
            dgvInscripciones.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInscripciones.Columns["Apellido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;             
        }


        private void btnAlta_Click(object sender, EventArgs e)
        {
            Inscripcion nuevaInscripcion = null;
            formInscripcionOpc frmInscripcionOp = new formInscripcionOpc(nuevaInscripcion);
            frmInscripcionOp.ShowDialog();
            ActualizarDataGridView();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            formInscripcionOpc frmInscripcionOp = new formInscripcionOpc(inscripcionSeleccionada);
            frmInscripcionOp.ShowDialog();
            ActualizarDataGridView();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Desea borrar {inscripcionSeleccionada.IdInscripcion}", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                InscripcionesDAO inscripcionDAO = new InscripcionesDAO();
                bool eliminado = inscripcionDAO.EliminarInscripcion(inscripcionSeleccionada);   //eliminado es mi variable bandera para saber si el metodo de eliminar funciono bien
                if (eliminado)
                {
                    MessageBox.Show("La inscripcion ha sido eliminada correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar la inscripcion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Operacion cancelada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ActualizarDataGridView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvInscripciones.DataSource = null;
            ActualizarDataGridView();
            dgvInscripciones.Columns["id_usuario"].HeaderText = "ID Inscripcion";
            dgvInscripciones.Columns["nombre_usuario"].HeaderText = "Nombre";
            dgvInscripciones.Columns["clave"].HeaderText = "Apellido";
            dgvInscripciones.Columns["tipo"].HeaderText = "ID Curso";
            dgvInscripciones.Columns["id_persona"].HeaderText = "Condicion";
            dgvInscripciones.Columns["id_persona"].HeaderText = "Nota";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dgvInscripciones_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            inscripcionSeleccionada = new Inscripcion
            {
                IdInscripcion = int.Parse(dgvInscripciones.CurrentRow.Cells[0].Value.ToString()),
                IdAlumno = int.Parse(dgvInscripciones.CurrentRow.Cells[0].Value.ToString()),
                IdCurso = int.Parse(dgvInscripciones.CurrentRow.Cells[0].Value.ToString()),
                Condicion = dgvInscripciones.CurrentRow.Cells[1].Value.ToString(), 
                Nota = int.Parse(dgvInscripciones.CurrentRow.Cells[0].Value.ToString()),
            };
        }
    }
}