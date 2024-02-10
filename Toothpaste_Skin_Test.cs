using System;

class ToothpasteSkinTestMonitor
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Toothpaste Skin Test Monitor!");

        while (true)
        {
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Test toothpaste");
            Console.WriteLine("2. Exit");

            int choice = GetValidIntegerInput("Enter your choice: ");

            switch (choice)
            {
                case 1:
                    TestToothpaste();
                    break;
                case 2:
                    Console.WriteLine("Thank you for using the Toothpaste Skin Test Monitor. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void TestToothpaste()
    {
        Console.WriteLine("Testing toothpaste...");
        Console.WriteLine("Apply a small amount of toothpaste on a small area of the skin.");
        Console.WriteLine("Wait for at least 24 hours and observe for any skin reactions or irritation.");
        Console.WriteLine("If there are no adverse reactions, the toothpaste is likely safe for use.");
        Console.WriteLine("If there are any signs of redness, rash, or discomfort, discontinue use and consult a dermatologist.");
    }

    static int GetValidIntegerInput(string message)
    {
        int input;
        bool isValidInput;

        do
        {
            Console.Write(message);
            isValidInput = int.TryParse(Console.ReadLine(), out input);
            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        } while (!isValidInput);

        return input;
    }
}
