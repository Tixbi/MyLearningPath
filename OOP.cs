Human me = new Human();
IFruits banana = new Banana();
banana.Eat();
me.Feed(banana);

IFruits apple = new Apple();
apple.Eat();
me.Feed(apple);

interface IFruits
{
    public string Name {get;}
    public void Eat();
}
class Banana : IFruits
{
    public string Name => "Banana";
    public void Eat() => Console.WriteLine("Nam Nam Nam");
}
class Apple : IFruits
{
    public string Name => "Apple";
    public void Eat() => Console.WriteLine("Nam");
}

class Human
{
    public void Feed(IFruits fruits)
    {
        Console.WriteLine($"Human Eat {fruits.Name}");
        fruits.Eat();
    }
}
