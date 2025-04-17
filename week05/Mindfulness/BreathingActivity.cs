using System;

class BreathingActivity:Activity
{

    public BreathingActivity(string name, string description)
        :base(name,description)
    {
    }
    
    public void Run(){
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(7);

        int duration = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime){
            Console.Write($"\n\nBreathe in...");
            ShowCountDown(4);
            Console.Write($"\nNow breathe out...");
            ShowCountDown(6);
        }
        
        Console.WriteLine("\n\nWell done!!");
        ShowSpinner(5);
    }


}