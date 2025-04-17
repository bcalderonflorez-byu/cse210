/* Author: Brian Calderon
   Aditional Code:
   1) Keeping a log of how many times activities were performed. (resume in the 4. option)
*/

using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Mindfulness Project.");

        bool IsRunning = true;
        string name;
        string description;
        int Seconds_answer;
        Dictionary<string, int> Num_Activities = new Dictionary<string, int>();
        int count;
        
        Num_Activities.Add("Breathing Activity",0);
        Num_Activities.Add("Reflection Activity",0);
        Num_Activities.Add("Listing Activity",0);
        
        

        do{

            Console.WriteLine("Menu Options:\n 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Quit");
            Console.Write("Select a choice from the menu: ");
            int Choice_answer =  int.Parse(Console.ReadLine());

            switch(Choice_answer) 
            {
            case 1:     
                
                Console.Clear();
                name = "Breathing Activity";
                description  = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                BreathingActivity breathingActivity = new BreathingActivity(name,description);

                count = Num_Activities[name]+1;
                Num_Activities[name] = count;

                breathingActivity.DisplayStartingMessage();
                Seconds_answer =  int.Parse(Console.ReadLine());
                breathingActivity.SetDuration(Seconds_answer);
                breathingActivity.Run();
                breathingActivity.DisplayEdingMessage();
                breathingActivity.ShowSpinner(5);
                Console.Clear();

                break;
            case 2:     

                Console.Clear();
                name = "Reflection Activity";
                description  = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                ReflectingActivity reflectingActivity = new ReflectingActivity(name,description);

                count = Num_Activities[name]+1;
                Num_Activities[name] = count;

                reflectingActivity.DisplayStartingMessage();
                Seconds_answer =  int.Parse(Console.ReadLine());
                reflectingActivity.SetDuration(Seconds_answer);
                reflectingActivity.Run();
                reflectingActivity.DisplayEdingMessage();
                reflectingActivity.ShowSpinner(5);
                Console.Clear();

                break;
            case 3:  

                Console.Clear();
                name = "Listing Activity";
                description  = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                ListingActivity listingactivity = new ListingActivity(name,description);

                count = Num_Activities[name]+1;
                Num_Activities[name] = count;

                listingactivity.DisplayStartingMessage();
                Seconds_answer =  int.Parse(Console.ReadLine());
                listingactivity.SetDuration(Seconds_answer);
                listingactivity.Run();
                listingactivity.DisplayEdingMessage();
                listingactivity.ShowSpinner(5);
                Console.Clear();              
                break;
            case 4:                
                
                Console.Write("\n");
                foreach (var ele in Num_Activities)
                {
                    Console.WriteLine($"{ele.Key} num of executions : {ele.Value}");
                }                
                Thread.Sleep(5000);                
                Console.WriteLine("Bye Bye !");
                IsRunning = false;

                break;

            default:
                break;
            }  



        }while (IsRunning);


    }
}