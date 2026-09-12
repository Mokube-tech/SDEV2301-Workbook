// Generate two random numbers between 1 and 9

Random random = new();

int a = random.Next(1, 10);

int b = random.Next(1, 10);

// swap the two numbers if its resukt in a negative substraction result

if (a < b)

{
    // swap using turples

    (a, b) = (b, a);

}

// Determine the correct answer
int correctAnswer = a - b;

Console.Write($"what is {a} - {b} = ?");

int userAnswer = int.Parse(Console.ReadLine() ?? "");

// print correct or display the correct answer

// if (userAnswer == correctAnswer)
// { Console.WriteLine("correct"); }
// else{ Console.WriteLine($"{userAnswer} is incorrect, correct answer is {correctAnswer}");}

while (answer != correctAnswer)

{
    Console.WriteLine($"incorrect");
    Console.Write($"what is {a} - {b} = ?"); // asking the user to reenter there input again 

    userAnswer = int.Parse(Console.ReadLine() ?? "")
}

Console.WriteLine("correct");