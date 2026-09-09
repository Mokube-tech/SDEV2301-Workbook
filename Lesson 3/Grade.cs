int score = 82; string grade;

if (score >= 70) grade = "c";

else if (score >= 80) grade = "B";

else if (score >= 90) grade = "A";

else grade = "F";

// { Console.WriteLine(grade); }

Console.WriteLine($"{score} is args {grade}");

