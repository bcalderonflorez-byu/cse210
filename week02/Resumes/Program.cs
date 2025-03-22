using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._job_Title = "CoreOps Leader";
        job1._company_name = "Nequi";
        job1._startYear = 2023;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._job_Title = "Technical Consultant";
        job2._company_name = "Sophos";
        job2._startYear = 2018;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Brian Calderon";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}