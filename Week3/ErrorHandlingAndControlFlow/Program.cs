Console.WriteLine("Week 3: Error Handling and Control Flow");
Console.WriteLine("Arithmetic Operations");
int a = 5;
int b = 3;
Console.WriteLine(a +b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(a % b);
Console.WriteLine(5.0/3); 

Console.WriteLine("Assignment Operators");
int score = 50;
score += 10; 
score -= 5;
score *= 2;
Console.WriteLine($"Final score: {score}");


Console.WriteLine("Increment and Decrement Operators");
int x = 5;
Console.WriteLine("Post-increment: " + x++);
Console.WriteLine("Pre-increment: " + ++x);
Console.WriteLine("Post-decrement: " + x--);
Console.WriteLine("Pre-decrement: " + --x);

Console.WriteLine("Relational Operators");
int age = 20;
Console.WriteLine(age > 18 );
Console.WriteLine(age < 18 );
Console.WriteLine(age >= 18 );
Console.WriteLine(age <= 18 );
Console.WriteLine(age == 18 );

Console.WriteLine("Logical Operators");
bool isAdult = age >= 18;
Console.WriteLine("isAdult: " + isAdult);
bool hasLicense = true;
Console.WriteLine("hasLicense: " + hasLicense);


Console.WriteLine("Null Operators");
string? name = null;    
Console.WriteLine(name ?? "Guest");
Console.WriteLine(name?.Length);

name ??= "Ram";


Console.WriteLine("Switch Statement");
int day = 3;
switch (day)            
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}


Console.WriteLine("For Loop");
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Iteration: " + i);
}

Console.WriteLine("While Loop");
int count = 3;
while (count > 0)
{
    Console.WriteLine("While iteration: " + count);
    count--;
}