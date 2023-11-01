using Data.DataBase;
using DataDAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UI.Escritorio
{
    public partial class formPersonaOpc : Form
    {
        int band = 0;
        Persona personaM;
        int tipo_per;
        bool b;

        public formPersonaOpc(Persona persona, int tipo)
        {
            InitializeComponent();
            cargar_planes();
            tipo_per = tipo;
            b = true;

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

        public formPersonaOpc(int tipo_persona/*Persona persona*/)
        {
            InitializeComponent();
            cargar_planes();
            this.Text = "Formulario Alta";
            band = 2;       //NO HARIA FALTA CREO
            tipo_per = tipo_persona;
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
        public int IdPersona { get; private set; }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0 || txtDireccion.Text.Length == 0 || cmbPlanes.SelectedIndex < 0 || txtLegajo.Text.Length == 0)  //dtpFechaNac.TextChanged == false
            {
                MessageBox.Show("Complete todos los campos antes de continuar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PersonasDAO personaDAO = new PersonasDAO();

                if (band == 1)     //el band es para saber si es un formulario de modificar o de alta, si es 1 es de modificar //SE PODRIA USAR personaM como band y preguntar si es not null en vez de la band y gastar memoria
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

                   /* if (band == 0)
                    {*/
                        band = personaDAO.InsertarPersona(persona);                 //NO NECESITO LO DE ABAJO, TERMINAR ACA SI ES DIRECTO DE USUARIO
                        IdPersona = band;
                    if (b == true)
                    {
                        formUsuarioOpc frmUsuarioAlta = new formUsuarioOpc(band);        //le creo un usuario a la persona que cargo
                        if (DialogResult.OK == frmUsuarioAlta.ShowDialog()) { }
                    }

                    //IdPersona = band;
                    /* if (band == 0)//teNGO QUE ENTRAR SI O SI POR ALTA DE ALUMNO O DOCETE DE SUS OPCIONES
                     {
                         formUsuarioOpc frmUsuarioAlta = new formUsuarioOpc(band);        //le creo un usuario a la persona que cargo
                         if (DialogResult.OK == frmUsuarioAlta.ShowDialog()) { }
                     }*/
                    /*}*//*
                    else
                    {
                        band = personaDAO.InsertarPersona(persona);
                    }*/
                    /*
                    band = personaDAO.InsertarPersona(persona);
                    IdPersona = band; */              //copio el id generado ultimo para poder guardarlo en usuario
                                                      //  Usuario usuario = null;
                    /* formUsuarioOpc frmUsuarioAlta = new formUsuarioOpc(IdPersona);        //le creo un usuario a la persona que cargo
                     if (DialogResult.OK == frmUsuarioAlta.ShowDialog()) { }*/
                   // IdPersona = band;
                }

                if (band != 0)
                {
                    MessageBox.Show("Agregado correctamente!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al cargar");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}