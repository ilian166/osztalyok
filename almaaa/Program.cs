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

            Game g1 = new Game("asd", 4, 180, 8);
            Game g2 = new Game("asd2", 7, 220, 15);
            Game g3 = new Game("asd3", 6);

            Console.WriteLine(g1);
            Console.WriteLine(g2);
            Console.WriteLine(g3);

            Console.WriteLine(g1.attack());
            Console.WriteLine(g2.heal(17));
            Console.WriteLine(g3.levelup());


            SpaceShip s1 = new SpaceShip("asd", 15, 6, 100);
            SpaceShip s2 = new SpaceShip("asd2", 18, 2, 79);
            SpaceShip s3 = new SpaceShip("asd3", 4);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            Console.WriteLine(s1.start());
            Console.WriteLine(s3.fueling(150));
            Console.WriteLine(s2.land());







        }

        


    }
}
