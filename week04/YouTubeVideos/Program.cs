using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> _videos = new List<Video>();
        
        Video _video1 = new Video();
        _video1._title = "Greater Love | Easter 2025";
        _video1._autor = "The Church of Jesus Christ of Latter-day Saints";
        _video1._duration = 2;        
        
        addhardcodecomments(_video1,"@pearl12349","Thanks Jesus Christ for paying for my sins...");
        addhardcodecomments(_video1,"@pukrufus","I love the Jesus you've chosen. He actually looks Jewish for once.");
        addhardcodecomments(_video1,"@TheF1spanish","That’s amazing how our Heavenly Father ,has sent our Saviour,to atone us and give us grace!");

        _videos.Add(_video1);

        Video _video2 = new Video();
        _video2._title = "President Russell M. Nelson 100th Birthday Commemoration";
        _video2._autor = "The Church of Jesus Christ of Latter-day Saints";
        _video2._duration = 60;        
        
        addhardcodecomments(_video2,"@RICHARDWWERT","While I’m not LDS, I wish President Nelson a very Happy 100th Birthday. God Bless You.");
        addhardcodecomments(_video2,"@MaylynnChesonis","Happy 100th  Birthday!!!");
        addhardcodecomments(_video2,"@sharp_as_a_tact2524","Happy birthday President Nelson! And thank you so much for your dedicated service. We love you so much!");
        
        _videos.Add(_video2);

        Video _video3 = new Video();
        _video3._title = "A Beautiful Rendition of I Need Thee Every Hour";
        _video3._autor = "The Church of Jesus Christ of Latter-day Saints";
        _video3._duration = 5;        
        
        addhardcodecomments(_video3,"@marciaparker9751","Absolutely breathtakingly beautiful!!! It's exactly how I feel. Thank you so very much. God bless you always!");
        addhardcodecomments(_video3,"@lifeloverlorijean","So beautiful!  How we need him every hour. At least I do. God bless this talented woman.");
        addhardcodecomments(_video3,"@idahofmegal821","At first I thought it was too slow. But, then I slowed down and realized it was exactly what I needed to hear.");
        addhardcodecomments(_video3,"@mikemcclure656","Just a simple, but heart-felt Thank you, Emma.");
        
        _videos.Add(_video3);

        Console.WriteLine("\nList of Videos:");

        foreach (Video video in _videos)
        {
            video.DisplayAll();
        }

    }

    public static void addhardcodecomments (Video _video,string customername, string comment){
        Comment _Comment = new Comment();
        _Comment.SetCustomerName(customername);
        _Comment.SetComment(comment);        
        _video.AddComment(_Comment);
    }

}