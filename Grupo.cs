namespace Name
{
    //Compositive
    public class Grupo : ItemQuestionario
    {
        private List<ItemQuestionario> ItemQuestionarios = null;
        public Grupo(string description)
        {
            ItemQuestionarios = new List<ItemQuestionario>();
            this.Descicao = description;
        }

        //Add
        public override void Add(ItemQuestionario item)
        {
            ItemQuestionarios.Add(item);
        }

        //Remove 
        public override void Remove(ItemQuestionario item)
        {
            ItemQuestionarios.Remove(item);
        }

        //Exibe a arvore
        public override void Exibir()
        {
            System.Console.WriteLine($"Grupo: {this.Descicao}");
            foreach(var item in ItemQuestionarios) 
                item.Exibir();
        }
    }
}