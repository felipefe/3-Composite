namespace Name
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var g1 = new Grupo("Plano Contas");
            var g2 = new Grupo("Despesa");
            var g3 = new Grupo("Receita");
            g1.Add(g2);
            g1.Add(g3);

            var g4 = new Grupo("Funcionario");
            g4.Add(new Questao("CLT ou PJ?"));
            g4.Add(new Questao("Tem direito a férias?"));
            g2.Add(g4); ///

            var g5 = new Grupo("Comissao");
            g5.Add(new Questao("Qual maior salario comissionado pago no mes?"));
            g2.Add(g5);//

            var g6 = new Grupo("Cliente");
            g6.Add(new Questao("Meus lucros com cliente?"));
            g6.Add(new Questao("Existem outros clientes?"));
            g3.Add(g6);//

            //Manda exibir a arvore
            g1.Exibir();
        }
    }
}