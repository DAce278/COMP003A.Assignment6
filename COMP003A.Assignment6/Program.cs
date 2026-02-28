using System.Numerics;

namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new (1, "Boooook", 125, false);
            Book book2 = new (2, "Kooooob", 521, true);
            Book book3 = new (3, "Okbkbko", 215, true);

            while (true)
            {
                Console.Write("1. Display All\n2. Update One Item\n3. Exit\nEnter choice: ");

                string initialChoice = Console.ReadLine();
                Console.WriteLine();

                switch (initialChoice)
                {
                    // Display
                    case "1":
                        book1.DisplayInfo();
                        book2.DisplayInfo();
                        book3.DisplayInfo();
                        Console.WriteLine();
                        continue;

                    // Update
                    case "2":
                        Console.Write("Which item would you like to update: ");
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            book1.UpdateCompletion(book1.Completion);
                        }
                        else if (choice == 2)
                        {
                            book2.UpdateCompletion(book2.Completion);
                        }
                        else if (choice == 3)
                        {
                            book3.UpdateCompletion(book3.Completion);
                        }
                        else
                        {
                            Console.WriteLine("Unknown choice, try again.");
                        }
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
