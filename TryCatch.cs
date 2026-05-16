Console.WriteLine("Введите Число От 0-4");
try
{
    string str = Console.ReadLine();
    int number = int.Parse(str);
    if(number >= 0 && number <= 4)
    {
        Console.WriteLine("Ввел Число От 0-4");
    }
    else
    {
        Console.WriteLine("Не Ввел Число От 0-4");
    }
}
catch
{
    Console.WriteLine("Надо Было Написать Числа А Не Буквы");
}
