using System;

public class ChecklistGoal:Goal
{

    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int target, int bonus)
        :base(name,description,points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {        
        _amountCompleted++;
        int points = int.Parse(GetPoints());
        if (IsComplete()){            
            points = points + _bonus;
        }
        Console.WriteLine($"Congratulations! You have earned {points} points!");

        return points;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target ? true : false;
    }

    public void SetAmountCompleted(int amountCompleted){
        _amountCompleted = amountCompleted;
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }    
    public override string GetDetailsString(){

        string complete = " ";
        if(IsComplete()){
            complete = "X";
        }
        return $"[{complete}] {GetName()} ({GetDescription()}) --- Currently completed: {_amountCompleted}/{_target}";
    }



}