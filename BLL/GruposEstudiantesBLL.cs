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
    public class GruposEstudiantesBLL
    {
        public static bool Insertar(GruposEstudiantes Nuevo)
        {
            bool resultado = false;
            var conexion = new DetallesDB();
            //using ()
            //{
            try
            {
                conexion.GrupoEstudiante.Add(Nuevo);

                conexion.SaveChanges();
                resultado = true;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString()); //throw;
            }
            // }
            return resultado;
        }
        public static List<GruposEstudiantes> Buscar(int grupoId)
        {
            var grupo = new List<GruposEstudiantes>();
            try
            {
                var conexion = new DetallesDB();
                grupo = conexion.GrupoEstudiante.Where(ge => ge.GrupoId == grupoId).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return grupo;
        }

        public static List<GruposEstudiantes> BuscarGrupos(int estudianteId)
        {
            var grupo = new List<GruposEstudiantes>();
            try
            {
                var conexion = new DetallesDB();
                grupo = conexion.GrupoEstudiante.Where(ge => ge.EstudianteId == estudianteId).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return grupo;
        }

        public static bool Eliminar(GruposEstudiantes existente)
        {
            bool resultado = false;
            using (var conexion = new DetallesDB())
            {
                try
                {
                    conexion.Entry(existente).State = EntityState.Deleted;
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


        public static bool Insertar(List<GruposEstudiantes> grupoEstudiante)
        {
            bool resultado = false;
            var conexion = new DetallesDB();
            //using ()
            //{
            try
            {
                foreach (GruposEstudiantes GE in grupoEstudiante)
                    conexion.GrupoEstudiante.Add(GE);

                conexion.SaveChanges();
                resultado = true;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString()); //throw;
            }
            // }
            return resultado;
        }
    }
}
