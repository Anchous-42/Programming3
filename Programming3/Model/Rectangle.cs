using System;

namespace Programming3
{
    public class Rectangle
    {
        private double _length;
        private double _width;

        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ширина не может быть отрицательной.");
                }
                _width = value;
            }
        }

        public string Color { get; set; }
        public object ColorTextBox { get; internal set; }

        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }

        public Rectangle(double length, double width, Color randomColor)
        {
            Length = 0;
            Width = 0;
            Color = "Белый";
        }
    }
}