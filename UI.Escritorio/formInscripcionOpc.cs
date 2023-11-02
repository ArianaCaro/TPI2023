using Servicios;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI.Escritorio
{
    public partial class formInscripcionOpc : Form
    {
        Inscripcion inscripcionM;
        public formInscripcionOpc()     //constructor si la inscripcion es de alta
        {
            InitializeComponent();
            cargar_cursos();
            this.Text = "Formulario Alta";
            this.btnAceptar.Text = "AGREGAR";
            this.cmbCondicion.Text = "cursando";
            this.txtNota.Text = "0";
            cmbCondicion.Enabled = false;
            txtNota.Enabled = false;
        }
        public formInscripcionOpc(Inscripcion inscripcion)
        {
            InitializeComponent();
            cargar_cursos();

            this.cmbCurso.Text = inscripcion.IdCurso.ToString();
            this.cmbCondicion.Text = inscripcion.Condicion;
            this.txtNota.Text = inscripcion.Nota.ToString();
            this.btnAceptar.Text = "MODIFICAR";
            this.Text = "Formulario Modificar";
            inscripcionM = inscripcion;
            this.cmbCurso.Enabled = false;
        }
           
        

        public void cargar_cursos()
        {
            S_Curso cursosDAO = new S_Curso();
            DataTable dtCursos = cursosDAO.ObtenerTodasLosCursos();

            cmbCurso.ValueMember = "id_curso";
            cmbCurso.DisplayMember = "id_curso";
            cmbCurso.DataSource = dtCursos;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbCurso.SelectedIndex < 0)
            {
                MessageBox.Show("Complete todos los campos antes de continuar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool band;
                S_Inscripcion inscripcionDAO = new S_Inscripcion();

                if (btnAceptar.Text == "MODIFICAR")     
                {
                    inscripcionM.IdAlumno = inscripcionM.IdAlumno;
                    inscripcionM.IdCurso = (int)cmbCurso.SelectedValue;
                    inscripcionM.Condicion = cmbCondicion.SelectedItem as string;
                    inscripcionM.Nota = int.Parse(txtNota.Text);
                    band = inscripcionDAO.ModificarInscripcion(inscripcionM);
                }
                else
                {
                    Inscripcion nuevaInscripcion = new Inscripcion
                    {
                        IdAlumno =formLogin.id_usuario,
                        IdCurso = (int)cmbCurso.SelectedValue,
                        Condicion = (string)cmbCondicion.Text,
                        Nota = int.Parse(txtNota.Text),
                    };
                    band = inscripcionDAO.InsertarInscripcion(nuevaInscripcion);
                }
                if (band)
                {
                    MessageBox.Show("La inscripcion se agregó correctamente");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al cargar inscripcion");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}

