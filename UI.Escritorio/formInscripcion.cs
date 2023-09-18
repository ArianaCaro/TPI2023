using Data.DataBase;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI.Escritorio
{
    public partial class formInscripcion : Form
    {
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
            DialogResult res = MessageBox.Show($"Desea borrar {comisionSeleccionada.DescComision}", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                ComisionesDAO comisionesDAO = new ComisionesDAO();
                bool eliminado = comisionesDAO.EliminarComision(comisionSeleccionada);   //eliminado es mi variable bandera para saber si el metodo de eliminar funciono bien
                if (eliminado)
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
                MessageBox.Show("Operacion cancelada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ActualizarDataGridView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
        dgvUsuarios.DataSource = null;
        ActualizarDataGridView();
        dgvUsuarios.Columns["id_usuario"].HeaderText = "ID Usuario";
        dgvUsuarios.Columns["nombre_usuario"].HeaderText = "Usuario";
        dgvUsuarios.Columns["clave"].HeaderText = "Clave";
        dgvUsuarios.Columns["tipo"].HeaderText = "TipoUsuario";
        dgvUsuarios.Columns["id_persona"].HeaderText = "ID Persona";
    }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dgvComisiones_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comisionSeleccionada = new Comision
            {
                IdComision = int.Parse(dgvComisiones.CurrentRow.Cells[0].Value.ToString()),
                DescComision = dgvComisiones.CurrentRow.Cells[1].Value.ToString(),
                AnioEspecialidad = int.Parse(dgvComisiones.CurrentRow.Cells[2].Value.ToString()),
                IdPlan = int.Parse(dgvComisiones.CurrentRow.Cells[3].Value.ToString())
            };
        }
    }
}