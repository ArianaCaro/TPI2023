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
           /* formLogin appLogin = new formLogin();         //esto es para ejecutar el login pero esta desactivado para ejecutar y probar las otras opciones
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }*/
        }
        private void mnuPlan_Click(object sender, EventArgs e)
        {
            formPlan frmPlan = new formPlan();
            frmPlan.ShowDialog();

        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEspecialidad frmEspecialidad = new formEspecialidad();
            frmEspecialidad.ShowDialog();
        }
    }
}
