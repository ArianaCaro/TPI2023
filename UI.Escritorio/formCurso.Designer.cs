namespace UI.Escritorio
{
    partial class formCurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgCursos = new System.Windows.Forms.DataGridView();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.tPI2023M07DataSet1 = new UI.Escritorio.TPI2023M07DataSet1();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursosTableAdapter = new UI.Escritorio.TPI2023M07DataSet1TableAdapters.CursosTableAdapter();
            this.idcursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcomisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aniocalendarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPI2023M07DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgCursos
            // 
            this.dvgCursos.AllowUserToAddRows = false;
            this.dvgCursos.AutoGenerateColumns = false;
            this.dvgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcursoDataGridViewTextBoxColumn,
            this.idmateriaDataGridViewTextBoxColumn,
            this.idcomisionDataGridViewTextBoxColumn,
            this.aniocalendarioDataGridViewTextBoxColumn,
            this.cupoDataGridViewTextBoxColumn});
            this.dvgCursos.DataSource = this.cursosBindingSource;
            this.dvgCursos.Location = new System.Drawing.Point(25, 24);
            this.dvgCursos.Name = "dvgCursos";
            this.dvgCursos.Size = new System.Drawing.Size(545, 252);
            this.dvgCursos.TabIndex = 0;
            this.dvgCursos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgCursos_CellMouseClick);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(412, 298);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(244, 298);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(72, 298);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "ELIMINAR";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // tPI2023M07DataSet1
            // 
            this.tPI2023M07DataSet1.DataSetName = "TPI2023M07DataSet1";
            this.tPI2023M07DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "Cursos";
            this.cursosBindingSource.DataSource = this.tPI2023M07DataSet1;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // idcursoDataGridViewTextBoxColumn
            // 
            this.idcursoDataGridViewTextBoxColumn.DataPropertyName = "id_curso";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idcursoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idcursoDataGridViewTextBoxColumn.HeaderText = "ID Curso";
            this.idcursoDataGridViewTextBoxColumn.Name = "idcursoDataGridViewTextBoxColumn";
            this.idcursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idmateriaDataGridViewTextBoxColumn
            // 
            this.idmateriaDataGridViewTextBoxColumn.DataPropertyName = "id_materia";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idmateriaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idmateriaDataGridViewTextBoxColumn.HeaderText = "ID Materia";
            this.idmateriaDataGridViewTextBoxColumn.Name = "idmateriaDataGridViewTextBoxColumn";
            this.idmateriaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idcomisionDataGridViewTextBoxColumn
            // 
            this.idcomisionDataGridViewTextBoxColumn.DataPropertyName = "id_comision";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idcomisionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.idcomisionDataGridViewTextBoxColumn.HeaderText = "ID Comision";
            this.idcomisionDataGridViewTextBoxColumn.Name = "idcomisionDataGridViewTextBoxColumn";
            this.idcomisionDataGridViewTextBoxColumn.Visible = false;
            // 
            // aniocalendarioDataGridViewTextBoxColumn
            // 
            this.aniocalendarioDataGridViewTextBoxColumn.DataPropertyName = "anio_calendario";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.aniocalendarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.aniocalendarioDataGridViewTextBoxColumn.HeaderText = "AñoCalendario";
            this.aniocalendarioDataGridViewTextBoxColumn.Name = "aniocalendarioDataGridViewTextBoxColumn";
            // 
            // cupoDataGridViewTextBoxColumn
            // 
            this.cupoDataGridViewTextBoxColumn.DataPropertyName = "cupo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cupoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.cupoDataGridViewTextBoxColumn.HeaderText = "Cupo";
            this.cupoDataGridViewTextBoxColumn.Name = "cupoDataGridViewTextBoxColumn";
            // 
            // formCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 328);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.dvgCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPI2023M07DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCursos;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private TPI2023M07DataSet1 tPI2023M07DataSet1;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private TPI2023M07DataSet1TableAdapters.CursosTableAdapter cursosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniocalendarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupoDataGridViewTextBoxColumn;
    }
}