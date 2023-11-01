using Data.DataBase;
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
    public partial class formUsuario : Form
    {
        private Usuario usuarioSeleccionado;

        public formUsuario()
        {
            InitializeComponent();
            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {
            UsuariosDAO usuarioDAO = new UsuariosDAO();
            DataTable dtUsuarios = usuarioDAO.ObtenerTodosLosUsuarios();

            dtUsuarios.Columns.Add("Apellido", typeof(string));
            dtUsuarios.Columns.Add("Email", typeof(string)); 

            PersonasDAO personaDAO = new PersonasDAO();
            foreach (DataRow row in dtUsuarios.Rows)
            {

                int idPersona = Convert.ToInt32(row["id_persona"]);
                string[] apellidoEmail = personaDAO.ObtenerApellidoEmail(idPersona).Split(',');

                row["Apellido"] = apellidoEmail[0];
                row["Email"] = apellidoEmail[1];
            }
            dgvUsuarios.AutoGenerateColumns = true;
            dgvUsuarios.DataSource = dtUsuarios;
        }


        private void btnAlta_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = null;
            formUsuarioOpc frmUsuarioOp = new formUsuarioOpc(nuevoUsuario);
            if (DialogResult.OK == frmUsuarioOp.ShowDialog())/*
            formPersonaOpc frmPersona = new formPersonaOpc();
            if (DialogResult.OK == frmPersona.ShowDialog()) */
              ActualizarDataGridView();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            formUsuarioOpc frmUsuarioOp = new formUsuarioOpc(usuarioSeleccionado);
            if (DialogResult.OK == frmUsuarioOp.ShowDialog())
                ActualizarDataGridView();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            {
                DialogResult res = MessageBox.Show($"Desea borrar {usuarioSeleccionado.NombreUsuario}", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    UsuariosDAO usuarioDAO = new UsuariosDAO();
                    bool eliminado = usuarioDAO.EliminarUsuario(usuarioSeleccionado);   //eliminado es mi variable bandera para saber si el metodo de eliminar funciono bien

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
                    MessageBox.Show("Debe seleccionar un usuario antes de realizar la baja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ActualizarDataGridView();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            usuarioSeleccionado = new Usuario
            {
                IdUsuario= int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString()),
                NombreUsuario = dgvUsuarios.CurrentRow.Cells[1].Value.ToString(),
                Clave = dgvUsuarios.CurrentRow.Cells[2].Value.ToString(),
                Tipo = dgvUsuarios.CurrentRow.Cells[3].Value.ToString(),
                IdPersona = int.Parse(dgvUsuarios.CurrentRow.Cells[4].Value.ToString()),          
            };
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
            string apellidoBusqueda = txtApellidoBusca.Text;
            UsuariosDAO usuarioDAO = new UsuariosDAO();
            DataTable dtBusqueda = usuarioDAO.BusquedaFiltrada(apellidoBusqueda);
            
            dtBusqueda.Columns.Add("Apellido", typeof(string));
            dtBusqueda.Columns.Add("Email", typeof(string));

            PersonasDAO personaDAO = new PersonasDAO();
            foreach (DataRow row in dtBusqueda.Rows)
            {

                int idPersona = Convert.ToInt32(row["id_persona"]);
                string[] apellidoEmail = personaDAO.ObtenerApellidoEmail(idPersona).Split(',');

                row["Apellido"] = apellidoEmail[0];
                row["Email"] = apellidoEmail[1];
            }
            dgvUsuarios.AutoGenerateColumns = true;
            dgvUsuarios.DataSource = dtBusqueda;
        }
    }
}