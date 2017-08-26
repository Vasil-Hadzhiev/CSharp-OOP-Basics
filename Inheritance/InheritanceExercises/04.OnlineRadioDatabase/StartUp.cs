namespace _04.OnlineRadioDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var playlist = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                var songInfo = Console.ReadLine().Split(';');

                var artistName = songInfo[0];
                var songName = songInfo[1];

                try
                {
                    var songLength = songInfo[2]
                        .Split(':')
                        .Select(int.Parse)
                        .ToArray();

                    var minutes = songLength[0];
                    var seconds = songLength[1];

                    var song = new Song(artistName, songName, minutes, seconds);
                    playlist.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid song length.");
                }
            }

            var totalMinutes = playlist.Sum(m => m.Minutes);
            var totalSecond = playlist.Sum(s => s.Seconds);

            totalSecond += totalMinutes * 60;
            var finalMinutes = totalSecond / 60;
            var finalSecond = totalSecond % 60;
            var finalHours = finalMinutes / 60;
            finalMinutes %= 60;

            Console.WriteLine($"Songs added: {playlist.Count}");

            Console.WriteLine($"Playlist length: {finalHours}h {finalMinutes}m {finalSecond}s");
        }
    }
}