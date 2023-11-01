using Data.DataBase;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UI.Escritorio
{
    public partial class formInscripcionOpc : Form
    {
        Inscripcion inscripcionM;
        bool band = false;
        public formInscripcionOpc(Inscripcion inscripcion)
        {
            InitializeComponent();
            cargar_cursos();

            if (inscripcion == null)
            {
                this.Text = "Formulario Alta";
                this.btnAceptar.Text = "AGREGAR";
                this.cmbCondicion.Text = "cursando";
                this.txtNota.Text = "0";
                cmbCondicion.Enabled = false;
                txtNota.Enabled = false;
            }
            else
            {
                this.cmbCurso.Text = inscripcion.IdCurso.ToString();
                this.cmbCondicion.Text = inscripcion.Condicion;
                this.txtNota.Text = inscripcion.Nota.ToString();
                this.btnAceptar.Text = "MODIFICAR";
                this.Text = "Formulario Modificar";
                band = true;
                inscripcionM = inscripcion;
            }
        }

        public void cargar_cursos()
        {
            CursosDAO cursosDAO = new CursosDAO();
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
                InscripcionesDAO inscripcionDAO = new InscripcionesDAO();
                string p;
                if (band == true)     //el band es para saber si es un formulario de modificar o de alta, si es true es de modificar
                {
                    inscripcionM.IdCurso = (int)cmbCurso.SelectedValue;
                    inscripcionM.Condicion = (string)cmbCondicion.SelectedValue;
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

