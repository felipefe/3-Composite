namespace Name
{
    //Leaf => folha
    public class Questao : ItemQuestionario
    {

        public Questao(string question)
        {
            this.Descicao = question;
        }

        public override void Exibir()
        {
            System.Console.WriteLine($"Questão: {this.Descicao}");
        }
    }
}