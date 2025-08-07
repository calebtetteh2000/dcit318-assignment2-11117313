using System;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        circle.radius = 7;
        circle.getArea();

        Rectangle rectangle = new Rectangle();
        rectangle.height = 4;
        rectangle.length = 2;
        rectangle.getArea();
    }

    public abstract class Shape
    {
        public abstract void getArea();
    }

    public class Circle : Shape
    {
        public double radius;
        public override void getArea()
        {
            double area = 3.142 * (radius * radius);
            Console.WriteLine("Area of Circle: " + area);
        }
    }

    public class Rectangle : Shape
    {
        public double height;
        public double length;
        public override void getArea()
        {
            double area = height * length;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }
}