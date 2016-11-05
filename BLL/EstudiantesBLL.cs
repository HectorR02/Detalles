using DAL1;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class EstudiantesBLL
    {
        public static bool Insertar(Estudiantes nuevo)
        {
            bool resultado = false;
            using (var conexion = new DetallesDB())
            {
                try
                {
                    conexion.Estudiante.Add(nuevo);
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.ToString());
                }
            }
            return resultado;
        }
        public static Estudiantes Buscar(int EstudianteId)
        {
            var est = new Estudiantes();
            //var conexion = new DetallesDB();
            using (var conexion = new DetallesDB())
            {
                try
                {
                    est = conexion.Estudiante.Find(EstudianteId);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());// throw;
                }
            }
            return est;
        }

        public static bool Eliminar(Estudiantes Existente)
        {
            bool resultado = false;
            using (var conexion = new DetallesDB())
            {
                try
                {
                    conexion.Entry(Existente).State = EntityState.Deleted;
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }

        public static List<Estudiantes> GetList()
        {
            var lista = new List<Estudiantes>();
            using (var conexion = new DetallesDB())
            {
                try
                {
                    lista = conexion.Estudiante.ToList();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.ToString());
                }
            }
            return lista;
        }

        public static List<Estudiantes> Buscar(List<GruposEstudiantes> gruposEstudiantes)
        {
            var est = new List<Estudiantes>();
            using (var conexion = new DetallesDB())
            {
                try
                {
                    foreach (GruposEstudiantes ge in gruposEstudiantes)
                        est.Add(conexion.Estudiante.Find(ge.EstudianteId));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());// throw;
                }

            }
            return est;
        }
        public static bool Modificar(Estudiantes existente)
        {
            bool resultado = false;
            using (var conexion = new DetallesDB())
            {
                try
                {
                    conexion.Configuration.AutoDetectChangesEnabled = false;
                    conexion.Configuration.ValidateOnSaveEnabled = false;

                    var Exist = conexion.Entry(existente);
                    Exist.State = EntityState.Modified;

                    Exist.Property(e => e.EstudianteId).IsModified = false;

                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return resultado;
        }

        public static int UltimoId()
        {
            int UltId = 0;
            using (var conexion = new DetallesDB())
            {
                try
                {
                    UltId = conexion.Estudiante.Max(Id => Id.EstudianteId);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return UltId;
        }

    }
}
