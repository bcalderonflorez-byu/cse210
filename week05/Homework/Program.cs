using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment assign1 = new Assignment("Brian Calderon", "Multiplication");
        Console.WriteLine(assign1.GetSummary());

       
        MathAssignment assign2 = new MathAssignment("Maria Jose Suarez", "Fractions", "7.2", "10-19");
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetHomeWorkList());

        WritingAssignment assign3 = new WritingAssignment("Mariana Calderon Suarez", "European History", "The Causes of World War II");
        Console.WriteLine(assign3.GetSummary());
        Console.WriteLine(assign3.GetWritingInformation());
    }
}