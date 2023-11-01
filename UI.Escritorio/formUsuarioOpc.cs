using Servicios;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using UI.Escritorio;

namespace UI.Escritorio
{
    public partial class formUsuarioOpc : Form
    {
        Usuario usuarioM;
        bool band = false;
        int id;
        public formUsuarioOpc(Usuario usuario)      //constructor modificar desde usuario
        {
            InitializeComponent();

            this.txtNombre.Text = usuario.NombreUsuario;
            this.txtClave.Text = usuario.Clave;
            this.btnAceptar.Text = "MODIFICAR";
            this.Text = "Formulario Modificar";
            band = true;
            usuarioM = usuario;
        }
                      

        public formUsuarioOpc(int id_persona)           //constructor alta desde persona
        {
            InitializeComponent();
            this.Text = "Formulario Alta Usuario";
            id = id_persona;
        }


        private void btnAceptar_Click_1(object sender, EventArgs e)
        {  
            if (txtNombre.Text.Length == 0 || txtClave.Text != txtConfirma.Text)
            {
                MessageBox.Show("Complete correctamente todos los campos antes de continuar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                S_Usuario usuarioDAO = new S_Usuario();

                if (this.btnAceptar.Text == "MODIFICAR")     
                {
                    usuarioM.NombreUsuario = txtNombre.Text;
                    usuarioM.Clave = txtClave.Text;
                    band = usuarioDAO.ModificarUsuario(usuarioM);
                }
                else
                {
                    Usuario usuario = new Usuario
                        {
                            NombreUsuario = txtNombre.Text,
                            Clave = txtClave.Text,
                            IdPersona = id,
                        };
                        band = usuarioDAO.InsertarUsuario(usuario);
                }

                if (band == true)
                {
                   // MessageBox.Show("Agregado correctamente!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al cargar usuario");
                }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}