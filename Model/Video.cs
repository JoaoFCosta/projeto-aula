namespace TecnusAPI.Model
{
    public class Video
    {
        public int VideoId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Url { get; set; }
        public DateTime DataPublicacao { get; set; }
        public int CursoId { get; set; }
        public Curso? Curso { get; set; }
    }
}
