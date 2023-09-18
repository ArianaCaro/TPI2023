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
            this.dgvInscripciones = new System.Windows.Forms.DataGridView();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtApellidoBusca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInscripciones
            // 
            this.dgvInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripciones.Location = new System.Drawing.Point(60, 88);
            this.dgvInscripciones.Name = "dgvInscripciones";
            this.dgvInscripciones.Size = new System.Drawing.Size(558, 239);
            this.dgvInscripciones.TabIndex = 0;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(449, 383);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(319, 382);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 23);
            this.btnModifica.TabIndex = 2;
            this.btnModifica.Text = "MODIFICAR";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(168, 382);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "BAJA";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(215, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(656, 42);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtApellidoBusca
            // 
            this.txtApellidoBusca.Location = new System.Drawing.Point(90, 42);
            this.txtApellidoBusca.Name = "txtApellidoBusca";
            this.txtApellidoBusca.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoBusca.TabIndex = 6;
            // 
            // formInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtApellidoBusca);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.dgvInscripciones);
            this.Name = "formInscripcion";
            this.Text = "Inscripciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).EndInit();
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
        private System.Windows.Forms.TextBox txtApellidoBusca;
    }
}