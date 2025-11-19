using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

       var reference = new Reference("John", 3, new List<int> { 16 });
        var scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son");

        while (true)
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress enter to hide a word or type 'quit' to exit:");

            var input = Console.ReadLine();
            if (input?.ToLower() == "quit")
                break;

            if (!scripture.HideRandomWord())
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nAll words are now hidden. Exiting...");
                break;
            }
        }
    }
}
