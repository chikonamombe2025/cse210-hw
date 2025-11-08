using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        
        // Prompt the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string userInput = Console.ReadLine();
        
        // Convert the input to an integer
        int gradePercentage = int.Parse(userInput);
        
        // Variable to hold the letter grade
        string letter = "";
        
        // Determine the letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        // Check if the user passed
        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Congratulations! You passed with a grade of {letter}.");
        }
        else
        {
            Console.WriteLine($"Unfortunately, you did not pass. Your grade is {letter}. Keep trying!");
        }
        
        // Logic for adding "+" or "-" to the letter grade
        string sign = "";
        int lastDigit = gradePercentage % 10;

        if (letter == "A")
        {
            sign = ""; // No A+ grades
        }
        else if (letter == "F")
        {
            sign = ""; // No F+ or F- grades
        }
        else if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Final output of the letter grade with sign
        if (letter != "F" && letter != "A")
        {
            Console.WriteLine($"Your final grade is {letter}{sign}.");
        }
        else
        {
            Console.WriteLine($"Your final grade is {letter}.");
        }
    }
}
