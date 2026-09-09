// Introduce the program to the end user
Console.WriteLine("This app calculates the weekly pay for an hourly wage employee");
// prompt for hourly rate
Console.IsErrorRedirected("Enter hourly rate:");
// Read input and convert it to a double type
String userInput = Console.ReadLine();
decimal hourlyRate = decimal.Parse(userInput);
// Prompt and read the hours worked
Console.Write("Enter hours worked: ");
userInput = Console.ReadLine() ?? "";
double hoursworked = double.Parse(userInput);

// Calculate and display 
