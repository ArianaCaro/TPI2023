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
            this.dvgCursos = new System.Windows.Forms.DataGridView();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgCursos
            // 
            this.dvgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCursos.Location = new System.Drawing.Point(152, 83);
            this.dvgCursos.Name = "dvgCursos";
            this.dvgCursos.Size = new System.Drawing.Size(240, 150);
            this.dvgCursos.TabIndex = 0;
            this.dvgCursos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgCursos_CellMouseClick);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(350, 317);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(205, 316);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(89, 317);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "ELIMINAR";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // formCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.dvgCursos);
            this.Name = "formCurso";
            this.Text = "Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCursos;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
    }
}