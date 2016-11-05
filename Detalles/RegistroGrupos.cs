using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detalles
{
    public partial class RegistroGrupos : Form
    {
        private List<Estudiantes> estudiantes;
        public List<GruposEstudiantes> GrupoEstudiante;

        public RegistroGrupos()
        {
            InitializeComponent();
            estudiantes = new List<Estudiantes>();
            GrupoEstudiante = new List<GruposEstudiantes>();
            EstudiatesComboBox.DataSource = BLL.EstudiantesBLL.GetList();
            EstudiatesComboBox.ValueMember = "EstudianteId";
            EstudiatesComboBox.DisplayMember = "Nombres";
            CleanCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdGrupo;
            int.TryParse(IdTextBox.Text, out IdGrupo);
            var existente = BLL.GruposBLL.Buscar(IdGrupo);
            if(existente != null)
            {
                string Mensaje = "No se ha podido eliminar el grupo especificado";
                string Titulo = "-- Transacción Fallida --";
                if (BLL.GruposBLL.Eliminar(existente))
                {
                    Mensaje = "Grupo eliminado exitosamente";
                    Titulo = "-- Transacción Exitosa --";
                }
                MessageBox.Show(Mensaje, Titulo, MessageBoxButtons.OK);
                CleanCampos();
            }
            else
                MessageBox.Show("El grupo con el Id "+IdGrupo+" No existe..", "-- Consulta Fallida --", MessageBoxButtons.OK);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int IdGrupo;
            int.TryParse(IdTextBox.Text, out IdGrupo);
            var g = BLL.GruposBLL.Buscar(IdGrupo);            
            if(g != null)
            {
                var gE = BLL.GruposEstudiantesBLL.Buscar(IdGrupo);
                estudiantes = BLL.EstudiantesBLL.Buscar(gE);
                NombresTextBox.Text = g.Nombre;
                EstudiantesDataGridView.DataSource = null;
                EstudiantesDataGridView.DataSource = estudiantes;
            }
            else
            {
                MessageBox.Show("Este grupo con el Id " + IdGrupo + " No existe...", "-- Error de Consulta", MessageBoxButtons.OK);
            }
            IdTextBox.Focus();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdTextBox.Text))
                if (!string.IsNullOrEmpty(NombresTextBox.Text))
                {
                    int IdGrupo;
                    int.TryParse(IdTextBox.Text, out IdGrupo);
                    estudiantes.Add(BLL.EstudiantesBLL.Buscar((int)EstudiatesComboBox.SelectedValue));
                    GrupoEstudiante.Add(new GruposEstudiantes() {
                        Id = 1,
                        EstudianteId = (int)EstudiatesComboBox.SelectedValue,
                        GrupoId = IdGrupo
                    });
                    EstudiantesDataGridView.DataSource = null;
                    EstudiantesDataGridView.DataSource = estudiantes;
                }
            
        }

        private void CleanCampos()
        {
            IdTextBox.Clear();
            NombresTextBox.Clear();
            estudiantes = new List<Estudiantes>();
            EstudiantesDataGridView.DataSource = null;
            IdTextBox.Text = (BLL.GruposBLL.UltimoId() + 1).ToString();
            IdTextBox.Focus();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            CleanCampos();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            int IdGrupo;
            int.TryParse(IdTextBox.Text, out IdGrupo);
            string Mensaje = "No se ha podido registrar el grupo";
            string Titulo = "-- Transacción Fallida --";
            if(BLL.GruposBLL.Buscar(IdGrupo) != null)
            {
                if ((BLL.GruposBLL.Insertar(new Grupos() { GrupoId = IdGrupo, Nombre = NombresTextBox.Text }) && BLL.GruposEstudiantesBLL.Insertar(GrupoEstudiante)))
                {
                    Mensaje = "Ha registrado un grupo Exitosamente";
                    Titulo = "-- Transacción Exitosa --";
                    GrupoEstudiante = new List<GruposEstudiantes>();
                }
            }
            else
                BLL.GruposBLL.Modificar(new Grupos() { GrupoId = IdGrupo, Nombre = NombresTextBox.Text });
            MessageBox.Show(Mensaje, Titulo, MessageBoxButtons.OK);
            CleanCampos();
        }
    }

}
