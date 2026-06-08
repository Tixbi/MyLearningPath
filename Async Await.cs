await PrintAsync();

async Task PrintAsync()
{
    Console.WriteLine("Go");
    await Task.Delay(2000);
    Console.WriteLine("End");
}
