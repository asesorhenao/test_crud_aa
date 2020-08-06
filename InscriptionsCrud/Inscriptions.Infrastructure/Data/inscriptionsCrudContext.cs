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

        public virtual DbSet<Inscription> Inscriptions { get; set; }
        public object Publication { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inscription>(entity =>
            {
                entity.HasKey(e => e.RegistrationId);

                entity.ToTable("tbl_Inscriptions");

                entity.HasComment("");

                entity.Property(e => e.LastName)
                    .HasColumnName("Apellidos")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpeditionCity)
                    .HasColumnName("CiudadExpedicion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BirthCity)
                    .HasColumnName("CiudadNacimiento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpeditionDepartment)
                    .HasColumnName("DepartamentoExpedicion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDepartment)
                    .HasColumnName("DepartamentoNacimiento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direcction)
                    .HasColumnName("Direccion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CivilStatus)
                    .HasColumnName("EstadoCivil")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpeditionDate)
                    .HasColumnName("FechaExpedicion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate)
                    .HasColumnName("FechaNacimiento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BloodType)
                    .HasColumnName("GrupoSanguineo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationId)
                    .HasColumnName("IdInscripcion")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Modality)
                    .HasColumnName("Modalidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("Nombres")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CellphoneNumber)
                    .HasColumnName("NumeroCelular")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentNumber)
                    .HasColumnName("NumeroDocumento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneNumber)
                    .HasColumnName("NumeroTelefono")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpeditionCountry)
                    .HasColumnName("PaisExpedicion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BirthCountry)
                    .HasColumnName("PaisNacimiento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AcademicPeriod)
                    .HasColumnName("PeriodoAcademico")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Program)
                    .HasColumnName("Programa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Campus)
                    .HasColumnName("Sede")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasColumnName("Sexo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicantType)
                    .HasColumnName("TipoAspirante")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentType)
                    .HasColumnName("TipoDocumento")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
