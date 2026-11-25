using System;

class Program
{
    // Task 2 Constant Requirement: PI constant defined inside the class
    public const double PI = 3.14;

    static void Main()
    {
        // ==========================================
        // TASK 1: Basic Variables & String Interpolation
        // ==========================================
        Console.WriteLine("=== TASK 1 ===");
        string userName = "Alex";
        int luckyNumber = 7;

        Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");
        Console.WriteLine();


        // ==========================================
        // TASK 2: Constants & Circle Calculations
        // ==========================================
        Console.WriteLine("=== TASK 2 ===");
        
        // Attempting to modify PI causes a compilation error:
        // Program.PI = 3.14159; 
        // 
        // Compilation Error Explanation:
        // Error CS0131 / CS0133: Constant fields are immutable and evaluated at 
        // compile-time. Once initialized, their values cannot be reassigned at runtime.

        double radius = 5.0;
        double area = CalculateCircleArea(radius);
        double perimeter = CalculateCirclePerimeter(radius);

        Console.WriteLine($"Circle Constant PI: {PI}");
        Console.WriteLine($"Radius: {radius}");
        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Perimeter: {perimeter}");
        Console.WriteLine();


        // ==========================================
        // TASK 3: Data Types and Type Conversion
        // ==========================================
        Console.WriteLine("=== TASK 3 ===");

        // 1. Declare and initialize variables of primary types
        byte myByte = 255;
        short myShort = 32000;
        int myInt = 42;
        long myLong = 9223372036854775807L;
        float myFloat = 3.14f;
        double myDouble = 3.1415926535;
        decimal myDecimal = 79228162514264337593543950335m;
        char myChar = 'A';
        bool myBool = true;

        // 2. Convert integer 42 to a string
        string intAsString = myInt.ToString();

        // 3. Convert string "3.14" to double
        string doubleString = "3.14";
        double parsedDouble = Convert.ToDouble(doubleString);

        // 4. Output all variables with labels and types
        Console.WriteLine($"[byte]    myByte: {myByte}");
        Console.WriteLine($"[short]   myShort: {myShort}");
        Console.WriteLine($"[int]     myInt: {myInt}");
        Console.WriteLine($"[long]    myLong: {myLong}");
        Console.WriteLine($"[float]   myFloat: {myFloat}");
        Console.WriteLine($"[double]  myDouble: {myDouble}");
        Console.WriteLine($"[decimal] myDecimal: {myDecimal}");
        Console.WriteLine($"[char]    myChar: {myChar}");
        Console.WriteLine($"[bool]    myBool: {myBool}");
        Console.WriteLine($"[string]  intAsString (from int 42): \"{intAsString}\"");
        Console.WriteLine($"[double]  parsedDouble (from string \"3.14\"): {parsedDouble}");
    }

    // Helper methods for Task 2
    public static double CalculateCircleArea(double radius)
    {
        return PI * radius * radius;
    }

   public static double CalculateCirclePerimeter(double radius)
    {
        return 2 * PI * radius;
    }


    
    