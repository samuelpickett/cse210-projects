class Activity
{
    private string _welcome;

    private int _timer;

    protected Activity(string welcome)
    {
        _welcome = welcome;
    }

    protected int GetTimer()
    {
        return _timer;
    }
    protected void DisplayWelcome()
    {
        Console.Clear();
        Console.WriteLine(_welcome);
        Console.Write("How long, in seconds, would you like for your session to go? ");
        _timer = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner();
    }

    protected void DisplayEnd(String activityDone)
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Spinner();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_timer} seconds of the {activityDone}.");
        Spinner();

    }

    protected void Spinner()
    {
        DateTime end = DateTime.Now.AddSeconds(5);

        while (DateTime.Now < end)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}