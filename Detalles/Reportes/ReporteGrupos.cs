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
    public partial class ReporteGrupos : Form
    {
        public int IdGrupo { get; set; }
        public ReporteGrupos()
        {
            InitializeComponent();
        }

        private void ReporteGrupos_Load(object sender, EventArgs e)
        {
            var gE = BLL.GruposEstudiantesBLL.Buscar(IdGrupo);
            var lista = BLL.EstudiantesBLL.Buscar(gE);
            foreach (var est in lista)
                this.EstudiantesBindingSource.Add(est);

            this.GruposBindingSource.Add(BLL.GruposBLL.Buscar(IdGrupo));
            this.reportViewer1.RefreshReport();
        }
    }
}
