using Data.DataBase;
using DataDAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace UI.Escritorio
{
    public partial class formPersonaOpc : Form
    {
        bool band = false;
        Persona personaM;

        public formPersonaOpc(Persona persona)
        {
            InitializeComponent();
            cargar_planes();

            if(persona == null)
            {
                this.Text = "Formulario Alta";
                this.btnAceptar.Text = "AGREGAR";
            }
            else
            {
                this.txtNombre.Text = persona.Nombre;
                this.txtApellido.Text = persona.Apellido;
                this.txtDireccion.Text = persona.Direccion;
                this.txtEmail.Text = persona.Email;
                this.txtTelefono.Text = persona.Telefono;
                this.dtpFechaNac.Text = persona.FechaNac.ToString();
                this.txtLegajo.Text = persona.Legajo.ToString();
                PlanesDAO planDAO = new PlanesDAO();
                this.cmbPlanes.Text = planDAO.ObtenerDescripcionPlanes(persona.IdPlan);

                this.Text = "Formulario Modificar";
                band = true;
                personaM = persona;
            }
        }
        public void cargar_planes()
        {
            PlanesDAO planesDAO = new PlanesDAO();
            DataTable dtPlanes = planesDAO.ObtenerTodosLosPlanes();

            cmbPlanes.ValueMember = "id_plan";
            cmbPlanes.DisplayMember = "desc_plan";
            cmbPlanes.DataSource = dtPlanes;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbPlanes.Text.Length == 0 || txtApellido.Text.Length == 0)
            {
                MessageBox.Show("Cargar datos correctamente");
            }
            else
            {
                PersonasDAO personaDAO = new PersonasDAO();
                Persona persona = new Persona();

                if (band == true)     //el band es para saber si es un formulario de modificar o de alta, si es true es de modificar
                {
                    personaM.Nombre = txtNombre.Text;
                    personaM.Apellido = txtApellido.Text;
                    personaM.Direccion = txtDireccion.Text;
                    personaM.Email = txtEmail.Text;
                    personaM.Telefono = txtTelefono.Text;
                    personaM.FechaNac = dtpFechaNac.Value;
                    personaM.Legajo = int.Parse(txtLegajo.Text);
                    personaM.IdPlan = (int)cmbPlanes.SelectedValue;
                    band = personaDAO.ModificarPersona(personaM);
                }
                else
                {
                    persona = new Persona
                    {
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Direccion = txtDireccion.Text,
                        Email = txtEmail.Text,
                        Telefono = txtTelefono.Text,
                        FechaNac = dtpFechaNac.Value,
                        Legajo = int.Parse(txtLegajo.Text),  
                        IdPlan = (int)cmbPlanes.SelectedValue,
                    };
                    band = personaDAO.InsertarPersona(persona);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}