using System;

class Exercises
{
    static void Main()
    {
        // P01 - Even or Odd
        Console.Write("Input a whole number: ");
        int value = Convert.ToInt32(Console.ReadLine());

        if (value % 2 == 0)
        {
            Console.WriteLine($"Result: {value} is EVEN.");
        }
        
        // P02 - Positive or Negative
        if (value > 0)
        {
            Console.WriteLine($"{value} is POSITIVE.");
        }
        else if (value < 0)
        {
            Console.WriteLine($"{value} is NEGATIVE.");
        }
        else
        {
            Console.WriteLine("The number is ZERO.");
        }

        // P03 - Age & Income Category
        Console.Write("Enter age in years: ");
        int ageInput = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter income per month: ");
        double monthlyPay = Convert.ToDouble(Console.ReadLine());

        if (ageInput >= 25 && ageInput <= 35 && monthlyPay > 50000)
        {
            Console.WriteLine("Classification: Young Professional");
        }
        else if (ageInput >= 36 && ageInput <= 55 && monthlyPay > 70000)
        {
            Console.WriteLine("Classification: Mid-aged Professional");
        }
        else if (ageInput >= 56 && monthlyPay < 30000)
        {
            Console.WriteLine("Classification: Senior Citizen");
        }
        else
        {
            Console.WriteLine("Classification: General");
        }

        // P04 - Pass/Fail
        Console.Write("Enter test score: ");
        int grade = Convert.ToInt32(Console.ReadLine());

        string outcome = grade >= 50 ? "PASS" : "FAIL";
        Console.WriteLine($"Student Result: {outcome}");

        // P05 - Circle Operations
        Console.Write("Enter circle radius: ");
        double rad = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nMenu:");
        Console.WriteLine("A - Area");
        Console.WriteLine("P - Perimeter");
        Console.WriteLine("E - End Program");

        Console.Write("Your option: ");
        char pick = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (pick)
        {
            case 'A':
                Console.WriteLine($"Circle Area = {Math.PI * rad * rad}");
                break;

            case 'P':
                Console.WriteLine($"Circle Perimeter = {2 * Math.PI * rad}");
                break;

            case 'E':
                Console.WriteLine("Program terminated.");
                break;

            default:
                Console.WriteLine("Invalid option chosen!");
                break;
        }
    }
}
