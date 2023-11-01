using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Escritorio.Reportes
{
    public partial class formReporteNotas : Form
    {
        public static int _reporte = 0;
        public formReporteNotas()
        {
            InitializeComponent();
        }

        private void formReporteNotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_reportes.DataTable1' Puede moverla o quitarla según sea necesario.
            
            try//if (txtIdCurso_Reporte.Text != null)
            {
                this.dataTable1TableAdapter.Fill(this.dS_reportes.DataTable1, id_curso: int.Parse(txtIdCurso_Reporte.Text));
                this.reportViewer1.RefreshReport();
            }
            catch//else if (txtIdCurso_Reporte == null)
            {
                _reporte = 0;
                //MessageBox.Show("Ingrese id de curso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                //this.Show();
            }
            
        }
    }
}
