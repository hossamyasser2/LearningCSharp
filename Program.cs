using System; // This is learning the basics of how any c# program starts
using System.Runtime.CompilerServices; // This is learning the basics of how any c# program starts

class Program // This is learning the basics of how any c# program starts
{
    static void Main(string[] args) // This is learning the basics of how any c# program starts
    {
        Console.WriteLine("Enter your name"); // This is how to get the terminal to show text which i use for the user to input an answer
        string name = Console.ReadLine(); // This is how the program retreives the answer by reading what the user has written
        Console.WriteLine("Enter your age"); 
        int age = Convert.ToInt32(Console.ReadLine()); // I convert the answer to an integer as i am asking for the users age which is a whole nunber
        int nextAge = age + 10; // I add the users inputted age by 10 
        double squareAge = Math.Sqrt(age); // I square root the users age
        double powerAge = Math.Pow(age, 2); // I square the users age

        Console.WriteLine("Hello " + name); // I greet the user with their inputted name
        Console.WriteLine("In 10 years you will be " + nextAge); // I tell them the age + 10 years
        Console.WriteLine("The square root of your age is " + squareAge); // Square root age
        Console.WriteLine("Your age squared is " + powerAge); // Squared age
        Random random = new Random(); // This is how to generate random numbers
        int x = random.Next(0,11); // This is saying to generate a random number from 0,11 0 is included but 11 is not so it will be 0-10
        int answer = x + age; // This is adding the random number to the users age
        Console.WriteLine("I have generated the random number: " + x); // telling the user i have generated a random number
        Console.WriteLine("What is your age + " + x + "?"); // Asking the user a math question
        int userAnswer = Convert.ToInt32(Console.ReadLine()); // Converting the answer to an integer
        if(userAnswer == answer) // This is an if statement to check if the users answer is correct or not
        Console.WriteLine("Correct!");
        else
        Console.WriteLine("Oops, the correct answer is " + answer);
        string firstLetter = name.Substring(0,1); // This is a substring to find the users first letter of their name
        string userName = name.Insert(0, "@"); // This adds an @ symbol to the beggining of the users name
        Console.WriteLine("Your name length is " + name.Length); // This finds the users name length
        Console.WriteLine("First letter of your name is " + firstLetter); // This tells them the first letter
        Console.WriteLine("Your name in full uppercase is " + name.ToUpper()); // This shows them the full name with uppercase letters only
        Console.WriteLine("Your username would be " + userName); // This shows them the potentional username
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}