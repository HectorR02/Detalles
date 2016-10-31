namespace Detalles
{
    partial class Form1
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
            this.BuscarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.EstudiantesDataGridView = new System.Windows.Forms.DataGridView();
            this.EstudiantesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrupoIdtextBox = new System.Windows.Forms.TextBox();
            this.textBoxNombreGrupoC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Estudiante = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InsertarEstudianteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(194, 15);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 0;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(12, 333);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 1;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(388, 23);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 2;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // EstudiantesDataGridView
            // 
            this.EstudiantesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EstudiantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiantesDataGridView.Location = new System.Drawing.Point(17, 50);
            this.EstudiantesDataGridView.Name = "EstudiantesDataGridView";
            this.EstudiantesDataGridView.Size = new System.Drawing.Size(466, 150);
            this.EstudiantesDataGridView.TabIndex = 3;
            // 
            // EstudiantesComboBox
            // 
            this.EstudiantesComboBox.FormattingEnabled = true;
            this.EstudiantesComboBox.Location = new System.Drawing.Point(79, 23);
            this.EstudiantesComboBox.Name = "EstudiantesComboBox";
            this.EstudiantesComboBox.Size = new System.Drawing.Size(235, 21);
            this.EstudiantesComboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grupo Id";
            // 
            // GrupoIdtextBox
            // 
            this.GrupoIdtextBox.Location = new System.Drawing.Point(80, 15);
            this.GrupoIdtextBox.Name = "GrupoIdtextBox";
            this.GrupoIdtextBox.Size = new System.Drawing.Size(100, 20);
            this.GrupoIdtextBox.TabIndex = 6;
            // 
            // textBoxNombreGrupoC
            // 
            this.textBoxNombreGrupoC.Location = new System.Drawing.Point(108, 62);
            this.textBoxNombreGrupoC.Name = "textBoxNombreGrupoC";
            this.textBoxNombreGrupoC.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreGrupoC.TabIndex = 8;
            this.textBoxNombreGrupoC.TextChanged += new System.EventHandler(this.textBoxNombreGrupoC_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre Grupo";
            // 
            // Estudiante
            // 
            this.Estudiante.AutoSize = true;
            this.Estudiante.Location = new System.Drawing.Point(14, 26);
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.Size = new System.Drawing.Size(35, 13);
            this.Estudiante.TabIndex = 9;
            this.Estudiante.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Estudiante);
            this.groupBox1.Controls.Add(this.EstudiantesComboBox);
            this.groupBox1.Controls.Add(this.EstudiantesDataGridView);
            this.groupBox1.Controls.Add(this.AgregarButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 209);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // InsertarEstudianteButton
            // 
            this.InsertarEstudianteButton.Location = new System.Drawing.Point(114, 389);
            this.InsertarEstudianteButton.Name = "InsertarEstudianteButton";
            this.InsertarEstudianteButton.Size = new System.Drawing.Size(169, 23);
            this.InsertarEstudianteButton.TabIndex = 11;
            this.InsertarEstudianteButton.Text = "Insertar Estudiante";
            this.InsertarEstudianteButton.UseVisualStyleBackColor = true;
            this.InsertarEstudianteButton.Click += new System.EventHandler(this.InsertarEstudianteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 443);
            this.Controls.Add(this.InsertarEstudianteButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxNombreGrupoC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GrupoIdtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.BuscarButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.DataGridView EstudiantesDataGridView;
        private System.Windows.Forms.ComboBox EstudiantesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GrupoIdtextBox;
        private System.Windows.Forms.TextBox textBoxNombreGrupoC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Estudiante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button InsertarEstudianteButton;
    }
}

