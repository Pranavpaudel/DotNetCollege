public class StudentProfile
{
    static void Main(string[] args)
    {
        string fullName = "Pranav PAudel";
        int age = 21;
        string collegeName = "Informatics College";
        string course = "BSc CSIT";
        int semester = 3;
        string email = "pranav@example.com";
        string phoneNumber = "9898989898";

        string favouriteLanguage = "C#";
        string favouriteTechnology = ".NET";
        string quote = "Keep learning, keep building!";

        Console.WriteLine("================================");
        Console.WriteLine("       STUDENT PROFILE");
        Console.WriteLine("================================");
        Console.WriteLine();
        Console.WriteLine("Name : " + fullName);
        Console.WriteLine("Age : " + age);
        Console.WriteLine("College : " + collegeName);
        Console.WriteLine("Course : " + course);
        Console.WriteLine("Semester : " + semester);
        Console.WriteLine("Email : " + email);
        Console.WriteLine("Phone : " + phoneNumber);
        Console.WriteLine();
        Console.WriteLine("Favourite Language : " + favouriteLanguage);
        Console.WriteLine("Favourite Technology: " + favouriteTechnology);
        Console.WriteLine();
        Console.WriteLine("Quote: \"" + quote + "\"");
        Console.WriteLine("================================");
    }
}
