namespace _04.OnlineRadioDatabase.Exceptions
{
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
}