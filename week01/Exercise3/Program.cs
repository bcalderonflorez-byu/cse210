/* Author: Brian Calderon
   Aditional Code:
   1) Keep track of how many guesses the user has made and inform them of it at the end of the game.
   2) Una vez finalizado el juego, pregúntale al usuario si quiere volver a jugar. Luego, vuelve a repetir el ciclo y juega todo el juego nuevamente mientras el usuario siga diciendo "yes".
*/

using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string again = "NO";

        do {
            //Console.WriteLine("Hello World! This is the Exercise3 Project.");
            int Magic_number = RandomNumberGenerator.GetInt32(1,100);        
            //Console.Write("What is the magic number? ");
            //Magic_number  = int.Parse(Console.ReadLine());
            int answer_number = 0;
            int num_cycles = 0;

            do{
                Console.Write("What is your guess? ");
                answer_number  = int.Parse(Console.ReadLine());

                num_cycles += 1;

                if(answer_number == Magic_number){
                    Console.WriteLine("You guessed it! ");
                    Console.WriteLine($"Guesses:{num_cycles}");
                } else if (answer_number < Magic_number){
                    Console.WriteLine("Higher");
                } else {                
                    Console.WriteLine("Lower");
                }

            }while (Magic_number != answer_number);

            
            Console.WriteLine("Would you like to play again? (YES/NO)");
            again = Console.ReadLine().ToUpper();

        }while(again=="YES");

    }
}