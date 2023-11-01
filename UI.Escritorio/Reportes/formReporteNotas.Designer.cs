namespace UI.Escritorio.Reportes
{
    partial class formReporteNotas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_reportes = new UI.Escritorio.Reportes.DS_reportes();
            this.dataTable1TableAdapter = new UI.Escritorio.Reportes.DS_reportesTableAdapters.DataTable1TableAdapter();
            this.txtIdCurso_Reporte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_reporte_notas";
            reportDataSource1.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Escritorio.Reportes.RPT_notas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dS_reportes;
            // 
            // dS_reportes
            // 
            this.dS_reportes.DataSetName = "DS_reportes";
            this.dS_reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // txtIdCurso_Reporte
            // 
            this.txtIdCurso_Reporte.Location = new System.Drawing.Point(133, 91);
            this.txtIdCurso_Reporte.Name = "txtIdCurso_Reporte";
            this.txtIdCurso_Reporte.Size = new System.Drawing.Size(100, 22);
            this.txtIdCurso_Reporte.TabIndex = 1;
            this.txtIdCurso_Reporte.Visible = false;
            // 
            // formReporteNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdCurso_Reporte);
            this.Controls.Add(this.reportViewer1);
            this.Name = "formReporteNotas";
            this.Text = "formReporteNotas";
            this.Load += new System.EventHandler(this.formReporteNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_reportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_reportes dS_reportes;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DS_reportesTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        public System.Windows.Forms.TextBox txtIdCurso_Reporte;
    }
}