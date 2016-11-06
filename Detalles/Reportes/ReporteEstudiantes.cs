using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detalles.Reportes
{
    public partial class ReporteEstudiantes : Form
    {
        public int EstudianteId { get; set; }
        public ReporteEstudiantes()
        {
            InitializeComponent();
        }

        private void ReporteEstudiantes_Load(object sender, EventArgs e)
        {

            try
            {
                var Ge = BLL.GruposEstudiantesBLL.BuscarGrupos(EstudianteId);
                var lista = BLL.GruposBLL.Buscar(Ge);
                this.EstudiantesBindingSource.Add(BLL.EstudiantesBLL.Buscar(EstudianteId));
                foreach (var grupo in lista)
                {
                    this.GruposBindingSource.Add(grupo);
                }

                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
