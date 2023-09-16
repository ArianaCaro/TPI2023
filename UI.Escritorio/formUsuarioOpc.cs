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
    public partial class formUsuarioOpc : Form
    {
        Usuario usuarioM;
        bool band = false;
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
               // this.cmbTipoUsuario.Text = usuario;
                //combobox= sdiejfei
                this.btnAceptar.Text = "MODIFICAR";
                this.Text = "Formulario Modificar";
                band = true;
                usuarioM = usuario;

               // PlanesDAO planDAO = new PlanesDAO();
                //this.cmbPlanes.Text = planDAO.ObtenerDescripcionPlanes(persona.IdPlan);     
            }            
        }

        /*  public void cargar_planes()
          {
              PlanesDAO planesDAO = new PlanesDAO();
              DataTable dtPlanes = planesDAO.ObtenerTodosLosPlanes();

              cmbPlanes.ValueMember = "id_plan";
              cmbPlanes.DisplayMember = "desc_plan";
              cmbPlanes.DataSource = dtPlanes;
          }*/

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {                   
                int tipoUsuario = 0; // Valor predeterminado para Administrador 

                if (cmbTipoUsuario.SelectedIndex == 0) // "Alumno" seleccionado
                {
                    tipoUsuario = 1;
                }
                else if (cmbTipoUsuario.SelectedIndex == 1) // "Docente" seleccionado
                {
                    tipoUsuario = 2;
                }

   
               // usuario.TipoUsuario = tipoUsuario;         

            if (cmbTipoUsuario.Text.Length == 0 || txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Cargar datos correctamente");
            }
            else
            {
                UsuariosDAO usuarioDAO = new UsuariosDAO();

                if (band == true)     //el band es para saber si es un formulario de modificar o de alta, si es true es de modificar
                {
                    usuarioM.NombreUsuario = txtNombre.Text;
                    usuarioM.Clave = txtClave.Text;
                    usuarioM.IdPersona = (int)cmbTipoUsuario.SelectedValue;
                    band = usuarioDAO.ModificarUsuario(usuarioM);
                }
                else
                {
                    Usuario usuario = new Usuario
                    {
                        NombreUsuario = txtNombre.Text,
                        Clave = txtClave.Text,
                        IdPersona = (int)cmbTipoUsuario.SelectedValue,
                    };
                    band = usuarioDAO.InsertarUsuario(usuario);
                }

                if (band)
                {
                    MessageBox.Show("Agregado correctamente!");
                }
                else
                {
                    MessageBox.Show("Error al cargar");
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}    