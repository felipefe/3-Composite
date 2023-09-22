namespace Name
{
    //Component
    public abstract class ItemQuestionario
    {
        public string Descicao;
        public abstract void Exibir();
        public virtual void Add(ItemQuestionario item){}
        public virtual void Remove(ItemQuestionario item){}
    }
}