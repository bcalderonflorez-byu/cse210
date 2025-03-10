/* Author: Brian Calderon
   Aditional Code:
    1) Loop to Execute many times.
    2) Add to your code the ability to include a "+" or "-" next to the letter grade.
    3) Recognize that there is no A+ grade, only A and A-. Add some additional logic to your program to detect this case and handle it correctly.
    4) Similarly, recognize that there is no F+ or F- grades, only F. Add additional logic to your program to detect these cases and handle them correctly.
*/

using System;


class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise2 Project.");
        
        string letter = "F";
        string again = "N";

        do {
            Console.Write("What is your grade percentage? ");
            int grade_user  = int.Parse(Console.ReadLine());
            string sing = "";

            if (grade_user >= 90)
            {
                letter = "A";
            }
            else if (grade_user >= 80)
            {
                letter = "B";
            }
            else if (grade_user >= 70)
            {
                letter = "C";
            }
            else if (grade_user >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }


            double sing_value = double.Parse((((double)grade_user/10) -  (grade_user/10)).ToString("#.0"));
            if (sing_value >= 0.7 && letter != "A" && letter != "F") {
                sing = "+";
            } else if (sing_value < 0.3 && letter != "F") {
                sing = "-";
            }

            Console.WriteLine($"Your letter grade is: {letter}{sing}");

            if (grade_user >= 70)
            {
               Console.WriteLine($"Congratulations, you passed the course.");
            } else {
               Console.WriteLine($"Sorry, you dont passed the course please try again.");
            }


            Console.WriteLine("Would you like to check again? (Y/N)");
            again = Console.ReadLine().ToUpper();

        }while(again=="Y");

    }
}