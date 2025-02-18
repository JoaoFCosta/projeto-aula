namespace TecnusAPI.Model
{
    public class Pergunta
    {
        public int PerguntaId { get; set; }
        public string TextoQuestao { get; set; }
        public string Resposta { get; set; }
        public int QuizId { get; set; }
        public Quiz? Quiz { get; set; }
    }
}
