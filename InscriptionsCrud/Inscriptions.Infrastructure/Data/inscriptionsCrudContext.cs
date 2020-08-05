using Inscriptions.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inscriptions.Infrastructure.Data
{
    public partial class inscriptionsCrudContext : DbContext
    {
        public inscriptionsCrudContext()
        {
        }

        public inscriptionsCrudContext(DbContextOptions<inscriptionsCrudContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblInscriptions> TblInscriptions { get; set; }
        public object Publication { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblInscriptions>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Inscriptions");

                entity.HasComment("");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadExpedicion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadNacimiento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoExpedicion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoNacimiento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoCivil)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaExpedicion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoSanguineo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdInscripcion).ValueGeneratedOnAdd();

                entity.Property(e => e.Modalidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCelular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroTelefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaisExpedicion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaisNacimiento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoAcademico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Programa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sede)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAspirante)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
