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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tPI2023M07DataSet = new UI.Escritorio.TPI2023M07DataSet();
            this.planesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.planesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planesTableAdapter = new UI.Escritorio.TPI2023M07DataSetTableAdapters.PlanesTableAdapter();
            this.mnsPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPI2023M07DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.descplanDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.planesBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(22, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 289);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_plan";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Plan";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descplanDataGridViewTextBoxColumn
            // 
            this.descplanDataGridViewTextBoxColumn.DataPropertyName = "desc_plan";
            this.descplanDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descplanDataGridViewTextBoxColumn.Name = "descplanDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_especialidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_especialidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // planesBindingSource3
            // 
            this.planesBindingSource3.DataMember = "Planes";
            this.planesBindingSource3.DataSource = this.tPI2023M07DataSet;
            // 
            // tPI2023M07DataSet
            // 
            this.tPI2023M07DataSet.DataSetName = "TPI2023M07DataSet";
            this.tPI2023M07DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planesBindingSource2
            // 
            this.planesBindingSource2.DataMember = "Planes";
            // 
            // planesBindingSource1
            // 
            this.planesBindingSource1.DataMember = "Planes";
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "Planes";
            // 
            // planesTableAdapter
            // 
            this.planesTableAdapter.ClearBeforeFill = true;
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planes";
            this.Load += new System.EventHandler(this.formPlan_Load);
            this.mnsPlan.ResumeLayout(false);
            this.mnsPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPI2023M07DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPlan;
        private System.Windows.Forms.ToolStripMenuItem aLTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODIFICAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bAJAToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        //private TPI2023M07DataSet tPI2023M07DataSet;
        private System.Windows.Forms.BindingSource planesBindingSource;
        //private TPI2023M07DataSetTableAdapters.PlanesTableAdapter planesTableAdapter;
        //private TPI2023M07DataSet1 tPI2023M07DataSet1;
        private System.Windows.Forms.BindingSource planesBindingSource1;
       // private TPI2023M07DataSet1TableAdapters.PlanesTableAdapter planesTableAdapter1;
        //private TPI2023M07DataSet2 tPI2023M07DataSet2;
        private System.Windows.Forms.BindingSource planesBindingSource2;
        //private TPI2023M07DataSet2TableAdapters.PlanesTableAdapter planesTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEspecialidadDataGridViewTextBoxColumn;
        private TPI2023M07DataSet tPI2023M07DataSet;
        private System.Windows.Forms.BindingSource planesBindingSource3;
        private TPI2023M07DataSetTableAdapters.PlanesTableAdapter planesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}