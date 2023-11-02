using Servicios;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;


namespace UI.Escritorio
{
    public partial class formCursoOpc : Form
    {
        Curso cursoN;
        public formCursoOpc()
        {
            InitializeComponent();
            cargar_materias();
            cargar_comisiones();
            this.Text = "Formulario ALTA Curso";
            this.btnAceptar.Text = "AGREGAR";
        }


        public formCursoOpc(Curso curso)
        {
            InitializeComponent();
            cargar_materias();
            cargar_comisiones();

            this.btnAceptar.Text = "MODIFICAR";
            this.Text = "Formulario MODIFICAR";
            this.txtAnioCalendario.Text = curso.AnioCalendario.ToString();
            this.txtCupo.Text = curso.Cupo.ToString();
            S_Materia matDAO = new S_Materia();
            this.cmbMateria.Text = matDAO.ObtenerDescripcionMateria(curso.IdMateria);
            S_Comision comDAO = new S_Comision();
            this.cmbComision.Text = comDAO.ObtenerDescripcionComision(curso.IdComision);
            cursoN = curso;
        }
            
        

        public void cargar_materias()
        {
            S_Materia matDAO = new S_Materia();
            DataTable dtMaterias = matDAO.ObtenerTodasLasMaterias();

            cmbMateria.ValueMember = "id_materia";
            cmbMateria.DisplayMember = "desc_materia";
            cmbMateria.DataSource = dtMaterias;
        }
        public void cargar_comisiones()
        {
            S_Comision comDAO = new S_Comision();
            DataTable dtComisiones = comDAO.ObtenerTodasLasComisiones();

            cmbComision.ValueMember = "id_comision";
            cmbComision.DisplayMember = "desc_comision";
            cmbComision.DataSource = dtComisiones;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbMateria.SelectedIndex < 0 || cmbComision.SelectedIndex < 0 || txtAnioCalendario.Text.Length == 0 || txtCupo.Text.Length == 0)
            {
                MessageBox.Show("Complete todos los campos antes de continuar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool band;
                S_Curso cursosDAO = new S_Curso();
                if (this.btnAceptar.Text == "MODIFICAR")       
                {
                    cursoN.AnioCalendario = int.Parse(txtAnioCalendario.Text);
                    cursoN.Cupo = int.Parse(txtCupo.Text);
                    cursoN.IdMateria = (int)cmbMateria.SelectedValue;
                    cursoN.IdComision = (int)cmbComision.SelectedValue;
                    band = cursosDAO.ModificarCurso(cursoN);
                }
                else
                {
                    Curso curso = new Curso
                    {
                        AnioCalendario = int.Parse(txtAnioCalendario.Text),
                        Cupo = int.Parse(txtCupo.Text),
                        IdComision = (int)cmbComision.SelectedValue,
                        IdMateria = (int)cmbMateria.SelectedValue,
                    };
                    band = cursosDAO.InsertarCursos(curso);
                }
                if (band)
                {
                    MessageBox.Show("El curso se agregó correctamente");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al cargar el curso");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}