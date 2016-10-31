using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL1
{
    public class DetallesDB : DbContext
    {
        public DetallesDB() : base("name=Detalles")
        {

        }

        public DbSet<Estudiantes> Estudiante{ get; set; }

        public DbSet<Grupos> Grupo { get; set; }

        public DbSet<GruposEstudiantes> GrpEst { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grupos>()
                .HasMany<Estudiantes>(g => g.Estudiantes)
                .WithMany(e => e.Grupos)
                .Map(Ge =>
                {
                    Ge.MapLeftKey("GrupoId");
                    Ge.MapRightKey("EstudianteId");
                    Ge.ToTable("GruposEstudiantes");
                });
        }
    }
}
