using System;
using System.Runtime.CompilerServices;

class ListingActivity:Activity
{

    private int _count = 0;
    private List<string> _prompts = new List<string>();
    private List<string> _ListFromUser = new List<string>();
    public ListingActivity(string name, string description)
        :base(name,description)
    {
    }
    
    public void Run(){
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(7);

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
           
        Console.Write("\n");
        while (DateTime.Now < endTime){            
            Console.Write(">");
            string answer = Console.ReadLine();
            add_ListFromUser(answer);
        }

        List<string> listuser = GetListFromUser();
        _count = listuser.Count();
        Console.WriteLine($"You listed {_count} items!");

        Console.WriteLine("\nWell done!!");
        ShowSpinner(5);

    }

    public string GetRandomPrompt(){
        var random = new Random();
        int index = random.Next(_prompts.Count);        
        string random_prompt = _prompts[index];
        return random_prompt;
    }

    public List<string> GetListFromUser(){
       return _ListFromUser;
    }

    public void add_ListFromUser(string answer){
        _ListFromUser.Add(answer);
    }
}