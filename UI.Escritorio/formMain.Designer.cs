namespace UI.Escritorio
{
    partial class formMain
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
            this.msnPrincipal = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.docentesMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.comisionesMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadesMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.planesMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.notasMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.msnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msnPrincipal
            // 
            this.msnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.msnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msnPrincipal.Name = "msnPrincipal";
            this.msnPrincipal.Size = new System.Drawing.Size(800, 24);
            this.msnPrincipal.TabIndex = 1;
            this.msnPrincipal.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosMnu,
            this.alumnosMnu,
            this.docentesMnu,
            this.comisionesMnu,
            this.cursosMnu,
            this.materiasMnu,
            this.especialidadesMnu,
            this.planesMnu,
            this.inscripcionesMnu,
            this.notasMnu});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // usuariosMnu
            // 
            this.usuariosMnu.Name = "usuariosMnu";
            this.usuariosMnu.Size = new System.Drawing.Size(180, 22);
            this.usuariosMnu.Text = "Usuarios";
            this.usuariosMnu.Click += new System.EventHandler(this.usuariosMnu_Click);
            // 
            // alumnosMnu
            // 
            this.alumnosMnu.Name = "alumnosMnu";
            this.alumnosMnu.Size = new System.Drawing.Size(180, 22);
            this.alumnosMnu.Text = "Alumnos";
            this.alumnosMnu.Click += new System.EventHandler(this.alumnosMnu_Click);
            // 
            // docentesMnu
            // 
            this.docentesMnu.Name = "docentesMnu";
            this.docentesMnu.Size = new System.Drawing.Size(180, 22);
            this.docentesMnu.Text = "Docentes";
            this.docentesMnu.Click += new System.EventHandler(this.docentesMnu_Click);
            // 
            // comisionesMnu
            // 
            this.comisionesMnu.Name = "comisionesMnu";
            this.comisionesMnu.Size = new System.Drawing.Size(180, 22);
            this.comisionesMnu.Text = "Comisiones";
            this.comisionesMnu.Click += new System.EventHandler(this.comisionesMnu_Click);
            // 
            // cursosMnu
            // 
            this.cursosMnu.Name = "cursosMnu";
            this.cursosMnu.Size = new System.Drawing.Size(180, 22);
            this.cursosMnu.Text = "Cursos";
            this.cursosMnu.Click += new System.EventHandler(this.cursosMnu_Click);
            // 
            // materiasMnu
            // 
            this.materiasMnu.Name = "materiasMnu";
            this.materiasMnu.Size = new System.Drawing.Size(180, 22);
            this.materiasMnu.Text = "Materias";
            this.materiasMnu.Click += new System.EventHandler(this.materiasMnu_Click);
            // 
            // especialidadesMnu
            // 
            this.especialidadesMnu.Name = "especialidadesMnu";
            this.especialidadesMnu.Size = new System.Drawing.Size(180, 22);
            this.especialidadesMnu.Text = "Especialidades";
            this.especialidadesMnu.Click += new System.EventHandler(this.especialidadesMnu_Click);
            // 
            // planesMnu
            // 
            this.planesMnu.Name = "planesMnu";
            this.planesMnu.Size = new System.Drawing.Size(180, 22);
            this.planesMnu.Text = "Planes";
            this.planesMnu.Click += new System.EventHandler(this.planesMnu_Click);
            // 
            // inscripcionesMnu
            // 
            this.inscripcionesMnu.Name = "inscripcionesMnu";
            this.inscripcionesMnu.Size = new System.Drawing.Size(180, 22);
            this.inscripcionesMnu.Text = "Inscripciones";
            this.inscripcionesMnu.Click += new System.EventHandler(this.inscripcionesToolStripMenuItem_Click);
            // 
            // notasMnu
            // 
            this.notasMnu.Name = "notasMnu";
            this.notasMnu.Size = new System.Drawing.Size(180, 22);
            this.notasMnu.Text = "Notas";
            this.notasMnu.Click += new System.EventHandler(this.notasToolStripMenuItem_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msnPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msnPrincipal;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia";
            this.Shown += new System.EventHandler(this.formMain_Shown);
            this.msnPrincipal.ResumeLayout(false);
            this.msnPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosMnu;
        private System.Windows.Forms.ToolStripMenuItem alumnosMnu;
        private System.Windows.Forms.ToolStripMenuItem docentesMnu;
        private System.Windows.Forms.ToolStripMenuItem comisionesMnu;
        private System.Windows.Forms.ToolStripMenuItem cursosMnu;
        private System.Windows.Forms.ToolStripMenuItem materiasMnu;
        private System.Windows.Forms.ToolStripMenuItem especialidadesMnu;
        private System.Windows.Forms.ToolStripMenuItem planesMnu;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesMnu;
        private System.Windows.Forms.ToolStripMenuItem notasMnu;
    }
}