using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OficialGest.Models;

namespace OficialGest.Data
{
    public partial class CTI51003Context : DbContext
    {
        public CTI51003Context()
        {
        }

        public CTI51003Context(DbContextOptions<CTI51003Context> options)
            : base(options)
        {
        }

        public virtual DbSet<DocUnidad> DocUnidads { get; set; } = null!;
        public virtual DbSet<TipoDoc> TipoDocs { get; set; } = null!;
        public virtual DbSet<Unidad> Unidads { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<UsuarioUnidad> UsuarioUnidads { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Initial Catalog=CTI51003;Persist Security Info=False;User ID=sa;Password=Locuras2012$;MultipleActiveResultSets=False;Encrypt=True;Trust Server Certificate=True;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocUnidad>(entity =>
            {
                entity.ToTable("DocUnidad");

                entity.Property(e => e.Autoreset).HasColumnName("autoreset");

                entity.Property(e => e.CodTipoDoc).HasColumnName("codTipoDoc");

                entity.Property(e => e.CodUnidad).HasColumnName("codUnidad");

                entity.Property(e => e.Correlativo).HasColumnName("correlativo");

                entity.Property(e => e.Mascara)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mascara");

                entity.Property(e => e.Pantilla)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("pantilla");
            });

            modelBuilder.Entity<TipoDoc>(entity =>
            {
                entity.ToTable("TipoDoc");
            });

            modelBuilder.Entity<Unidad>(entity =>
            {
                entity.ToTable("Unidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasComment("Usuario Aplicacion");

                entity.Property(e => e.CodRol).HasColumnName("codRol");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password")
                    .IsFixedLength();

                entity.Property(e => e.Usuario1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario")
                    .IsFixedLength();
            });

            modelBuilder.Entity<UsuarioUnidad>(entity =>
            {
                entity.ToTable("UsuarioUnidad");

                entity.Property(e => e.CodUnidad).HasColumnName("codUnidad");

                entity.Property(e => e.CodUsuario).HasColumnName("codUsuario");

                entity.HasOne(d => d.CodUnidadNavigation)
                    .WithMany(p => p.UsuarioUnidads)
                    .HasForeignKey(d => d.CodUnidad)
                    .HasConstraintName("FK_2");

                entity.HasOne(d => d.CodUsuarioNavigation)
                    .WithMany(p => p.UsuarioUnidads)
                    .HasForeignKey(d => d.CodUsuario)
                    .HasConstraintName("FK_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
