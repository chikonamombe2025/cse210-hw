using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(List<string> prompts, List<string> questions)
        : base("Reflecting Activity", "This activity helps you reflect on personal experiences.", 60)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        // Logic to get a random prompt from _prompts
        return _prompts[new Random().Next(_prompts.Count)];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }

    public void DisplayQuestions()
    {
        foreach (var question in _questions)
        {
            Console.WriteLine(question);
            // Logic to get user's response
        }
    }
}
