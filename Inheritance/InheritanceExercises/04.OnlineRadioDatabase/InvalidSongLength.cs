using System;

public class InvalidSongLength : InvalidSongException
{
    private const string Message = "Invalid song length.";

    public InvalidSongLength()
        : base(Message)
    {

    }

    public InvalidSongLength(string message) 
        : base(message)
    {
    }
}

