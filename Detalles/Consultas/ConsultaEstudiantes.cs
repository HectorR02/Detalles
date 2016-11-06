using System;
using System.Windows.Forms;

namespace Detalles
{
    public partial class ConsultaEstudiantes : Form
    {
        private Inicio Padre;

        public ConsultaEstudiantes()
        {
            InitializeComponent();
            CleanCampos();
        }

        public ConsultaEstudiantes(Inicio Padre)
        {
            this.Padre = Padre;
            this.MdiParent = Padre;
        }

        private void CleanCampos()
        {
            IdTextBox.Clear();
            NombresTextBox.Clear();
            GruposDataGridView.DataSource = null;
            GruposGroupBox.Visible = false;
            IdTextBox.Text = (BLL.EstudiantesBLL.UltimoId()+1).ToString();
            IdTextBox.Focus();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            CleanCampos();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            NombresTextBox.Clear();
            GruposDataGridView.DataSource = null;
            GruposGroupBox.Visible = false;
            int Id;
            int.TryParse(IdTextBox.Text, out Id);
            var estudiante = BLL.EstudiantesBLL.Buscar(Id);
            if (estudiante != null)
            {
                var gE = BLL.GruposEstudiantesBLL.BuscarGrupos(estudiante.EstudianteId);
                var g = BLL.GruposBLL.Buscar(gE);
                NombresTextBox.Text = estudiante.Nombres;
                GruposGroupBox.Visible = true;
                GruposDataGridView.DataSource = g;
            }
            else
            {
                MessageBox.Show("El estudiante con Id = " + Id + " No Existe", "Error de Consulta", MessageBoxButtons.OK);
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(IdTextBox.Text) && !string.IsNullOrEmpty(NombresTextBox.Text)))
            {
                int id;
                int.TryParse(IdTextBox.Text, out id);
                var lista = BLL.EstudiantesBLL.GetList();
                if (BLL.EstudiantesBLL.Buscar(id) == null || lista.Count == 0)
                    BLL.EstudiantesBLL.Insertar(new Entidades.Estudiantes() { EstudianteId = id, Nombres = NombresTextBox.Text });
                else
                    BLL.EstudiantesBLL.Modificar(new Entidades.Estudiantes() { EstudianteId = id, Nombres = NombresTextBox.Text });
                CleanCampos();
            }
            else
            {
                MessageBox.Show("No puedes dejar campos vacíos", "-- AVISO --", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(IdTextBox.Text))
                {
                    IdTextBox.Text = (BLL.EstudiantesBLL.UltimoId() + 1).ToString();
                    IdTextBox.Focus();
                }
                else
                    NombresTextBox.Focus();
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            string mensaje = "No se pudo eliminar el registro";
            string Titulo = "-- Transaccion Fallida --";
            int Id;
            int.TryParse(IdTextBox.Text, out Id);
            if (BLL.EstudiantesBLL.Eliminar(BLL.EstudiantesBLL.Buscar(Id)))
            {
                BLL.GruposEstudiantesBLL.EliminarEstudiante(Id);
                mensaje = "Se Eliminó correctamente";
                Titulo = "-- Transaccion Exitosa --";
            }

            MessageBox.Show(mensaje, Titulo, MessageBoxButtons.OK);
            CleanCampos();
        }
    }
}
