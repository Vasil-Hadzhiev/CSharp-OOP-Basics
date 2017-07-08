using System;

public class InvalidSongMinutesException : InvalidSongLength
{
    private const string Message = "Song minutes should be between 0 and 14.";

    public InvalidSongMinutesException()
        : base(Message)
    {

    }

    public InvalidSongMinutesException(string message) 
        : base(message)
    {
    }
}

