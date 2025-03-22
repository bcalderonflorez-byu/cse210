using System;

public class Job
{
    public string _job_Title;
    public string _company_name;
    public int _startYear;
    public int _endYear;

    public void print_job()
    {
        Console.WriteLine($"{_job_Title} ({_company_name}) {_startYear}-{_endYear}");
    }
}