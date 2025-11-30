public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    // Methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}: {_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {_name}. Thank you!");
    }

    public void ShowSpinner(int seconds)
    {
        // Logic to show spinner
    }

    public void ShowCountDown(int seconds)
    {
        // Logic for countdown
    }
}
