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
    public class GruposBLL
    {
        public static bool Insertar(Grupos Nuevo)
        {
            bool resultado = false;
            var conexion = new DetallesDB();
            //using ()
            //{
            try
            {
                conexion.Grupo.Add(Nuevo);

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
        public static Grupos Buscar(int grupoId)
        {
            var grupo = new Entidades.Grupos();
                try
                {
                    var conexion = new DetallesDB();
                    grupo = conexion.Grupo.Find(grupoId);
                }
                catch (Exception)
                {
                    throw;
                }
            return grupo;
        }

        public static List<Grupos> Buscar(List<GruposEstudiantes> gruposEstudiantes)
        {
            var est = new List<Grupos>();
            using (var conexion = new DetallesDB())
            {
                try
                {
                    foreach (GruposEstudiantes ge in gruposEstudiantes)
                        est.Add(conexion.Grupo.Find(ge.GrupoId));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());// throw;
                }
            }
            return est;
        }

        public static bool Eliminar(Grupos existente)
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
        
        public static bool Modificar(Grupos existente)
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

                    Exist.Property(G => G.GrupoId).IsModified = false;

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

        public static List<Grupos> GetList()
        {
            var lista = new List<Grupos>();
            using (var conexion = new DetallesDB())
            {
                try
                {
                    lista = conexion.Grupo.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }

        public static int UltimoId()
        {
            int UltId = 0;
            using (var conexion = new DetallesDB())
            {
                try
                {
                    if(GetList().Count() > 0)
                        UltId = conexion.Grupo.Max(Id => Id.GrupoId);
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
