namespace UI.Escritorio
{
    partial class formMateria
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
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.idmateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descmateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hssemanalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hstotalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tPI2023M07DataSet2 = new UI.Escritorio.TPI2023M07DataSet2();
            this.materiasTableAdapter2 = new UI.Escritorio.TPI2023M07DataSet2TableAdapters.MateriasTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPI2023M07DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(371, 233);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(246, 233);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(133, 233);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "ELIMINAR";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Materias";
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AutoGenerateColumns = false;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmateriaDataGridViewTextBoxColumn,
            this.descmateriaDataGridViewTextBoxColumn,
            this.hssemanalesDataGridViewTextBoxColumn,
            this.hstotalesDataGridViewTextBoxColumn,
            this.id_plan});
            this.dgvMaterias.DataSource = this.bindingSource2;
            this.dgvMaterias.Location = new System.Drawing.Point(12, 38);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.Size = new System.Drawing.Size(546, 187);
            this.dgvMaterias.TabIndex = 4;
            this.dgvMaterias.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMaterias_CellMouseClick_1);
            // 
            // idmateriaDataGridViewTextBoxColumn
            // 
            this.idmateriaDataGridViewTextBoxColumn.DataPropertyName = "id_materia";
            this.idmateriaDataGridViewTextBoxColumn.HeaderText = "Materia";
            this.idmateriaDataGridViewTextBoxColumn.Name = "idmateriaDataGridViewTextBoxColumn";
            this.idmateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descmateriaDataGridViewTextBoxColumn
            // 
            this.descmateriaDataGridViewTextBoxColumn.DataPropertyName = "desc_materia";
            this.descmateriaDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descmateriaDataGridViewTextBoxColumn.Name = "descmateriaDataGridViewTextBoxColumn";
            // 
            // hssemanalesDataGridViewTextBoxColumn
            // 
            this.hssemanalesDataGridViewTextBoxColumn.DataPropertyName = "hs_semanales";
            this.hssemanalesDataGridViewTextBoxColumn.HeaderText = "Hs Semanales";
            this.hssemanalesDataGridViewTextBoxColumn.Name = "hssemanalesDataGridViewTextBoxColumn";
            // 
            // hstotalesDataGridViewTextBoxColumn
            // 
            this.hstotalesDataGridViewTextBoxColumn.DataPropertyName = "hs_totales";
            this.hstotalesDataGridViewTextBoxColumn.HeaderText = "Hs Totales";
            this.hstotalesDataGridViewTextBoxColumn.Name = "hstotalesDataGridViewTextBoxColumn";
            // 
            // id_plan
            // 
            this.id_plan.DataPropertyName = "id_plan";
            this.id_plan.HeaderText = "ID Plan";
            this.id_plan.Name = "id_plan";
            this.id_plan.Visible = false;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Materias";
            this.bindingSource2.DataSource = this.tPI2023M07DataSet2;
            // 
            // tPI2023M07DataSet2
            // 
            this.tPI2023M07DataSet2.DataSetName = "TPI2023M07DataSet2";
            this.tPI2023M07DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiasTableAdapter2
            // 
            this.materiasTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 187);
            this.dataGridView1.TabIndex = 4;
            // 
            // formMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 268);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAlta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materias";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPI2023M07DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource MateriasBindingSource;
        private TPI2023M07DataSet5 tPI2023M07DataSet5;
        private System.Windows.Forms.BindingSource materiasBindingSource1;
        private TPI2023M07DataSet5TableAdapters.ComisionesTableAdapter materiasTableAdapter1; //NOSE PORQUE
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private TPI2023M07DataSet2 tPI2023M07DataSet2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private TPI2023M07DataSet2TableAdapters.MateriasTableAdapter materiasTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descmateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hssemanalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hstotalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_plan;
    }
}