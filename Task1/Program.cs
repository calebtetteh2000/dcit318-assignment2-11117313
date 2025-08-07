using System;

class Animal
{
    public virtual void makeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}
class Dog : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Bark");
    }
}
class Cat : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal genericAnimal = new Animal();
        genericAnimal.makeSound();
        Animal dog = new Dog();
        dog.makeSound();
        Animal cat = new Cat();
        cat.makeSound();

    }
}