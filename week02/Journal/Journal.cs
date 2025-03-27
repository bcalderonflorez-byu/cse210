using System;

public class Journal
{
 
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
      
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.print_entry();
        }
    }
    
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
              //outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._promptsText} \n{entry._entryText}");
              outputFile.WriteLine($"{entry._date};{entry._promptsText};{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(";");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptsText = parts[1];
            entry._entryText = parts[2];
            
            AddEntry(entry);
            
        }
    }

}