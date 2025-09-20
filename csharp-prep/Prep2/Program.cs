using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        //Converting types: Convert a value of a variable to a different type: int.Parse(): create an integer from the digits stored in a string.
        //Examples: String valueInText = "42";
        //          int number = int.Parse(valueInText);
        int percentage = int.Parse(answer);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Good job! You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass.")
        }
    }
}