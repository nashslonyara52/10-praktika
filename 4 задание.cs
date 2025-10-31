using System;

namespace pip
{
    public class Point
    {
        private double x;
        private double y;


        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }


        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(double value) : this(value, value)
        {
        }

        public Point() : this(0, 0)
        {
        }


        public void Show()
        {
            Console.WriteLine($"Точка: ({X}, {Y})");
        }
    }

    class Program
    {
        static void Main()
        {

            Point point1 = new Point(3.5, 7.2);
            Point point2 = new Point(5);
            Point point3 = new Point();

            point1.Show();
            point2.Show();
            point3.Show();

            Console.ReadLine();
        }
    }
}