
Console.Write("Temperature: ");

int temperture = int.Parse(Console.ReadLine() ?? "0");

if (temperture >= 20)

{
    Console.WriteLine("warm");

}
else
{
    Console.WriteLine("cool");

}