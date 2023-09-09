﻿using System;
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
            /* formLogin appLogin = new formLogin();         //esto es para ejecutar el login pero esta desactivado para ejecutar y probar las otras opciones
             if (appLogin.ShowDialog() != DialogResult.OK)
             {
                 this.Dispose();
             }*/
        }

        private void usuariosMnu_Click(object sender, EventArgs e)
        {
            formPersona frmUsuario = new formPersona();
            frmUsuario.ShowDialog();
        }
        private void alumnosMnu_Click(object sender, EventArgs e)
        {
            formPersona frmAlumno = new formPersona();
            frmAlumno.ShowDialog();
        }
        private void docentesMnu_Click(object sender, EventArgs e)
        {
            formPersona frmDocente = new formPersona();
            frmDocente.ShowDialog();
        }

        #region COMISIONES
        private void comisionesMnu_Click(object sender, EventArgs e)
        {
            formComision frmComision = new formComision();
            frmComision.ShowDialog();
        }
        #endregion

        private void cursosMnu_Click(object sender, EventArgs e)
        {

        }


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

    }
}
