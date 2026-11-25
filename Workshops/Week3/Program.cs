Console.WriteLine("Task 1: Operators");
Operators op = new Operators();
op.Add(10, 5);
op.Subtract(10, 5);
op.Multiply(10, 5);
op.Divide(10, 5);
op.OddEvenFinder(7);
op.OddEvenFinder(8);

Console.WriteLine("Task 2: Null Operations");
NullOperations nullOp = new NullOperations();
nullOp.PerformNullChecks();

Console.WriteLine("Task 3: Age Category");
Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine()!);
if (age < 13)
{
    Console.WriteLine("Child");
}
else if (age <= 19)
{
    Console.WriteLine("Teenager");
}
else
{
    Console.WriteLine("Adult");
}

Console.WriteLine("Task 4: Day of the Week");
Console.Write("Enter a number (1-7): ");
int day = int.Parse(Console.ReadLine()!);
switch (day)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        break;
    case 7:
        Console.WriteLine("Saturday");
        break;
    default:
        Console.WriteLine("Invalid day number");
        break;
}

Console.WriteLine("Task 5: Loops");
Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine()!);
int sum = 0;
for (int i = 1; i <= n; i++)
{
    sum = sum + i;
}
Console.WriteLine("Sum = " + sum);

int count = 1;
while (count <= 20)
{
    if (count == 15)
    {
        break;
    }
    if (count % 4 == 0)
    {
        count++;
        continue;
    }
    Console.WriteLine(count);
    count++;
}

int[] numbers = { 10, 20, 30, 40, 50 };
int total = 0;
foreach (int number in numbers)
{
    total = total + number;
}
Console.WriteLine("Sum of array = " + total);

Console.WriteLine("Task 6: Error Handling");
try
{
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine()!);
    Console.WriteLine("You entered: " + num);
}
catch (FormatException)
{
    Console.WriteLine("Invalid number format");
}
finally
{
    Console.WriteLine("Program Executed");
}

try
{
    Console.Write("Enter a password: ");
    string password = Console.ReadLine()!;
    if (password.Length < 6)
    {
        throw new Exception("Password must be at least 6 characters.");
    }
    else
    {
        Console.WriteLine("Password satisfied the requirement");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

class Operators
{
    public void Add(int a, int b)
    {
        Console.WriteLine("Addition: " + (a + b));
    }

    public void Subtract(int a, int b)
    {
        Console.WriteLine("Subtraction: " + (a - b));
    }

    public void Multiply(int a, int b)
    {
        Console.WriteLine("Multiplication: " + (a * b));
    }

    public void Divide(int a, int b)
    {
        Console.WriteLine("Division: " + (a / b));
    }

    public void OddEvenFinder(int number)
    {
        string result = number % 2 == 0 ? "Even Number" : "Odd Number";
        Console.WriteLine(result);
    }
}

class NullOperations
{
    public void PerformNullChecks()
    {
        string? username = null;

        string result = username == null ? "Username is not available" : username;
        Console.WriteLine(result);

        string result2 = username ?? "Username is not available";
        Console.WriteLine(result2);

        username ??= "Guest";
        Console.WriteLine("Updated username: " + username);
    }
}
