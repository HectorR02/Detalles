using DAL1;
using Entidades;
using System;
using System.Collections.Generic;
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
            using (var conexion = new DetallesDB())
            {
                try
                {
                    est = conexion.Estudiante.Find(EstudianteId);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return est;
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
    }
}
