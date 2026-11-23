Console.WriteLine("Week 3 Tutorial");
Console.WriteLine("Arithmetic Operators");
int a =5;
int b =3;
Console.WriteLine(a+b);
Console.WriteLine(a-b);
Console.WriteLine(a*b);
Console.WriteLine(a/b);
Console.WriteLine(a % b);
Console.WriteLine(5.0/3);

Console.WriteLine("Assignment Operators");
int score = 50;
score += 10; //score = score +10;
score -=5;
score *=2;
Console.WriteLine("The score is " + score);

Console.WriteLine("Increment and Decrement Operators");
int x =5;
Console.WriteLine("Post increment", x++);
Console.WriteLine("Preincrement",++x);

Console.WriteLine("Relational Operators");
int age = 17;
Console.WriteLine(age ==20);
Console.WriteLine(age !=18);
Console.WriteLine(age>=18);
Console.WriteLine(age <18);

Console.WriteLine("Logical Operators");

int userAge = 30;
bool hasId =true;
Console.WriteLine(userAge >=18 && hasId);
Console.WriteLine(userAge < 18 || hasId);
Console.WriteLine(!hasId);


Console.WriteLine("Ternary Operators");
int marks = 40;
string result = marks >=40 ? "Pass" : "Fail";
Console.WriteLine(result);


Console.WriteLine("Null Operators");
string? name = null;
Console.WriteLine(name ?? "Guest");
Console.WriteLine(name?.Length);

name ??= "Ram";
Console.WriteLine(name);

Console.WriteLine("Operator precedence");
Console.WriteLine(2 + 3 * 4);
Console.WriteLine((2 + 3) * 4);

Console.WriteLine("Control Flow");
int smarks = 60;
if (smarks > 80)
{
Console.WriteLine("distinction");
}
else if (smarks > 40)
{
Console.WriteLine("Pass");
}
else
{
Console.WriteLine("Fail");
}


Console.WriteLine("switch statements");
int day = 2;
switch (day){
case 1:
Console.WriteLine("Sunday");
break;
case 2:
Console.WriteLine("Monday");
break;
case 3:
Console.WriteLine("Tuesday");
break;
default:
Console.WriteLine("Invalid day");
break;
}

Console.WriteLine("For loop");
for(int i =1; i<=5; i++)
{
Console.WriteLine(i);
}
Console.WriteLine("While loop");
int count = 3;
while (count > 0){
Console.WriteLine(count);
count--;
}

Console.WriteLine("Do While loop");
int n = 10;
do{
Console.WriteLine(n);
n++;
} while (n < 5);


string[] fruits = { "Apple", "Banana", "Mango" };
foreach (string fruit in fruits){
Console.WriteLine(fruit);
}

for (int i = 1; i <= 10; i++){
if (i == 3){
continue;
}
if (i == 6){
break;
}
Console.WriteLine(i);
}


Console.WriteLine("Error Handling");
/* Exception When it happens
FormatException text cannot be converted, e.g. int.Parse("abc")
DivideByZeroException an int is divided by 0
IndexOutOfRangeException using an array index that does not exist
NullReferenceException using an object that is null
OverflowException number is too big for the type
ArgumentException a method gets a wrong argument */

try
{
int number = int.Parse("1");
Console.WriteLine(number);
}
catch ( FormatException)
{
Console.WriteLine("Format exeption occured");
}
finally
{
Console.WriteLine("End of program");
}

Console.WriteLine("Application Development");