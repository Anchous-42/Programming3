namespace Programming3
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; } // Продолжительность в секундах
        public string Genre { get; set; }

        public Song(string title, string artist, int duration, string genre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Genre = genre;
        }

        public Song()
        {
            Title = "Неизвестно";
            Artist = "Неизвестно";
            Duration = 180;
            Genre = "Неизвестно";
        }
    }
}