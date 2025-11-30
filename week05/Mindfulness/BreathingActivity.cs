public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity", "This activity will help you relax and focus on your breathing.", 60)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        // Implement additional logic specific to breathing activity
        DisplayEndingMessage();
    }
}
