using System;
using System.Collections.Generic;
using System.IO;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;

    public ScriptureLibrary(string filePath)
    {
        _scriptures = new List<Scripture>();

        string[] lines = File.ReadAllLines(filePath);

        for (int i = 0; i < lines.Length - 1; i += 2)
        {
            string referenceLine = lines[i].Trim();
            string verseLine = lines[i + 1].Trim();

            Reference reference = ParseReference(referenceLine);
            Scripture scripture = new Scripture(reference, verseLine);
            _scriptures.Add(scripture);
        }
    }

    private Reference ParseReference(string line)
    {
        // Example: "John 3:16"
        string[] parts = line.Split(' ');
        string book = parts[0];
        string[] chapterVerse = parts[1].Split(':');
        int chapter = int.Parse(chapterVerse[0]);
        int verse = int.Parse(chapterVerse[1]);

        return new Reference(book, chapter, verse);
    }

    public Scripture GetRandomScripture()
    {
        Random rand = new Random();
        int index = rand.Next(_scriptures.Count);
        return _scriptures[index];
    }
    
}
