namespace D161
{
    using System;

    public class Rectangle
    {
        private double width;
        private double length;

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public void Print()
        {
            Console.WriteLine($"Rectangle: width = {width}, length = {length}");
        }

        public double Area()
        {
            return width * length;
        }

        public double GetWidth()
        {
            return width;
        }

        public double GetLength()
        {
            return length;
        }

        public void SetWidth(double newWidth)
        {
            width = newWidth;
        }

        public void SetLength(double newLength)
        {
            length = newLength;
        }

        // C# 3.0+ properties
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }
    }

    public class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void Print()
        {
            Console.WriteLine($"Circle: radius = {radius}");
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        // C# 3.0+ properties
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(1.3, 4.2);
            r.Print();
            Console.WriteLine(r.Area());
            Console.WriteLine(r.GetWidth());
            r.SetWidth(2.0);
            Console.WriteLine(r.GetWidth());

            Circle c = new Circle(1.5);
            c.Print();
            Console.WriteLine(c.Area());
        }
    }
}