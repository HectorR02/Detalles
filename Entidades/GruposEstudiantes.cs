using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GruposEstudiantes
    {
        [Key]
        public int Id { get; set; }

        public int GrupoId { get; set; }

        public int EstudianteId { get; set; }

    }
}
