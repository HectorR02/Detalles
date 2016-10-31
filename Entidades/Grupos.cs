using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupos
    {
        [Key]
        public int GrupoId { get; set; }

        public string Nombre { get; set; }

        public virtual List<Estudiantes> Estudiantes { get; set; }

        public Grupos()
        {
            
            this.Estudiantes = new List<Estudiantes>();
        }

        public Grupos(int grupoId, string nombreGrupo)
        {
            this.GrupoId = grupoId;
            this.Nombre = nombreGrupo;
            this.Estudiantes = new List<Entidades.Estudiantes>();
        }
    }
}
