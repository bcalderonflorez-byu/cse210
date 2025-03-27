using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<Prompt> _prompts = new List<Prompt>();
    string promptfilename = "Custom_Prompts.txt";

    public void base_Prompts(){
        Prompt Prompt1 = new Prompt();
        Prompt1._Category = "People";
        Prompt1._Question = "Who was the most interesting person I interacted with today?";

        Prompt Prompt2 = new Prompt();
        Prompt2._Category = "Activities";
        Prompt2._Question = "What was the best part of my day?";

        Prompt Prompt3 = new Prompt();
        Prompt3._Category = "Spiritual";
        Prompt3._Question = "How did I see the hand of the Lord in my life today?";

        Prompt Prompt4 = new Prompt();
        Prompt4._Category = "Emotional";
        Prompt4._Question = "What was the strongest emotion I felt today?";

        Prompt Prompt5 = new Prompt();
        Prompt5._Category = "Analysis";
        Prompt5._Question = "If I had one thing I could do over today, what would it be?";

        _prompts.Add(Prompt1);
        _prompts.Add(Prompt2);
        _prompts.Add(Prompt3);
        _prompts.Add(Prompt4);
        _prompts.Add(Prompt5);

        if (File.Exists(promptfilename) ) 
        {
            string[] lines = System.IO.File.ReadAllLines(promptfilename);
            
            foreach (string line in lines)
            {
                string[] parts = line.Split(";");

                Prompt prompt = new Prompt();
                prompt._Category = parts[0];
                prompt._Question = parts[1];
                
                _prompts.Add(prompt);
                
            }
        }

    }
    public Prompt GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);        
        Prompt random_prompt = _prompts[index];
        return random_prompt;
    }

    public void AddPrompt(Prompt prompt)
    {
        _prompts.Add(prompt);

        if (File.Exists(promptfilename) ) 
        {
            using (StreamWriter stream = File.AppendText(promptfilename))
            {
                stream.WriteLine($"{prompt._Category};{prompt._Question}");
            }

        } else {
            using (StreamWriter outputFile = new StreamWriter("Custom_Prompts.txt"))
            {
                outputFile.WriteLine($"{prompt._Category};{prompt._Question}");
            }  
        }

    
    }

    
}