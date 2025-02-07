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


            Movie f1 = new Movie("alma", "asd", 1800, "asdasd", true);
            Movie f2 = new Movie("alma2", "asd2", 1920, "asdasd2", false);
            Movie f3 = new Movie("alma3", "asd3");

            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(f3);

            Console.WriteLine(f1.Play());

            Console.WriteLine(f2.TypeChange("asdf"));

            Console.WriteLine(f3.LengthInc(24));
        }


    }
}
