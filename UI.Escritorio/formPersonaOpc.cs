using Servicios;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UI.Escritorio
{
    public partial class formPersonaOpc : Form
    {
        Persona personaM;
        int tipo_per=0;

        public formPersonaOpc(int tipo) //constructor alta desde persona
        {
            InitializeComponent();
            cargar_planes();
            this.Text = "Formulario Alta";
            this.btnAceptar.Text = "AGREGAR";
            tipo_per = tipo;
            lblTipo.Visible = false;
            cmbTipoUsuario.Visible = false;
        }
        public formPersonaOpc(Persona persona, int tipo)    //constructor modificar desde persona
        {
            InitializeComponent();
            cargar_planes();
            tipo_per = tipo;

            this.txtNombre.Text = persona.Nombre;
            this.txtApellido.Text = persona.Apellido;
            this.txtDireccion.Text = persona.Direccion;
            this.txtEmail.Text = persona.Email;
            this.txtTelefono.Text = persona.Telefono;
            this.dtpFechaNac.Text = persona.FechaNac.ToString();
            this.txtLegajo.Text = persona.Legajo.ToString();
            S_Plan planDAO = new S_Plan();
            this.cmbPlanes.Text = planDAO.ObtenerDescripcionPlanes(persona.IdPlan);

            lblTipo.Visible = false;
            cmbTipoUsuario.Visible = false;

            this.btnAceptar.Text = "MODIFICAR";
            this.Text = "Formulario Modificar";
            personaM = persona;
        }

        public formPersonaOpc()     //constructor alta desde usuario
        {
            InitializeComponent();
            cargar_planes();
            this.btnAceptar.Text = "AGREGAR";
        }
            
       
        public void cargar_planes()
        {
            S_Plan planesDAO = new S_Plan();
            DataTable dtPlanes = planesDAO.ObtenerTodosLosPlanes();

            cmbPlanes.ValueMember = "id_plan";
            cmbPlanes.DisplayMember = "desc_plan";
            cmbPlanes.DataSource = dtPlanes;
        }

        //public int IdPersona { get; private set; }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0 || txtDireccion.Text.Length == 0 || cmbPlanes.SelectedIndex < 0 || txtLegajo.Text.Length == 0)  //dtpFechaNac.TextChanged == false
            {
                MessageBox.Show("Complete todos los campos antes de continuar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int band;
                S_Persona personaDAO = new S_Persona();

                if (this.btnAceptar.Text == "MODIFICAR")
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
                    if(tipo_per == 0)
                    {
                        if (cmbTipoUsuario.SelectedIndex == 0) // "Alumno" seleccionado
                        {
                            tipo_per = 1;
                        }
                        else if (cmbTipoUsuario.SelectedIndex == 1) // "Docente" seleccionado
                        {
                            tipo_per = 2;
                        }
                    }
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
                    formUsuarioOpc frmUsuarioAlta = new formUsuarioOpc(band);        //le creo un usuario a la persona que cargo
                    if (DialogResult.OK == frmUsuarioAlta.ShowDialog()) { } //frmUSuarioAlta.ShowDialog();
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