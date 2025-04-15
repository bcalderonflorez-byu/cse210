using System;

class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentname, string topic){
        _studentName = studentname;
        _topic = topic;
    }
    
    public string GetSummary(){
        return $"\n{_studentName} - {_topic}";
    }

    public string GetStudentName(){
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }
}