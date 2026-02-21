namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "Boooook", 125, false);
            Book book2 = new Book(2, "Kooooob", 521, true);
            Book book3 = new Book(3, "Okbkbko", 215, true);

            while (true)
            {
                Console.Write("1. Display All\n2. Update One Item\n 3. Exit\nEnter choice: ");

                string initialChoice = Console.ReadLine();

                switch (initialChoice)
                {
                    // Display
                    case "1":
                        book1.DisplayInfo();
                        book2.DisplayInfo();
                        book3.DisplayInfo();
                        continue;

                    // Update
                    case "2":
                        continue;

                    // Exit
                    case "3":
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Unknown choice, try again.");
                        continue;
                }
                break;
            }
        }
    }
}
