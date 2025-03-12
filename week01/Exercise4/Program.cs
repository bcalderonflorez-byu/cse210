/* Author: Brian Calderon
   Aditional Code:
   1) Haga que el usuario ingrese números positivos y negativos, luego busque el número positivo más pequeño (el número positivo más cercano a cero).
   2) Ordena los números de la lista y muestra la nueva lista ordenada. Sugerencia: existen bibliotecas de C# que pueden ayudarte en este caso. Intenta buscarlas en Internet.
*/

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> Numbers = new List<int>();
        List<int> Negative_Numbers = new List<int>();
        int answer_num = 0;
        int sum_total = 0;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        do {

            Console.Write("Enter number: ");
            answer_num  = int.Parse(Console.ReadLine());
            if (answer_num != 0){
                Numbers.Add(answer_num);                
            }

        }while (answer_num != 0);

        foreach (int num in Numbers){
            sum_total += num;
            if ( num < 0){
                Negative_Numbers.Add(num);
            }
        }

        Console.WriteLine($"The sum is: {sum_total}");
        Console.WriteLine($"The average is: {Numbers.Average()}");
        Console.WriteLine($"The largest number is: {Numbers.Max()}");
        int smaller = Numbers.Except(Negative_Numbers).Min();
        Console.WriteLine($"The smallest positive number is: {smaller}");

        Console.WriteLine("The sorted list is:");
        Numbers.Sort();
        
        foreach (int num in Numbers){
            Console.WriteLine(num);            
        }

    }
}