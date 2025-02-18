namespace TecnusAPI.Model
{
    public class Comentario
    {
        public int ComentarioId { get; set; }
        public string NomeUsuario { get; set; }
        public string Texto { get; set; }
        public int CursoId { get; set; }
        public Curso? Curso { get; set; }
    }
}
