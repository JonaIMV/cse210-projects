using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks.Dataflow;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(string prompt, string response)
    {
        Entry entry = new Entry();
        entry._prompt = prompt;
        entry._response = response;
        entry._date = DateTime.Now.ToString("yyyy-MM-dd");
        _entries.Add(entry);
    }

    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToSaveFormat());
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Entry entry = Entry.FromSavedString(line);
            _entries.Add(entry);
        }
    }    

}