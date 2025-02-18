namespace TecnusAPI.Model
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string CursoNome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Professor { get; set; }
    }
}
