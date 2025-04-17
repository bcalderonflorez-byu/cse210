using System;

public class EternalGoal:Goal
{

    public EternalGoal(string name, string description, string points)
        :base(name,description,points)
    {
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        return int.Parse(GetPoints());
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }
    public override string GetDetailsString(){

        string complete = " ";
        if(IsComplete()){
            complete = "X";
        }
        return $"[{complete}] {GetName()} ({GetDescription()})";
    }
}