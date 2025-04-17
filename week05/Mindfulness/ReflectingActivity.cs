using System;

class ReflectingActivity:Activity
{

    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public ReflectingActivity(string name, string description)
        :base(name,description)
    {
    }
    
    public void Run(){
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(7);

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");        
        _questions.Add("How can you keep this experience in mind in the future?");

        DisplayPromt();
        Console.ReadKey();

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");        
        Console.Write($"You may begin in: ");
        ShowCountDown(4);
        Console.Clear();
        
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime){
            DisplayQuestions();
            ShowSpinner(10);
        }

        Console.WriteLine("\n\nWell done!!");
        ShowSpinner(5);


    }

    public string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);        
        string random_prompt = _prompts[index];
        return random_prompt;
    }

    public string GetRandomQuestion(){
        var random = new Random();
        int index = random.Next(_questions.Count);        
        string random_question = _questions[index];
        return random_question;
    }

    public void DisplayPromt()
    {        
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");

    }
    public void DisplayQuestions(){
        Console.Write($"\n> {GetRandomQuestion()} ");
    }
}