class Program
    static double GetCups()
    
    Console.Write("Enter the number of Cups: ");
    // cups = double.parse(Console.ReadLine() ?? "");
    while (!double.TryParse(Console.ReadLine(), out cups) || GetCups < 0)
{
    Console.WriteLine("Invalid input, Enter a valid number. ");
    Console.WriteLine("Enter the number of cups: ");

}

return Cups;