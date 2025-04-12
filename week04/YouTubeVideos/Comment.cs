using System;
using System.Reflection;

public class Comment
{
    public string _customername;
    public string _commenttext;   

    public void SetCustomerName(string customername)
    {
        _customername = customername;   
    }
    public void SetComment(string comment)
    {
         _commenttext = comment;
    }
    public void GetCustomerName()
    {
        Console.WriteLine($"{_customername}");        
    }
    public void GetComment()
    {
        Console.WriteLine($"{_customername} \n{_commenttext}");        
    }
}