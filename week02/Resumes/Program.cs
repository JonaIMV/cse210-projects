using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Tech Solutions";
        job1._startYear = "2020";
        job1._endYear = "2025";

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Data Insights";
        job2._startYear = "2025";
        job2._endYear = "Present";

        Resume myResume = new Resume();
        myResume._name = "Jonathan Morales";


        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}