using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness// Example prompts for activities
        List<string> prompts = new List<string> { "What are you grateful for?", "What has been a challenge for you?" };
        List<string> questions = new List<string> { "Why is this important?", "How does this affect you?" };

        // Create activity instances
        BreathingActivity breathingActivity = new BreathingActivity();
        ListingActivity listingActivity = new ListingActivity(5, prompts);
        ReflectingActivity reflectingActivity = new ReflectingActivity(prompts, questions);

        // Run activities
        breathingActivity.Run();
        listingActivity.Run();
        reflectingActivity.Run(); Project.");



        
    }
}
