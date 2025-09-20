using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine(""): Will print, or write, a full line, including the new line. If you want the user to type below the question use this.
        //Console.Write(""): Text with no newline afterward. If you want the user to type next to the question, use this.

        Console.Write("What is your first name? ");
        //string ("keyward") = (whatever command, here we used "Console.ReadLine() so the user puts their info in this string.)
        string first = Console.ReadLine();
        //string: A sequence of characters, including letters, numbers, or symbols.
        //int: Whole numbers, positive and negative
        //float: Floating point numbers (numbers that use decimals.)
        //double: Double precision floating point numbers (just like a float, except it takes up twice as much memory, so it can hold larger numbers or numbers with more decimal places.)
        //bool: True or false
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    
    }
}

