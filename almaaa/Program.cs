namespace almaaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("alma", "asd", 1800, 425, 5000);
            Book b2 = new Book("alma2", "asd2", 1920, 680, 8000);
            Book b3 = new Book("alma3", "asd3");

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);

            Console.WriteLine(b1.PriceInc(500));

            Console.WriteLine(b2.Discount(10));
          
            Console.WriteLine(b3.RemainingPages(148));
        }
    }
}
