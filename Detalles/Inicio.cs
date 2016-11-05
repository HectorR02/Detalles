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
            if (BLL.EstudiantesBLL.UltimoId() > 0)
            {
                LimpiarContenedor();
                RegGrupos = new RegistroGrupos();
            }
            else
            {
                LimpiarContenedor();
                MessageBox.Show("Aun no se ha registrado ningun estudiante antes de crear"+
                    " un grupo debe haber algun estudiante en la base de dato", "-- Aviso --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RegGrupos = new RegistroEstudiantes();
            }
            RegGrupos.MdiParent = this;
            RegGrupos.Show();
        }
    }
}
