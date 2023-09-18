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
        int band = 0;
        Persona personaM;
        int tipo_per;

        public formPersonaOpc(Persona persona, int tipo)
        {
            InitializeComponent();
            cargar_planes();
            tipo_per = tipo;

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

                this.btnAceptar.Text = "MODIFICAR";
                this.Text = "Formulario Modificar";
                band = 1;
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
       // public int IdUsuario { get { } set { personaM = value; }} //necesario al crear usuarios
        public int IdUsuario { get; private set; }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbPlanes.Text.Length == 0 || txtApellido.Text.Length == 0)
            {
                MessageBox.Show("Cargar datos correctamente");
            }
            else
            {
                PersonasDAO personaDAO = new PersonasDAO();

                if (band == 1)     //el band es para saber si es un formulario de modificar o de alta, si es 1 es de modificar
                {
                    personaM.Nombre = txtNombre.Text;
                    personaM.Apellido = txtApellido.Text;
                    personaM.Direccion = txtDireccion.Text;
                    personaM.Email = txtEmail.Text;
                    personaM.Telefono = txtTelefono.Text;
                    personaM.FechaNac = dtpFechaNac.Value;
                    personaM.Legajo = int.Parse(txtLegajo.Text);
                    personaM.IdPlan = (int)cmbPlanes.SelectedValue;
                    personaM.TipoPersona = tipo_per;
                    band = personaDAO.ModificarPersona(personaM);
                }
                else
                {
                    Persona persona = new Persona
                    {
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Direccion = txtDireccion.Text,
                        Email = txtEmail.Text,
                        Telefono = txtTelefono.Text,
                        FechaNac = dtpFechaNac.Value,
                        Legajo = int.Parse(txtLegajo.Text),  
                        IdPlan = (int)cmbPlanes.SelectedValue,
                        TipoPersona = tipo_per,
                    };
                    band = personaDAO.InsertarPersona(persona);
                    IdUsuario = band;               //copio el id generado ultimo para poder guardarlo en usuario
                }

                if (band != 0)
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