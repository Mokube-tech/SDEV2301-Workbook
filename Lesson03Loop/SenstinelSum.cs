Console.Write("Enter a number to add to the sum, 0 to quit:");

int Value = int.Parse(Console.ReadLine() ?? "");

int sum = 0;

while (Value != 0)

{
    sum += Value;
    Console.Write("Enter a number to add to the sum, 0 to quit:");

    Value = int.Parse(Console.ReadLine() ?? "");
}

Console.WriteLine($"sum = {sum}");