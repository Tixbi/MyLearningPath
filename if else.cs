Console.WriteLine("Сколько стоит машина?");
string input = Console.ReadLine();
int dollars = int.Parse(input);

if(dollars >= 2700)
{
    Console.WriteLine("Денег хватает");
}
else
{
    Console.WriteLine("Денег не хватает");
}
