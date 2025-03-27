using System;

public class Entry
{
    public string _date;
    
    public string _promptsText;
    public string _entryText;

    public void print_entry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptsText} \n{_entryText}\n");
    }
    
}