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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            
        }

        private void LimpiarContenedor()
        {
            var frm = this.ActiveMdiChild;
            if (frm != null)
                frm.Close();
        }

        private void estudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LimpiarContenedor();
            var RegEst = new RegistroEstudiantes();
            RegEst.MdiParent = this;
            RegEst.Show();
        }

        private void gruposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form RegGrupos;
            if (BLL.EstudiantesBLL.GetList() != null)
            {
                LimpiarContenedor();
                RegGrupos = new Registros.RegistroGrupos();
            }
            else
            {
                LimpiarContenedor();
                MessageBox.Show("Aun no se ha registrado ningun estudiante antes de crear"+
                    " un grupo debe haber algun estudiante en la base de dato", "-- Aviso --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RegGrupos = new ConsultaEstudiantes();
            }
            RegGrupos.MdiParent = this;
            RegGrupos.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Registro = new Form();
            if (BLL.EstudiantesBLL.GetList().Count() > 0)
                Registro = new ConsultaEstudiantes();
            else
            {
                MessageBox.Show("No hay estudiantes registrados\nRegistre alguno antes de continuar", "-- AVISO --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Registro = new RegistroEstudiantes();
            }
            Registro.MdiParent = this;
            Registro.Show();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventana = new Form();

            if(BLL.GruposBLL.GetList().Count() > 0)
                ventana = new ConsultaGrupos();
            else
            {
                var Mensaje = "No hay grupos registrados registre\nalgun grupo para continuar";

                var est = BLL.EstudiantesBLL.GetList().Count();

                if (est == 0)
                {
                    Mensaje = "No hay estudiantes registrados y por tal motivo tampoco hay\nestudiantes registrados registre alguno para continuar";
                    ventana = new RegistroEstudiantes();
                }
                else
                    ventana = new Registros.RegistroGrupos();
                    
                MessageBox.Show(Mensaje, "-- AVISO --", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }

            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
