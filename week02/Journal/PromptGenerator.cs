using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<Prompt> _prompts = new List<Prompt>();

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

    }
    public Prompt GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);        
        Prompt random_prompt = _prompts[index];
        return random_prompt;
    }

    
}