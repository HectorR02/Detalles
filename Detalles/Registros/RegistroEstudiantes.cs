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
    public partial class RegistroEstudiantes : Form
    {
        public RegistroEstudiantes()
        {
            InitializeComponent();
            CleanCampos();
        }

        private void RegistroEstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void CleanCampos()
        {
            IdtextBox.Clear();
            NombrestextBox.Clear();
            IdtextBox.Text = (BLL.EstudiantesBLL.UltimoId() + 1).ToString();
            IdtextBox.Focus();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(IdtextBox.Text) && !string.IsNullOrEmpty(NombrestextBox.Text)))
            {
                int id;
                int.TryParse(IdtextBox.Text, out id);
                var lista = BLL.EstudiantesBLL.GetList();
                if (BLL.EstudiantesBLL.Buscar(id) == null || lista.Count == 0)
                    BLL.EstudiantesBLL.Insertar(new Entidades.Estudiantes() { EstudianteId = id, Nombres = NombrestextBox.Text });
                else
                    BLL.EstudiantesBLL.Modificar(new Entidades.Estudiantes() { EstudianteId = id, Nombres = NombrestextBox.Text });
                CleanCampos();
            }
            else
            {
                MessageBox.Show("No puedes dejar campos vacíos", "-- AVISO --", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(IdtextBox.Text))
                {
                    IdtextBox.Text = (BLL.EstudiantesBLL.UltimoId() + 1).ToString();
                    IdtextBox.Focus();
                }
                else
                    NombrestextBox.Focus();
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            CleanCampos();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            string mensaje = "No se pudo eliminar el registro";
            string Titulo = "-- Transaccion Fallida --";
            int Id;
            int.TryParse(IdtextBox.Text, out Id);

            if (BLL.EstudiantesBLL.Eliminar(BLL.EstudiantesBLL.Buscar(Id)))
            {
                BLL.GruposEstudiantesBLL.EliminarEstudiante(Id);
                mensaje = "Se Eliminó correctamente";
                Titulo = "-- Transaccion Exitosa --";
            }

            MessageBox.Show(mensaje, Titulo, MessageBoxButtons.OK);
            CleanCampos();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            NombrestextBox.Clear();
            int Id;
            int.TryParse(IdtextBox.Text, out Id);

            var estudiante = BLL.EstudiantesBLL.Buscar(Id);

            if (estudiante != null)
                NombrestextBox.Text = estudiante.Nombres;
            else
            {
                MessageBox.Show("El estudiante con Id = " + Id + " No Existe", "Error de Consulta", MessageBoxButtons.OK);
            }
        }
    }
}
