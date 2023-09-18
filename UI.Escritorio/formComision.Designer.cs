namespace UI.Escritorio
{
    partial class formComision
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
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.dgvComisiones = new System.Windows.Forms.DataGridView();
            this.idcomisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desccomisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioespecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comisionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tPI2023M07DataSet5 = new UI.Escritorio.TPI2023M07DataSet5();
            this.comisionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comisionesTableAdapter1 = new UI.Escritorio.TPI2023M07DataSet5TableAdapters.ComisionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comisionesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPI2023M07DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comisionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(315, 267);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(202, 267);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(81, 267);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 2;
            this.btnBaja.Text = "ELIMINAR";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // dgvComisiones
            // 
            this.dgvComisiones.AllowUserToAddRows = false;
            this.dgvComisiones.AutoGenerateColumns = false;
            this.dgvComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcomisionDataGridViewTextBoxColumn,
            this.desccomisionDataGridViewTextBoxColumn,
            this.anioespecialidadDataGridViewTextBoxColumn,
            this.id_plan});
            this.dgvComisiones.DataSource = this.comisionesBindingSource1;
            this.dgvComisiones.Location = new System.Drawing.Point(25, 12);
            this.dgvComisiones.Name = "dgvComisiones";
            this.dgvComisiones.Size = new System.Drawing.Size(444, 249);
            this.dgvComisiones.TabIndex = 3;
            this.dgvComisiones.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvComisiones_CellMouseClick);
            // 
            // idcomisionDataGridViewTextBoxColumn
            // 
            this.idcomisionDataGridViewTextBoxColumn.DataPropertyName = "id_comision";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idcomisionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idcomisionDataGridViewTextBoxColumn.HeaderText = "ID Comision";
            this.idcomisionDataGridViewTextBoxColumn.Name = "idcomisionDataGridViewTextBoxColumn";
            this.idcomisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // desccomisionDataGridViewTextBoxColumn
            // 
            this.desccomisionDataGridViewTextBoxColumn.DataPropertyName = "desc_comision";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.desccomisionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.desccomisionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.desccomisionDataGridViewTextBoxColumn.Name = "desccomisionDataGridViewTextBoxColumn";
            // 
            // anioespecialidadDataGridViewTextBoxColumn
            // 
            this.anioespecialidadDataGridViewTextBoxColumn.DataPropertyName = "anio_especialidad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.anioespecialidadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.anioespecialidadDataGridViewTextBoxColumn.HeaderText = "Año";
            this.anioespecialidadDataGridViewTextBoxColumn.Name = "anioespecialidadDataGridViewTextBoxColumn";
            // 
            // id_plan
            // 
            this.id_plan.DataPropertyName = "id_plan";
            this.id_plan.HeaderText = "Plan";
            this.id_plan.Name = "id_plan";
            this.id_plan.Visible = false;
            // 
            // comisionesBindingSource1
            // 
            this.comisionesBindingSource1.DataMember = "Comisiones";
            this.comisionesBindingSource1.DataSource = this.tPI2023M07DataSet5;
            // 
            // tPI2023M07DataSet5
            // 
            this.tPI2023M07DataSet5.DataSetName = "TPI2023M07DataSet5";
            this.tPI2023M07DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comisionesBindingSource
            // 
            this.comisionesBindingSource.DataMember = "Comisiones";
            // 
            // comisionesTableAdapter1
            // 
            this.comisionesTableAdapter1.ClearBeforeFill = true;
            // 
            // formComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 299);
            this.Controls.Add(this.dgvComisiones);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAlta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formComision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comisiones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comisionesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPI2023M07DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comisionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.DataGridView dgvComisiones;
       // private TPI2023M07DataSet4 tPI2023M07DataSet4;
        private System.Windows.Forms.BindingSource comisionesBindingSource;
       //private TPI2023M07DataSet4TableAdapters.ComisionesTableAdapter comisionesTableAdapter;
        private TPI2023M07DataSet5 tPI2023M07DataSet5;
        private System.Windows.Forms.BindingSource comisionesBindingSource1;
        private TPI2023M07DataSet5TableAdapters.ComisionesTableAdapter comisionesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desccomisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioespecialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_plan;
    }
}