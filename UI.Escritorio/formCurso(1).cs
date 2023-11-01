using Data.DataBase;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI.Escritorio
{
    public partial class formCurso : Form
    {
        private Curso cursoSeleccionado;
        public formCurso()
        {
            InitializeComponent();
            ActualizarDataGridView();
        }


        private void ActualizarDataGridView()
        {
            CursosDAO cursoDAO = new CursosDAO();
            DataTable dtCursos = cursoDAO.ObtenerTodasLosCursos();

            DataColumn descripcionMateriaColumn = new DataColumn("Materia", typeof(string));
            dtCursos.Columns.Add(descripcionMateriaColumn);

            MateriasDAO materiaDAO = new MateriasDAO();
            foreach (DataRow row in dtCursos.Rows)
            {
                int idMateria = Convert.ToInt32(row["id_materia"]);
                string descripcionMateria = materiaDAO.ObtenerDescripcionMateria(idMateria);
                row["Materia"] = descripcionMateria;
            }
            dvgCursos.AutoGenerateColumns = true;
            dvgCursos.DataSource = dtCursos;
            dvgCursos.Columns["Materia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //COLUMNA COMISION

            DataColumn descripcionComisionColumn = new DataColumn("Comision", typeof(string));
            dtCursos.Columns.Add(descripcionComisionColumn);

            ComisionesDAO comisionesDAO = new ComisionesDAO();
            foreach (DataRow row in dtCursos.Rows)
            {
                int idComision = Convert.ToInt32(row["id_comision"]);
                string descripcionComision = comisionesDAO.ObtenerDescripcionComision(idComision);
                row["Comision"] = descripcionComision;
            }
            dvgCursos.AutoGenerateColumns = true;
            dvgCursos.DataSource = dtCursos;
            dvgCursos.Columns["Comision"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Curso nuevoCurso = null;
            formCursoOpc frmCursosOp = new formCursoOpc(nuevoCurso);
            if (DialogResult.OK == frmCursosOp.ShowDialog())
                ActualizarDataGridView();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            formCursoOpc frmCursosOp = new formCursoOpc(cursoSeleccionado);
            if (DialogResult.OK == frmCursosOp.ShowDialog())
                ActualizarDataGridView();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (cursoSeleccionado != null)
            {
                DialogResult res = MessageBox.Show($"Desea borrar {cursoSeleccionado.IdCurso}", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    CursosDAO cursosDAO = new CursosDAO();
                    bool eliminado = cursosDAO.EliminarCurso(cursoSeleccionado);      //eliminado es mi variable bandera para saber si el metodo de eliminar funciono bien

                    if (eliminado)
                    {
                        MessageBox.Show("El curso ha sido eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un curso antes de realizar la baja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ActualizarDataGridView();
        }

        private void dvgCursos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cursoSeleccionado = new Curso
            {
                IdCurso = int.Parse(dvgCursos.CurrentRow.Cells[0].Value.ToString()),
                AnioCalendario = int.Parse(dvgCursos.CurrentRow.Cells[1].Value.ToString()),
                Cupo = int.Parse(dvgCursos.CurrentRow.Cells[2].Value.ToString()),
                IdMateria = int.Parse(dvgCursos.CurrentRow.Cells[4].Value.ToString()),
                IdComision = int.Parse(dvgCursos.CurrentRow.Cells[3].Value.ToString())
            };
        }
    }
}
