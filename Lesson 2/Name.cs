// 
Console.Write("your name:  ");
string name = Console.ReadLine() ?? "no input";
// print the name using string interpolation 
Console.WriteLine($"Hello, {name}!");