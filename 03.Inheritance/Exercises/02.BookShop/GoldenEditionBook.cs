namespace _02.BookShop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, decimal price)
            : base(title, author, price)
        {
        }

        public override decimal Price
        {
            get
            {
                return base.Price + (base.Price * (30m / 100m));
            }
        }
    }
}