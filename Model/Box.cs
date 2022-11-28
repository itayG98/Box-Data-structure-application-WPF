using Data_Structures;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Box : IComparable, IFormattable
    {
        private int _count = 0;
        private double _height;
        private double _width;
        private DateTime _date;
        QueueNode<Box> _node;

        [Range(0, double.MaxValue)]
        public double Height { get { return _height; } set { _height = value; } }
        [Range(0, double.MaxValue)]
        public double Width { get { return _width; } set { _width = value; } }
        [Range(0, int.MaxValue)]
        public int Count { get { return _count; } set { _count = value; } }
        public DateTime Date { get => _date; set => _date = value; }
        public int LastPurchased => (DateTime.Now - Date).Days;

        public QueueNode<Box> Node { get => _node; set => _node = value; }
        public Box(double width, double height, int count, DateTime date)
        {
            if (width <= 0)
                width = 1;
            if (height <= 0)
                height = 1;
            _width = width;
            _height = height;
            Count = count;
            Date = date;
        }
        public Box(double width, double height, int count) : this(width, height, count, DateTime.Now)
        {
        }

        public override string ToString()
        {
            return $"Width : {Width:f2} Height : {Height:f2} Count :{Count}";
        }
        public string ToString(string format, IFormatProvider formatProvider)
        {
            switch (format)
            {
                case "dim":
                    return $"Width - {Width} Height - {Height}.";
                case "long":
                    return $"Width {Width:f2} Height {Height:f2} Count = {Count} Last purhesed {Date}";
                default:
                    return ToString();
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is Box other)
                return Height == other.Height && Width == other.Width;
            return false;
        }

        public int CompareTo(object obj)
        {
            if (obj is Box other)
                return Date.CompareTo(other.Date);
            return default;
        }

    }
}