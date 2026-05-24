Animal snake = new Snake();
Animal cow = new Cow();

snake.Speak();
cow.Speak();

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("...");
    }
}
class Snake : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Shh");
    }
}
class Cow : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Muuu");
    }
}
