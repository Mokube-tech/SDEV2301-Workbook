// Console.Write("Enter the teamsize between 9 and 15: ");


// int teamSize = int.Parse(Console.ReadLine() ?? "");

// while (teamSize < 9 || teamSize > 15)

// {
//     Console.WriteLine("Invalid value try again");

//     teamSize = int.Parse(Console.ReadLine() ?? "");
// }
int teamSize;
do
{
    Console.Write("Enter the teamsize between 9 and 15: ");
    teamSize = int.Parse(Console.ReadLine() ?? "");
    if (teamSize < 9 || teamSize > 15)
    {
        Console.WriteLine("Invalid value. don't do it try again");
    }

} while (teamSize < 9 || teamSize > 15);