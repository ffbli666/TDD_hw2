namespace PotterShoppingCart
{
    internal interface IStage
    {
        void Add(Book book);
        double Calculate();
    }
}