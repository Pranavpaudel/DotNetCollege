using System;

public class Program
{
    /*
    this program contains the
    demo examples of all
    c# basics
    */
    public static void Main()
    {
        // 1. C# fundamentals
        SyntaxBasics();

        // 2. variables and memory
        VariablesandMemory();
    }

    // 1. C# fundamentals
    static void SyntaxBasics()
    {
        // 1. Statements
        int age = 20;
        string name = "Sudip Bhandari";
        Console.WriteLine($"My name is {name} and my age is {age} years old");

        if (age >= 18)
        {
            Console.WriteLine("Your are now adult");
            Console.WriteLine("This statement is inside if block");
        }

        // top level statements
        // Modern C# allows executable code without explicitly writing Main().
        // This file uses Main() because it is useful for teaching multiple sections.
        // A top-level program can simply start with:
        Console.WriteLine("Console.WriteLine(\"Hello C#\");");

        // declare course, semester and full marks and print it
        string course = "Computing";
        int semester = 5;
        int fullMarks = 100;

        Console.WriteLine($"Course: {course}");
        Console.WriteLine($"Semester: {semester}");
        Console.WriteLine($"Full marks: {fullMarks}");
    }

    // 2. variables and memory
    static void VariablesandMemory()
    {
        Console.WriteLine("========================");
        Console.WriteLine("2. Variables and memory");
        Console.WriteLine("========================");

        // variable declaration
        int week;
        // initialize the value of the variable
        week = 2;

        Console.WriteLine($"We are on week: {week}");

        // combining both declaration and initialization
        int score = 80;
        Console.WriteLine($"Total score: {score}");

        /* declare a variable balance and set its value to 1000
           print its initial value and then change the value to 1500
           and also print the updated value */
        decimal balance = 1000m;
        Console.WriteLine($"Initial balance: {balance}");

        // updating the value
        balance = 1500m;
        Console.WriteLine($"Updated balance: {balance}");



        // common datatypes in c#
int studentCount = 30;
long population = 30000000L;
float temperature = 25.5f;
double average = 85.75;
decimal accountBalance = 15000.75m;
char grade = 'A';
bool isStudent = true;
string name = "Anil";

Console.WriteLine($"int: {studentCount}");
Console.WriteLine($"long: {population}");
Console.WriteLine($"float: {temperature}");
Console.WriteLine($"double: {average}");
Console.WriteLine($"decimal: {accountBalance}");
Console.WriteLine($"char: {grade}");
Console.WriteLine($"bool: {isStudent}");
Console.WriteLine($"string: {name}");
    }

    
}