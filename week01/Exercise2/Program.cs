using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letterGrade;
        string sign = "";

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        int lastDigit = gradePercentage % 10;
        
        if (lastDigit >= 7)
        {
            sign = "+";

        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        if (letterGrade == "A" && sign == "+")
        {
            sign = "";
        }
        if (letterGrade == "F")
        {
            sign = "";
        }
        Console.WriteLine($"Your letter grade is {letterGrade}{sign}.");
        
        if(gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the course. Please try again.");
        }
    }
}