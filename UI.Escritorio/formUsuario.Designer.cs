namespace UI.Escritorio
{
    partial class formUsuario
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPI2023M07DataSet6 = new UI.Escritorio.TPI2023M07DataSet6();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.usuariosTableAdapter = new UI.Escritorio.TPI2023M07DataSet6TableAdapters.UsuariosTableAdapter();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtApellidoBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPI2023M07DataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuarioDataGridViewTextBoxColumn,
            this.nombreusuarioDataGridViewTextBoxColumn,
            this.claveDataGridViewTextBoxColumn,
            this.idpersonaDataGridViewTextBoxColumn});
            this.dgvUsuarios.DataSource = this.usuariosBindingSource;
            this.dgvUsuarios.Location = new System.Drawing.Point(22, 77);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(671, 261);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.tPI2023M07DataSet6;
            // 
            // tPI2023M07DataSet6
            // 
            this.tPI2023M07DataSet6.DataSetName = "TPI2023M07DataSet6";
            this.tPI2023M07DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(470, 370);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(316, 370);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 23);
            this.btnModifica.TabIndex = 2;
            this.btnModifica.Text = "MODIFICAR";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(158, 370);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "BAJA";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(333, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "ID Usuario";
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreusuarioDataGridViewTextBoxColumn
            // 
            this.nombreusuarioDataGridViewTextBoxColumn.DataPropertyName = "nombre_usuario";
            this.nombreusuarioDataGridViewTextBoxColumn.HeaderText = "NombreUsuario";
            this.nombreusuarioDataGridViewTextBoxColumn.Name = "nombreusuarioDataGridViewTextBoxColumn";
            // 
            // claveDataGridViewTextBoxColumn
            // 
            this.claveDataGridViewTextBoxColumn.DataPropertyName = "clave";
            this.claveDataGridViewTextBoxColumn.HeaderText = "Clave";
            this.claveDataGridViewTextBoxColumn.Name = "claveDataGridViewTextBoxColumn";
            // 
            // idpersonaDataGridViewTextBoxColumn
            // 
            this.idpersonaDataGridViewTextBoxColumn.DataPropertyName = "id_persona";
            this.idpersonaDataGridViewTextBoxColumn.HeaderText = "id_persona";
            this.idpersonaDataGridViewTextBoxColumn.Name = "idpersonaDataGridViewTextBoxColumn";
            // 
            // txtApellidoBusca
            // 
            this.txtApellidoBusca.Location = new System.Drawing.Point(112, 39);
            this.txtApellidoBusca.Name = "txtApellidoBusca";
            this.txtApellidoBusca.Size = new System.Drawing.Size(205, 20);
            this.txtApellidoBusca.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Apellido:";
            // 
            // formUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellidoBusca);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.dgvUsuarios);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPI2023M07DataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnBuscar;
        private TPI2023M07DataSet6 tPI2023M07DataSet6;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private TPI2023M07DataSet6TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtApellidoBusca;
        private System.Windows.Forms.Label label1;
    }
}