using System;

namespace Programming3
{
    public class Movie
    {
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }

        private int _year;
        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Год выпуска должен быть между 1900 и текущим годом.");
                }
                _year = value;
            }
        }

        public string Genre { get; set; }

        private double _rating;
        public double Rating
        {
            get { return _rating; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Рейтинг должен быть от 0 до 10.");
                }
                _rating = value;
            }
        }

        public Movie(string title, int durationInMinutes, int year, string genre, double rating)
        {
            Title = title;
            DurationInMinutes = durationInMinutes;
            Year = year;
            Genre = genre;
            Rating = rating;
        }

        public Movie()
        {
            Title = "Безымянный";
            DurationInMinutes = 90;
            Year = 2000;
            Genre = "Комедия";
            Rating = 5;
        }
    }
}