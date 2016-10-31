using DAL1;
using Entidades;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class GruposBLL
    {
        public static bool Insertar(Grupos Nuevo)
        {
            bool resultado = false;
            using (var conexion = new DetallesDB())
            {
                try
                {
                    conexion.Grupo.Add(Nuevo);
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception ex)
                {

                    System.Windows.Forms.MessageBox.Show(ex.ToString());
                }
            }
            return resultado;
        }
        public static Grupos Buscar(int GrupoId)
        {
            var grupo = new Entidades.Grupos();
           // using (var conexion = new DetallesDB())
           // {
                try
                {
                    var conexion = new DetallesDB();
                    grupo = conexion.Grupo.Find(GrupoId);
                //var lst = new List<Estudiantes>();
                //lst = grupo.Estudiantes;
                }
                catch (Exception)
                {
                    throw;
                }
            //}
            return grupo;
        }

       
    }
}
