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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using UI.Escritorio;

namespace UI.Escritorio
{
    public partial class formUsuarioOpc : Form
    {
        Usuario usuarioM;
        bool band = false;
       // int id;
        public formUsuarioOpc(Usuario usuario)
        {
            InitializeComponent();
            
            if(usuario == null)
            {
                this.Text = "Formulario Alta";
                this.btnAceptar.Text = "AGREGAR";
            }
            else
            {
                this.txtNombre.Text = usuario.NombreUsuario;
                this.txtClave.Text = usuario.Clave;
                this.txtConfirma.Text = usuario.Clave;
                this.cmbTipoUsuario.Text = usuario.Tipo;
               // this.cmbTipoUsuario.Text = usuario;
                //combobox= sdiejfei
                this.btnAceptar.Text = "MODIFICAR";
                this.Text = "Formulario Modificar";
                band = true;
                usuarioM = usuario;    
            }            
        }


        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            int id;     
            if (txtNombre.Text.Length == 0 || cmbTipoUsuario.SelectedIndex < 0 || txtClave.Text != txtConfirma.Text)
            {
                MessageBox.Show("Complete correctamente todos los campos antes de continuar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UsuariosDAO usuarioDAO = new UsuariosDAO();

                if (band == true)     //el band es para saber si es un formulario de modificar o de alta, si es true es de modificar
                {
                    usuarioM.NombreUsuario = txtNombre.Text;
                    usuarioM.Clave = txtClave.Text;
                    usuarioM.Tipo = cmbTipoUsuario.Text;
                    band = usuarioDAO.ModificarUsuario(usuarioM);
                }
                else
                {
                    Persona nuevaPersona = null;
                    int tipoUsuario = 0; // Valor predeterminado para administrador

                    if (cmbTipoUsuario.SelectedIndex == 0) // "Alumno" seleccionado
                    {
                        tipoUsuario = 1;
                    }
                    else if (cmbTipoUsuario.SelectedIndex == 1) // "Docente" seleccionado
                    {
                        tipoUsuario = 2;
                    }

                    formPersonaOpc frmPersonaAlta = new formPersonaOpc(nuevaPersona, tipoUsuario);
                    if (DialogResult.OK == frmPersonaAlta.ShowDialog()) { }

                    id = frmPersonaAlta.IdUsuario;
                    Usuario usuario = new Usuario
                    {
                        NombreUsuario = txtNombre.Text,
                        Clave = txtClave.Text,
                        Tipo = cmbTipoUsuario.Text,
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
                    MessageBox.Show("Error al cargar");
                }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}