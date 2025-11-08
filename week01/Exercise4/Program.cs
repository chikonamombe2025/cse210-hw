using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

             List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Step 2: Collect numbers from the user
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0) // Don't add 0 to the list
            {
                numbers.Add(input);
            }

        } while (input != 0);

        // Step 3: Calculate and display results
        if (numbers.Count > 0)
        {
            // Calculate sum
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            // Calculate average
            double average = (double)sum / numbers.Count;

            // Find maximum
            int max = numbers[0];
            foreach (var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            // Display results
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
