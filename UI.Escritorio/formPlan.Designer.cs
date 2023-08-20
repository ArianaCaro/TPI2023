namespace UI.Escritorio
{
    partial class formPlan
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
            this.mnsPlan = new System.Windows.Forms.MenuStrip();
            this.aLTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODIFICAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bAJAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.planesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tPI2023M07DataSet2 = new UI.Escritorio.TPI2023M07DataSet2();
            this.planesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tPI2023M07DataSet1 = new UI.Escritorio.TPI2023M07DataSet1();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPI2023M07DataSet = new UI.Escritorio.TPI2023M07DataSet();
            this.planesTableAdapter = new UI.Escritorio.TPI2023M07DataSetTableAdapters.PlanesTableAdapter();
            this.planesTableAdapter1 = new UI.Escritorio.TPI2023M07DataSet1TableAdapters.PlanesTableAdapter();
            this.planesTableAdapter2 = new UI.Escritorio.TPI2023M07DataSet2TableAdapters.PlanesTableAdapter();
            this.idplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEspecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnsPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPI2023M07DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPI2023M07DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPI2023M07DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsPlan
            // 
            this.mnsPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mnsPlan.Dock = System.Windows.Forms.DockStyle.None;
            this.mnsPlan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLTAToolStripMenuItem,
            this.mODIFICAToolStripMenuItem,
            this.bAJAToolStripMenuItem});
            this.mnsPlan.Location = new System.Drawing.Point(104, 18);
            this.mnsPlan.Name = "mnsPlan";
            this.mnsPlan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnsPlan.Size = new System.Drawing.Size(174, 24);
            this.mnsPlan.TabIndex = 0;
            this.mnsPlan.Text = "menuStrip1";
            // 
            // aLTAToolStripMenuItem
            // 
            this.aLTAToolStripMenuItem.Name = "aLTAToolStripMenuItem";
            this.aLTAToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aLTAToolStripMenuItem.Text = "ALTA";
            this.aLTAToolStripMenuItem.Click += new System.EventHandler(this.aLTAToolStripMenuItem_Click);
            // 
            // mODIFICAToolStripMenuItem
            // 
            this.mODIFICAToolStripMenuItem.Name = "mODIFICAToolStripMenuItem";
            this.mODIFICAToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.mODIFICAToolStripMenuItem.Text = "MODIFICA";
            this.mODIFICAToolStripMenuItem.Click += new System.EventHandler(this.mODIFICAToolStripMenuItem_Click);
            // 
            // bAJAToolStripMenuItem
            // 
            this.bAJAToolStripMenuItem.Name = "bAJAToolStripMenuItem";
            this.bAJAToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.bAJAToolStripMenuItem.Text = "BAJA";
            this.bAJAToolStripMenuItem.Click += new System.EventHandler(this.bAJAToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idplanDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.idEspecialidadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.planesBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(22, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 289);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // planesBindingSource2
            // 
            this.planesBindingSource2.DataMember = "Planes";
            this.planesBindingSource2.DataSource = this.tPI2023M07DataSet2;
            // 
            // tPI2023M07DataSet2
            // 
            this.tPI2023M07DataSet2.DataSetName = "TPI2023M07DataSet2";
            this.tPI2023M07DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planesBindingSource1
            // 
            this.planesBindingSource1.DataMember = "Planes";
            this.planesBindingSource1.DataSource = this.tPI2023M07DataSet1;
            // 
            // tPI2023M07DataSet1
            // 
            this.tPI2023M07DataSet1.DataSetName = "TPI2023M07DataSet1";
            this.tPI2023M07DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "Planes";
            this.planesBindingSource.DataSource = this.tPI2023M07DataSet;
            // 
            // tPI2023M07DataSet
            // 
            this.tPI2023M07DataSet.DataSetName = "TPI2023M07DataSet";
            this.tPI2023M07DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planesTableAdapter
            // 
            this.planesTableAdapter.ClearBeforeFill = true;
            // 
            // planesTableAdapter1
            // 
            this.planesTableAdapter1.ClearBeforeFill = true;
            // 
            // planesTableAdapter2
            // 
            this.planesTableAdapter2.ClearBeforeFill = true;
            // 
            // idplanDataGridViewTextBoxColumn
            // 
            this.idplanDataGridViewTextBoxColumn.DataPropertyName = "id_plan";
            this.idplanDataGridViewTextBoxColumn.HeaderText = "ID Plan";
            this.idplanDataGridViewTextBoxColumn.Name = "idplanDataGridViewTextBoxColumn";
            this.idplanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // idEspecialidadDataGridViewTextBoxColumn
            // 
            this.idEspecialidadDataGridViewTextBoxColumn.DataPropertyName = "id_Especialidad";
            this.idEspecialidadDataGridViewTextBoxColumn.HeaderText = "Especialidad";
            this.idEspecialidadDataGridViewTextBoxColumn.Name = "idEspecialidadDataGridViewTextBoxColumn";
            this.idEspecialidadDataGridViewTextBoxColumn.Visible = false;
            // 
            // formPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(393, 373);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mnsPlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnsPlan;
            this.Name = "formPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planes";
            this.Load += new System.EventHandler(this.formPlan_Load);
            this.mnsPlan.ResumeLayout(false);
            this.mnsPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPI2023M07DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPI2023M07DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPI2023M07DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPlan;
        private System.Windows.Forms.ToolStripMenuItem aLTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODIFICAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bAJAToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TPI2023M07DataSet tPI2023M07DataSet;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private TPI2023M07DataSetTableAdapters.PlanesTableAdapter planesTableAdapter;
        private TPI2023M07DataSet1 tPI2023M07DataSet1;
        private System.Windows.Forms.BindingSource planesBindingSource1;
        private TPI2023M07DataSet1TableAdapters.PlanesTableAdapter planesTableAdapter1;
        private TPI2023M07DataSet2 tPI2023M07DataSet2;
        private System.Windows.Forms.BindingSource planesBindingSource2;
        private TPI2023M07DataSet2TableAdapters.PlanesTableAdapter planesTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEspecialidadDataGridViewTextBoxColumn;
    }
}