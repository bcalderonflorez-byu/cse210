using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;    
        
    public GoalManager(){
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start(){
        bool IsRunning = true;   

        do{
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
            Console.Write("Select a choice from the menu: ");
            int Choice_answer =  int.Parse(Console.ReadLine());   
            
            switch(Choice_answer) 
            {
            case 1:                     
                CreateGoal();
                break;
            case 2:     
                ListGoalDetails();
                break;
            case 3:  
                SaveGoals();             
                break;
            case 4:  
                LoadGoals();           
                break;
            case 5:  
                RecodEvent();             
                break;
            case 6:                
                Console.WriteLine("Bye Bye !");
                IsRunning = false;
                break;
            default:
                break;
            }  
        }while (IsRunning);

    }    
    public void CreateGoal(){
        Console.WriteLine("Menu Options:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int Choice_answer =  int.Parse(Console.ReadLine());
        string goalname = ""; 
        string description = ""; 
        string points = ""; 

        switch(Choice_answer) 
        {
        case 1:           
            Console.Write("What is the name of your goal? ");
            goalname =  Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description =  Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            points =  Console.ReadLine();

            SimpleGoal simpleGoal = new SimpleGoal(goalname,description,points);
            _goals.Add(simpleGoal);                        
            break;
        case 2:     
            Console.Write("What is the name of your goal? ");
            goalname =  Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description =  Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            points =  Console.ReadLine();

            EternalGoal eternalgoal = new EternalGoal(goalname,description,points);
            _goals.Add(eternalgoal);
            break;
        case 3:  
            Console.Write("What is the name of your goal? ");
            goalname =  Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description =  Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            points =  Console.ReadLine();
            
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int times_goal =  int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus =  int.Parse(Console.ReadLine());



            ChecklistGoal checklistGoal = new ChecklistGoal(goalname,description,points,times_goal,bonus);
            _goals.Add(checklistGoal);         
            break;        
        default:
            break;
        }  
    }
    public void DisplayPlayerInfo(){
        Console.WriteLine($"\nYou have {_score} points.\n");
    }
    public void ListGoalNames(){
        Console.WriteLine($"The goals are:");
        int i = 1;
        foreach (Goal goal in _goals){          
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
    }
    public void ListGoalDetails(){
        Console.WriteLine($"The goals are:");
        int i = 1;
        foreach (Goal goal in _goals){          
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }

    public void RecodEvent(){
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int answer =  int.Parse(Console.ReadLine());
        Goal goal = _goals[answer-1];        
        _score += goal.RecordEvent();
        Console.WriteLine($"You now have {_score} points.");

    }

    public void SaveGoals(){
        Console.Write("What is the filename for the goal file? ");
        string file =  Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine($"{_score}");
            foreach (Goal entry in _goals)
            {              
              outputFile.WriteLine(entry.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals(){
        Console.Write("What is the filename for the goal file? ");
        string filename =  Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _goals.Clear();

        int i = 0;
        foreach (string line in lines)
        {
            if (i == 0){
                _score = int.Parse(line);

            }else{
                string[] parts = line.Split(":");
                string[] parts2;

                switch(parts[0]) 
                {
                    case "SimpleGoal": 
                        parts2 = parts[1].Split(",");
                        SimpleGoal simpleGoal = new SimpleGoal(parts2[0],parts2[1],parts2[2]);
                        simpleGoal.SetComplete(bool.Parse(parts2[3]));
                        _goals.Add(simpleGoal);
                        break;
                    case "EternalGoal": 
                        parts2 = parts[1].Split(",");
                        EternalGoal eternalGoal = new EternalGoal(parts2[0],parts2[1],parts2[2]);
                        _goals.Add(eternalGoal);                        
                        break;
                    case "ChecklistGoal": 
                        parts2 = parts[1].Split(",");
                        ChecklistGoal checklistGoal = new ChecklistGoal(parts2[0],parts2[1],parts2[2],int.Parse(parts2[4]),int.Parse(parts2[3]));
                        checklistGoal.SetAmountCompleted(int.Parse(parts2[5]));
                        _goals.Add(checklistGoal);                        
                        break;                        
                    default:
                        break;
                }  
            }
            i++;
        }
    }


}