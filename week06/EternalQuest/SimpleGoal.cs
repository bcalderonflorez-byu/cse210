using System;

public class SimpleGoal:Goal
{

    private bool _isComplete;
    public SimpleGoal(string name, string description, string points)
        :base(name,description,points)
    {
        _isComplete = false;
    }
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        _isComplete = true;
        return  int.Parse(GetPoints());
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public void SetComplete(bool iscomplete)
    {
        _isComplete = iscomplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }   
    public override string GetDetailsString(){

        string complete = " ";
        if(IsComplete()){
            complete = "X";
        }
        return $"[{complete}] {GetName()} ({GetDescription()})";
    } 

}