﻿using Data.DataBase;
using DataDAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Escritorio
{
    public partial class formMateria : Form
    {
        private Materia materiaSeleccionada;
        public formMateria()
        {
            InitializeComponent();
            ActualizarDataGridView();
        }

        private void formMateria_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {
            MateriasDAO materiasDAO = new MateriasDAO();
            DataTable dtMaterias = materiasDAO.ObtenerTodasLasMaterias();

            DataColumn descripcionPlanColumn = new DataColumn("Plan", typeof(string));
            dtMaterias.Columns.Add(descripcionPlanColumn);

            // Recorrer las filas y obtener las descripciones de las especialidades
            PlanesDAO planDAO = new PlanesDAO();

            foreach (DataRow row in dtMaterias.Rows)
            {
                int idPlan = Convert.ToInt32(row["id_plan"]);
                string descripcionPlan = planDAO.ObtenerDescripcionPlanes(idPlan);
                row["Plan"] = descripcionPlan;
            }
            dgvMaterias.AutoGenerateColumns = true;
            dgvMaterias.DataSource = dtMaterias;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Materia nuevaMateria = null;
            formMateriaOpc frmMateriaOp = new formMateriaOpc(nuevaMateria);
            if (DialogResult.OK == frmMateriaOp.ShowDialog())
                ActualizarDataGridView();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Desea borrar {materiaSeleccionada.DescMateria}", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                MateriasDAO materiasDAO = new MateriasDAO();
                bool eliminado = materiasDAO.EliminarMateria(materiaSeleccionada);   //eliminado es mi variable bandera para saber si el metodo de eliminar funciono bien
                if (eliminado)
                {
                    MessageBox.Show("La materia ha sido eliminada correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Debe seleccionar una materia antes de realizar la baja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ActualizarDataGridView();
        }

        private void dgvMaterias_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            int ht = int.Parse(dgvMaterias.CurrentRow.Cells[2].Value.ToString());
            materiaSeleccionada = new Materia
            {
                IdMateria = int.Parse(dgvMaterias.CurrentRow.Cells[0].Value.ToString()),
                DescMateria = dgvMaterias.CurrentRow.Cells[1].Value.ToString(),
                HsSemanales = int.Parse(dgvMaterias.CurrentRow.Cells[2].Value.ToString()),
                IdPlan = int.Parse(dgvMaterias.CurrentRow.Cells[4].Value.ToString()),
                HsTotales = ht * 40 // 4 semanas en 10 meses son 40 semanas
            };
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            formMateriaOpc frmMateriaOp = new formMateriaOpc(materiaSeleccionada);
            if (DialogResult.OK == frmMateriaOp.ShowDialog())
                ActualizarDataGridView();
        }
    }
}
