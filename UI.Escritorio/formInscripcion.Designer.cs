namespace UI.Escritorio
{
    partial class formInscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvInscripciones = new System.Windows.Forms.DataGridView();
            this.idinscripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnosInscripcionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPI2023M07DataSet7 = new UI.Escritorio.TPI2023M07DataSet7();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtCursoBusqueda = new System.Windows.Forms.TextBox();
            this.alumnos_InscripcionesTableAdapter = new UI.Escritorio.TPI2023M07DataSet7TableAdapters.Alumnos_InscripcionesTableAdapter();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosInscripcionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPI2023M07DataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInscripciones
            // 
            this.dgvInscripciones.AllowUserToAddRows = false;
            this.dgvInscripciones.AutoGenerateColumns = false;
            this.dgvInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idinscripcionDataGridViewTextBoxColumn,
            this.idalumnoDataGridViewTextBoxColumn,
            this.idcursoDataGridViewTextBoxColumn,
            this.condicionDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn});
            this.dgvInscripciones.DataSource = this.alumnosInscripcionesBindingSource;
            this.dgvInscripciones.Location = new System.Drawing.Point(29, 85);
            this.dgvInscripciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInscripciones.Name = "dgvInscripciones";
            this.dgvInscripciones.RowHeadersWidth = 51;
            this.dgvInscripciones.Size = new System.Drawing.Size(999, 342);
            this.dgvInscripciones.TabIndex = 0;
            this.dgvInscripciones.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInscripciones_CellMouseClick);
            // 
            // idinscripcionDataGridViewTextBoxColumn
            // 
            this.idinscripcionDataGridViewTextBoxColumn.DataPropertyName = "id_inscripcion";
            this.idinscripcionDataGridViewTextBoxColumn.HeaderText = "ID Inscripcion";
            this.idinscripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idinscripcionDataGridViewTextBoxColumn.Name = "idinscripcionDataGridViewTextBoxColumn";
            this.idinscripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idinscripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // idalumnoDataGridViewTextBoxColumn
            // 
            this.idalumnoDataGridViewTextBoxColumn.DataPropertyName = "id_alumno";
            this.idalumnoDataGridViewTextBoxColumn.HeaderText = "ID Alumno";
            this.idalumnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idalumnoDataGridViewTextBoxColumn.Name = "idalumnoDataGridViewTextBoxColumn";
            this.idalumnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idcursoDataGridViewTextBoxColumn
            // 
            this.idcursoDataGridViewTextBoxColumn.DataPropertyName = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.HeaderText = "ID Curso";
            this.idcursoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcursoDataGridViewTextBoxColumn.Name = "idcursoDataGridViewTextBoxColumn";
            this.idcursoDataGridViewTextBoxColumn.Width = 125;
            // 
            // condicionDataGridViewTextBoxColumn
            // 
            this.condicionDataGridViewTextBoxColumn.DataPropertyName = "condicion";
            this.condicionDataGridViewTextBoxColumn.HeaderText = "Condicion";
            this.condicionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.condicionDataGridViewTextBoxColumn.Name = "condicionDataGridViewTextBoxColumn";
            this.condicionDataGridViewTextBoxColumn.Width = 125;
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.notaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.Width = 125;
            // 
            // alumnosInscripcionesBindingSource
            // 
            this.alumnosInscripcionesBindingSource.DataMember = "Alumnos_Inscripciones";
            this.alumnosInscripcionesBindingSource.DataSource = this.tPI2023M07DataSet7;
            // 
            // tPI2023M07DataSet7
            // 
            this.tPI2023M07DataSet7.DataSetName = "TPI2023M07DataSet7";
            this.tPI2023M07DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(593, 453);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(100, 28);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(420, 452);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(100, 28);
            this.btnModifica.TabIndex = 2;
            this.btnModifica.Text = "MODIFICAR";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(219, 452);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(100, 28);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "BAJA";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(319, 49);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(928, 46);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtCursoBusqueda
            // 
            this.txtCursoBusqueda.Location = new System.Drawing.Point(83, 49);
            this.txtCursoBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtCursoBusqueda.Name = "txtCursoBusqueda";
            this.txtCursoBusqueda.Size = new System.Drawing.Size(211, 22);
            this.txtCursoBusqueda.TabIndex = 6;
            // 
            // alumnos_InscripcionesTableAdapter
            // 
            this.alumnos_InscripcionesTableAdapter.ClearBeforeFill = true;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(25, 52);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(45, 16);
            this.lblBusqueda.TabIndex = 7;
            this.lblBusqueda.Text = "Curso:";
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(426, 49);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(100, 28);
            this.btnReporte.TabIndex = 8;
            this.btnReporte.Text = "REPORTE";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // formInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 500);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtCursoBusqueda);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.dgvInscripciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosInscripcionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPI2023M07DataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInscripciones;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtCursoBusqueda;
        private TPI2023M07DataSet7 tPI2023M07DataSet7;
        private System.Windows.Forms.BindingSource alumnosInscripcionesBindingSource;
        private TPI2023M07DataSet7TableAdapters.Alumnos_InscripcionesTableAdapter alumnos_InscripcionesTableAdapter;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinscripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReporte;
    }
}