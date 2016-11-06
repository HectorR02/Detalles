namespace Detalles.Reportes
{
    partial class ReporteGrupos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EstudiantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GruposBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CargarEstudiantes";
            reportDataSource1.Value = this.EstudiantesBindingSource;
            reportDataSource2.Name = "CargarGrupo";
            reportDataSource2.Value = this.GruposBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Detalles.Reportes.RepGrupos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(664, 496);
            this.reportViewer1.TabIndex = 0;
            // 
            // EstudiantesBindingSource
            // 
            this.EstudiantesBindingSource.DataSource = typeof(Entidades.Estudiantes);
            // 
            // GruposBindingSource
            // 
            this.GruposBindingSource.DataSource = typeof(Entidades.Grupos);
            // 
            // ReporteGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 496);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteGrupos";
            this.Text = "ReporteGrupos";
            this.Load += new System.EventHandler(this.ReporteGrupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GruposBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EstudiantesBindingSource;
        private System.Windows.Forms.BindingSource GruposBindingSource;
    }
}