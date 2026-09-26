using System;
using System.Collections.Generic;
class Program
{
static void Main(string[] args)
{

Video video1 = new Video("Jude best moments", "Makarov", 560);

    Comment comment1 = new Comment("Great video!", "Anderson");
    Comment comment2 = new Comment("I really enjoyed this!", "John");
    Comment comment3 = new Comment("Jude is an amazing player.", "Michael");

    video1._comments.Add(comment1);
    video1._comments.Add(comment2);
    video1._comments.Add(comment3);


    Video video2 = new Video("Real Madrid Best Goals", "Football Channel", 720);

    Comment comment4 = new Comment("Those goals were incredible!", "David");
    Comment comment5 = new Comment("I love Real Madrid.", "Carlos");
    Comment comment6 = new Comment("Great compilation!", "James");

    video2._comments.Add(comment4);
    video2._comments.Add(comment5);
    video2._comments.Add(comment6);


    Video video3 = new Video("Top Anime Recommendations", "Anime World", 900);

    Comment comment7 = new Comment("These recommendations are great.", "Sofia");
    Comment comment8 = new Comment("I will definitely watch these.", "Daniel");
    Comment comment9 = new Comment("Thanks for the recommendations!", "Emily");

    video3._comments.Add(comment7);
    video3._comments.Add(comment8);
    video3._comments.Add(comment9);


    List<Video> videos = new List<Video>();

    videos.Add(video1);
    videos.Add(video2);
    videos.Add(video3);


    foreach (Video video in videos)
    {
        Console.WriteLine($"Title: {video._title}");
        Console.WriteLine($"Author: {video._author}");
        Console.WriteLine($"Length: {video._length} seconds");
        Console.WriteLine($"Number of comments: {video.NumberOfComments()}");

        Console.WriteLine("Comments:");

        foreach (Comment comment in video._comments)
        {
            Console.WriteLine($"- {comment._authorComment}: {comment._textComment}");
        }

        Console.WriteLine();
    }
}
}
