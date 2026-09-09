
using System.Threading.Tasks.Dataflow; // enables direct access to all static method in the console 
// prompt for age 
// Console.Write("what is your age?  ");
WriteLine("what is your age? ");
int age = int.Parse(ReadLine() ?? "0");
if (age >= 18)
{
    writeLine("Adult");
}