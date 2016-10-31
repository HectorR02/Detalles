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
    public partial class Form1 : Form
    {
        private Grupos grupo = new Grupos();

        public Form1()
        {
            InitializeComponent();
            EstudiantesComboBox.DataSource = BLL.EstudiantesBLL.GetList();
            EstudiantesComboBox.ValueMember = "EstudianteId";
            EstudiantesComboBox.DisplayMember = "Nombres";
        }

        private void textBoxNombreGrupoC_TextChanged(object sender, EventArgs e)
        {

        }

        private void InsertarEstudianteButton_Click(object sender, EventArgs e)
        {
            BLL.EstudiantesBLL.Insertar(new Entidades.Estudiantes() {
                EstudianteId = 1,
                Nombres = "Juancho"
            });
            BLL.EstudiantesBLL.Insertar(new Entidades.Estudiantes()
            {
                EstudianteId = 1,
                Nombres = "Pedro"
            });
            BLL.EstudiantesBLL.Insertar(new Entidades.Estudiantes()
            {
                EstudianteId = 1,
                Nombres = "Ada luz"
            });
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            var estudiante = new Estudiantes((int)EstudiantesComboBox.SelectedValue, EstudiantesComboBox.Text);
            grupo.Estudiantes.Add(estudiante);
            EstudiantesDataGridView.DataSource = null;
            EstudiantesDataGridView.DataSource = grupo.Estudiantes;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            grupo.GrupoId = Convert.ToInt32(GrupoIdtextBox.Text);
            grupo.Nombre = textBoxNombreGrupoC.Text;

            BLL.GruposBLL.Insertar(grupo);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var grupo = BLL.GruposBLL.Buscar(Convert.ToInt32(GrupoIdtextBox.Text));
            if(grupo != null)
            {
                textBoxNombreGrupoC.Text = grupo.Nombre;
                //EstudiantesDataGridView.DataSource = grupo.Estudiantes;
                cargarEstudiantesGrupo(grupo.Estudiantes);

                EstudiantesDataGridView.DataSource = null;
                EstudiantesDataGridView.DataSource = grupo.Estudiantes;
            }
        }

        // private void cargarEstudiantesGrupo(List<GruposEstudiantes> lista)
        private void cargarEstudiantesGrupo(List<Estudiantes> lista)
        {
            var estudiantes = new List<Estudiantes>();
            foreach(Estudiantes est in lista)
            {
                estudiantes.Add(BLL.EstudiantesBLL.Buscar(est.EstudianteId));
            }
            EstudiantesDataGridView.DataSource = null;
            EstudiantesDataGridView.DataSource = estudiantes;
        }
    }
}
