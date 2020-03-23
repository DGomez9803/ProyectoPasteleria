//// -----------------------------------------------------------------------
//// <copyright file="DbContextLocal.cs" company="Fluent.Infrastructure">
////     Copyright © Fluent.Infrastructure. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
/// This is a test file created by Fluent Infrastructure in order to 
/// illustrate its operation.
/// See more at: https://github.com/dn32/Fluent.Infrastructure/wiki
////-----------------------------------------------------------------------

using System.Data.Entity;
using Fluent.Infrastructure.FluentDBContext;
using ProyectoPasteleria.Models;

namespace ProyectoPasteleria.DataBase 
{
    public class DbContextLocal : DBContext
    {
        private const string Connection = "name = ModelBaseDeDatos";

        public DbContextLocal  () : base(Connection)
        {
    }

    public   DbSet<Administrador> Administrador { get; set; }
        public  DbSet<Catalogo> Catalogo { get; set; }
        public  DbSet<Cliente> Cliente { get; set; }
        public  DbSet<Factura> Factura { get; set; }
        public  DbSet<MediosEnvio> MediosEnvio { get; set; }
        public  DbSet<MediosPago> MediosPago { get; set; }
        public  DbSet<Pastel> Pastel { get; set; }
        public  DbSet<Pedido> Pedido { get; set; }
        public  DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrador>().HasKey(e => e.ID_ADMINISTRADOR);
            modelBuilder.Entity<Catalogo>().HasKey(e => e.ID_CATALOGO);
            modelBuilder.Entity<Cliente>().HasKey(e => e.ID_CLIENTE);
            modelBuilder.Entity<Factura>().HasKey(e => e.ID_FACTURA);
            modelBuilder.Entity<MediosEnvio>().HasKey(e => e.ID_MEDIOSENVIOS);
            modelBuilder.Entity<MediosPago>().HasKey(e => e.ID_MEDIOSPAGO);
            modelBuilder.Entity<Pastel>().HasKey(e => e.ID_PASTEL);
            modelBuilder.Entity<Pedido>().HasKey(e => e.ID_PEDIDO);
            modelBuilder.Entity<Usuario>().HasKey(e => e.ID_USUARIO);

            modelBuilder.Entity<Administrador>()
                .Property(e => e.AREA_ADMINISTRADOR)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo>()
                .Property(e => e.NOMBRE_CATALOGO)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo>()
                .HasMany(e => e.Pastel)
                .WithRequired(e => e.Catalogo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.DIRECCION_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.CIUDAD_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.DEPARTAMENTO_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Pedido)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.MediosEnvio)
                .WithMany(e => e.Cliente)
                .Map(m => m.ToTable("MediosEnvio_Cliente").MapLeftKey("ID_CLIENTE").MapRightKey("ID_MEDIOSENVIOS"));

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.MediosPago)
                .WithMany(e => e.Cliente)
                .Map(m => m.ToTable("MediosPago_Cliente").MapLeftKey("ID_CLIENTE").MapRightKey("ID_MEDIOSPAGO"));

            modelBuilder.Entity<Factura>()
                .Property(e => e.URL_FACTURA)
                .IsUnicode(false);

            modelBuilder.Entity<MediosEnvio>()
                .Property(e => e.NOMBRE_MEDIOSENVIOS)
                .IsUnicode(false);

            modelBuilder.Entity<MediosEnvio>()
                .Property(e => e.DESCRIPCION_MEDIOSENVIOS)
                .IsUnicode(false);

            modelBuilder.Entity<MediosPago>()
                .Property(e => e.NOMBRE_MEDIOSPAGO)
                .IsUnicode(false);

            modelBuilder.Entity<MediosPago>()
                .Property(e => e.DESCRIPCION_MEDIOSPAGO)
                .IsUnicode(false);

            modelBuilder.Entity<Pastel>()
                .Property(e => e.NOMBRE_PASTEL)
                .IsUnicode(false);

            modelBuilder.Entity<Pastel>()
                .Property(e => e.DESCRIPCION_PASTEL)
                .IsUnicode(false);

            modelBuilder.Entity<Pastel>()
                .HasMany(e => e.Pedido)
                .WithRequired(e => e.Pastel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pedido>()
                .Property(e => e.CANTIDAD)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Pedido>()
                .Property(e => e.TOTAL)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Pedido>()
                .HasMany(e => e.Factura)
                .WithRequired(e => e.Pedido)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.NOMBRE_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.APELLIDO_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.CORREO_ELECTRONICO_USUARIO)
                .IsUnicode(false);
            

            modelBuilder.Entity<Usuario>()
                .Property(e => e.CONTRASEÑA_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasOptional(e => e.Administrador)
                .WithRequired(e => e.Usuario);

            modelBuilder.Entity<Usuario>()
                .HasOptional(e => e.Cliente)
                .WithRequired(e => e.Usuario);
        }
    }

}
