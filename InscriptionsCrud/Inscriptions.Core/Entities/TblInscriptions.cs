namespace Inscriptions.Core.Entities
{
    public partial class TblInscriptions
    {
        public long IdInscripcion { get; set; }
        public string TipoAspirante { get; set; }
        public string Modalidad { get; set; }
        public string Sede { get; set; }
        public string Programa { get; set; }
        public string PeriodoAcademico { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string FechaNacimiento { get; set; }
        public string PaisNacimiento { get; set; }
        public string DepartamentoNacimiento { get; set; }
        public string CiudadNacimiento { get; set; }
        public string GrupoSanguineo { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string FechaExpedicion { get; set; }
        public string PaisExpedicion { get; set; }
        public string DepartamentoExpedicion { get; set; }
        public string CiudadExpedicion { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string NumeroTelefono { get; set; }
        public string NumeroCelular { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
    }
}
