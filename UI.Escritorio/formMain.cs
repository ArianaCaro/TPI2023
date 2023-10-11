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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Shown(object sender, EventArgs e) 
        {
            formLogin appLogin = new formLogin();         //esto es para ejecutar el login pero esta desactivado para ejecutar y probar las otras opciones
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
            // Según el rol del usuario autenticado, habilitar o deshabilitar opciones de menú
            switch (appLogin.TipoUsuario)
            {
                case "Alumno":
                    usuariosMnu.Visible = false;
                    alumnosMnu.Visible = false;
                    docentesMnu.Visible = false;
                    comisionesMnu.Visible = true;
                    cursosMnu.Visible = true;
                    materiasMnu.Visible = true;
                    especialidadesMnu.Visible = true;   
                    planesMnu.Visible = true;
                    inscripcionesMnu.Visible = true;    
                    break;
                case "Docente":
                    usuariosMnu.Enabled = false;
                    alumnosMnu.Enabled = true;
                    docentesMnu.Enabled = true;
                    comisionesMnu.Enabled = true;
                    cursosMnu.Enabled = true;
                    materiasMnu.Enabled = true;
                    especialidadesMnu.Enabled = true;
                    planesMnu.Enabled = true;
                    inscripcionesMnu.Enabled = true;
                    break;
            }
        }

        #region USUARIOS
        private void usuariosMnu_Click(object sender, EventArgs e)
        {
            formUsuario frmUsuario = new formUsuario();
            frmUsuario.ShowDialog();
        }
        #endregion

        #region ALUMNOS
        private void alumnosMnu_Click(object sender, EventArgs e)
        {
            formPersona frmAlumno = new formPersona(1);
            frmAlumno.ShowDialog();
        }
        #endregion

        #region DOCENTES
        private void docentesMnu_Click(object sender, EventArgs e)
        {
            formPersona frmDocente = new formPersona(2);
            frmDocente.ShowDialog();
        }
        #endregion

        #region COMISIONES
        private void comisionesMnu_Click(object sender, EventArgs e)
        {
            formComision frmComision = new formComision();
            frmComision.ShowDialog();
        }
        #endregion

        #region CURSOS
        private void cursosMnu_Click(object sender, EventArgs e)
        {
            formCurso frmCurso = new formCurso();
            frmCurso.ShowDialog();
        }
        #endregion

        #region MATERIAS
        private void materiasMnu_Click(object sender, EventArgs e)
        {
            formMateria frmMateria = new formMateria();
            frmMateria.ShowDialog();
        }
        #endregion 

        #region ESPECIALIDADES
        private void especialidadesMnu_Click(object sender, EventArgs e)
        {
            formEspecialidad frmEspecialidad = new formEspecialidad();
            frmEspecialidad.ShowDialog();
        }
        #endregion

        #region PLANES
        private void planesMnu_Click(object sender, EventArgs e)
        {
            formPlan frmPlan = new formPlan();
            frmPlan.ShowDialog();
        }
        #endregion

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formInscripcion frmInscripcion  = new formInscripcion();
            frmInscripcion.ShowDialog();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formInscripcion frmInscripcion = new formInscripcion();
            frmInscripcion.ShowDialog();
        }
    }
}
