using System;

abstract class Animal
{
    protected string name;
    protected string color;

    public Animal(string name, string color)
    {
        this.name = name;
        this.color = color;
    }

    abstract public void Sleep();
}

class Dog : Animal
{
    protected string breed;

    public Dog (string name, string color , string breed) : base(name, color)
    {
        this.breed = breed;
    } 

    public override void Sleep()
    {
        Console.WriteLine($"{name} the {color} dog of breed {breed} is sleeping.");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog("Buddy", "brown", "Labrador");
        myDog.Sleep();
    }
}
