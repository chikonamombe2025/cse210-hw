using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(int count, List<string> prompts)
        : base("Listing Activity", "This activity encourages you to list things.", 60)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        GetListFromUser();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        // Logic to get a random prompt from _prompts
        return _prompts[new Random().Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        // Logic to prompt user and collect responses
        return new List<string>(); // Replace with actual input collection
    }
}
