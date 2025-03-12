using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int square = SquareNumber(UserNumber);
        DisplayResult(square,UserName);
    }

     
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber (int first)
    {
        int squarenum = first*first ;
        return squarenum;
    }
   
    static void  DisplayResult (int square, string userName)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");
        
    }

}