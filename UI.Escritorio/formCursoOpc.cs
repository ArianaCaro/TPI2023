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

namespace UI.Escritorio
{
    public partial class formCursoOpc : Form
    {
        public formCursoOpc()
        {
            InitializeComponent();
        }

        bool band = false;
        Curso cursoN;
        public formCursoOpc(Curso curso)
        {
            InitializeComponent();
            cargar_materias();
            cargar_comisiones();

            if (curso == null)
            {
                this.Text = "Formulario ALTA Curso";
                this.btnAceptar.Text = "AGREGAR";
            }
            else
            {
                this.btnAceptar.Text = "MODIFICAR";
                this.Text = "Formulario MODIFICAR Curso   " + curso.IdCurso;
                this.txtAnioCalendario.Text = curso.AnioCalendario.ToString();
                this.txtCupo.Text = curso.Cupo.ToString();
                MateriasDAO matDAO = new MateriasDAO();
                this.cmbMateria.Text = matDAO.ObtenerDescripcionMateria(curso.IdMateria);
                ComisionesDAO comDAO = new ComisionesDAO();
                this.cmbComision.Text = comDAO.ObtenerDescripcionComision(curso.IdComision);
                band = true;
                cursoN = curso;
            }
        }

        public void cargar_materias()
        {
            MateriasDAO matDAO = new MateriasDAO();
            DataTable dtMaterias = matDAO.ObtenerTodasLasMaterias();

            cmbMateria.ValueMember = "id_materia";
            cmbMateria.DisplayMember = "desc_materia";
            cmbMateria.DataSource = dtMaterias;
        }
        public void cargar_comisiones()
        {
            ComisionesDAO comDAO = new ComisionesDAO();
            DataTable dtComisiones = comDAO.ObtenerTodasLasComisiones();

            cmbComision.ValueMember = "id_comision";
            cmbComision.DisplayMember = "desc_comision";
            cmbComision.DataSource = dtComisiones;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbComision.Text.Length == 0 || txtCupo.Text.Length == 0 || txtAnioCalendario.Text.Length == 0 || cmbMateria.Text.Length == 0)
            {
                MessageBox.Show("Cargar datos correctamente");
            }
            else
            {
                CursosDAO cursosDAO = new CursosDAO();
                Curso curso = new Curso();
                if (band == true)       //band: si es true es para modificar sino para dar de alta 
                {
                    cursoN.AnioCalendario = int.Parse(txtAnioCalendario.Text);
                    cursoN.Cupo = int.Parse(txtCupo.Text);
                    if (cmbComision.SelectedValue != null)
                    {
                        if (cmbComision.SelectedValue is int)
                        {
                            cursoN.IdMateria = (int)cmbMateria.SelectedValue;
                            cursoN.IdComision = (int)cmbComision.SelectedValue;//error                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar Curso");
                    }
                    band = cursosDAO.ModificarCurso(cursoN);
                    if (band)
                    {
                        MessageBox.Show("El curso se modifico correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar Curso");
                    }
                }
                else
                {
                    curso = new Curso
                    {
                        AnioCalendario = int.Parse(txtAnioCalendario.Text),
                        Cupo = int.Parse(txtCupo.Text),
                        /* IdComision = cmbComision.Text,
                         IdMateria = cmbMaterias.Text,*/

                        IdComision = (int)cmbComision.SelectedValue,//daba error
                        IdMateria = (int)cmbMateria.SelectedValue //la conversion especifica no es valida
                    };
                    band = cursosDAO.InsertarCursos(curso);
                    if (band)
                    {
                        MessageBox.Show("El curso se agrego correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar Curso");
                    }
                }

                /* if (band)
                 {
                     MessageBox.Show("El curso se agrego correctamente");
                 }
                 else
                 {
                     MessageBox.Show("Error al cargar Curso");
                 }*/
            }
            this.DialogResult = DialogResult.OK;
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
