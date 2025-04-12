using System;

public class Video
{
    public string _title;
    public string _autor;
    public int _duration;
    public List<Comment> _comments = new List<Comment>();
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
      
    }
    public void DisplayAll()
    {
        Console.WriteLine($"\nTitle: {_title} \nAutor: {_autor}\nDuration: {_duration} min\nComments ({GetCommentsCount()}):");    

        foreach (Comment comment in _comments)
        {
            comment.GetComment();
        }
    }

    public int GetCommentsCount(){
        return _comments.Count();
    }
    

}