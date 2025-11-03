class BreathingActivity : Activity
{
    public BreathingActivity() :
    base("Welcome to the Breathing Activity\n\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n")
    {
    }

    private void BreathIn()
    {
        DateTime end = DateTime.Now.AddSeconds(4);
        int i = 4;
        Console.Write("Breathe in...");
        while (DateTime.Now < end)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;
        }
        Console.WriteLine();
    }
    
    private void BreathOut()
    {
        DateTime end = DateTime.Now.AddSeconds(6);
        int i = 6;
        Console.Write("Now breathe out..");
        while (DateTime.Now < end)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;
        }
        Console.WriteLine();
    }

    public void UseBreathingActivity()
    {
        base.DisplayWelcome();
        Console.WriteLine();
        Console.WriteLine();
        DateTime end = DateTime.Now.AddSeconds(base.GetTimer());
        while (DateTime.Now < end)
        {
            BreathIn();
            BreathOut();
            Console.WriteLine();
        }
        base.DisplayEnd("Breathing Activity");
    }
}