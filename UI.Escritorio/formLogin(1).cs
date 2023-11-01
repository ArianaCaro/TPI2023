using Entidades;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Data.DataBase;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace UI.Escritorio
{
    public partial class formLogin : Form
    {
        public string TipoUsuario { get; set; }
        public static int id_usuario { get; set; }

        public formLogin()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuariosDAO usuarioDAO = new UsuariosDAO();
            string b = usuarioDAO.existeUsuario(this.txtUsuario.Text, this.txtPass.Text);
            if (b != null)
            {
                TipoUsuario = b;
                this.DialogResult = DialogResult.OK;
                id_usuario = int.Parse(usuarioDAO.ObtenerId(this.txtUsuario.Text));
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.limpiar();
            }
        }

        private void lnkOlvidaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Estamos en mantenimiento, intente más tarde ", "Olvidé mi contraseña",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void limpiar()
        {
            this.txtUsuario.Text = "";
            this.txtPass.Text = "";
            this.txtUsuario.Focus();
        }
    }
}