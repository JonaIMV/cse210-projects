using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public override string ToString()
    {
        return $"{_book} {_chapter}:{_verse}";
    }

    public static Reference Parse(string referenceString)
    {
        string[] parts = referenceString.Split(' ', 2);
        if (parts.Length < 2)
        {
            throw new ArgumentException("Invalid reference format.");
        }

        string book = parts[0];
        string chapterAndVerse = parts[1];

        if (chapterAndVerse.Contains("-"))
        {
            string[] chapterParts = chapterAndVerse.Split(':');
            int chapter = int.Parse(chapterParts[0]);

            string[] verses = chapterParts[1].Split('-');
            int startVerse = int.Parse(verses[0]);
            int endVerse = int.Parse(verses[1]);

            // Aquí solo tomo el primer verso para simplificar
            return new Reference(book, chapter, startVerse);
        }
        else
        {
            string[] chapterParts = chapterAndVerse.Split(':');
            int chapter = int.Parse(chapterParts[0]);
            int verse = int.Parse(chapterParts[1]);
            return new Reference(book, chapter, verse);
        }
    }
}

