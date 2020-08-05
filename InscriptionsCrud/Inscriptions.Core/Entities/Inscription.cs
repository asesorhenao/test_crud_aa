namespace Inscriptions.Core.Entities
{
    public class Inscription
    {
        public int InscriptionId { get; set; }
        public string TipoAspirante { get; set; }
        public string Modalidad { get; set; }
        public string Sede { get; set; }
        public string Programa { get; set; }
        public string PeriodoAcademico { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
    }
}
