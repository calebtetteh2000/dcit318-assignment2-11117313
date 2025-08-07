using System;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.Move();
        Bicycle bicycle = new Bicycle();
        bicycle.Move();
    }

    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The car is moving.");
        }
    }
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The bicycle is moving.");
        }
    }
}