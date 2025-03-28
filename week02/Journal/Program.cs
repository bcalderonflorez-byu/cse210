/* Author: Brian Calderon
   Aditional Code:
   1) Adding custom Prompts and save in a file and load automatically in the next program start
*/

using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        PromptGenerator _generator = new PromptGenerator();
        _generator.base_Prompts();        
        Prompt Question = new Prompt();        
        Journal myJournal = new Journal();
        
        bool Quit = false;

        try{
            do {        
    
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Add New Promts\n6. Quit");
                Console.Write("What would you like to do? ");
                int Choice_answer =  int.Parse(Console.ReadLine());

                switch(Choice_answer) 
                {
                case 1:
                    Question = _generator.GetRandomPrompt();
                    Console.WriteLine(Question._Question);
                    string answer =  Console.ReadLine();

                    Entry entry = new Entry();
                    entry._date = DateTime.Now.ToShortDateString();
                    entry._promptsText = Question._Question;
                    entry._entryText = answer;

                    myJournal.AddEntry(entry);
                    break;
                case 2:            
                    myJournal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("What is the filename? ");
                    string Loadfilename =  Console.ReadLine();
                    myJournal.LoadFromFile(Loadfilename);
                    break;
                case 4:
                    Console.WriteLine("What is the filename? ");
                    string Savefilename =  Console.ReadLine();
                    myJournal.SaveToFile(Savefilename);
                    break;
                case 5:
                    Console.WriteLine("What is the category of the prompt ? ");
                    string NewCategoryPrompt =  Console.ReadLine();
                    Console.WriteLine("What is the question to add ? ");
                    string NewQuestion =  Console.ReadLine();
                    
                    Prompt NewPrompt = new Prompt();
                    NewPrompt._Category = NewCategoryPrompt;
                    NewPrompt._Question = NewQuestion;
                    _generator.AddPrompt(NewPrompt);

                    break;
                case 6:
                    Quit = true;
                    Console.WriteLine("Bye Bye !");
                    break;

                default:
                    break;
                }                
            
            } while (Quit == false);
        }catch (Exception e)
        {
           Console.WriteLine(e.Message);
        }   
    }
}