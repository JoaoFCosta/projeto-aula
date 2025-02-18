namespace TecnusAPI.Model
{
    public class Quiz
    {
        public int QuizId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int CursoId { get; set; }
        public Curso? Curso { get; set; }
    }
}
