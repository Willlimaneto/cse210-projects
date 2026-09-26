using System.Collections.Generic;
public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public Video(string _videoTitle, string _videoAuthor, int _videoLength) {
        _comments = new List<Comment>();
        _title = _videoTitle;
        _author = _videoAuthor;
        _length = _videoLength;
    }

    public int NumberOfComments()
    {
        return _comments.Count;
        
    } 
}