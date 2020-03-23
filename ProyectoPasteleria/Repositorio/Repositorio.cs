using Fluent.Infrastructure.FluentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoPasteleria.Models;



namespace ProyectoPasteleria.Repositorio
{
    public class Repositorio<T> : IRepositorio<T> where T : Entidad
    { 
        public void Actualizar(T entidad)
        {

            using (var db = new DataBase.DbContextLocal())
            {
                db.Entry(entidad).State = System.Data.Entity.EntityState.Modified;
            
                db.SaveChanges();
            }
        }

        public void Agregar(T entidad)
        {
            using (var db = new DataBase.DbContextLocal())
            {
                Usuario usuario = new Usuario();

                db.Entry(usuario).State = System.Data.Entity.EntityState.Added;

                db.SaveChanges();
            }
        }

        public void Eliminar(T entidad)
        {

            using (var db = new DataBase.DbContextLocal())
            {

                db.Entry(entidad).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}