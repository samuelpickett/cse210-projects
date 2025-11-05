class BreathingActivity : Activity
{
    public BreathingActivity() :
    base("Welcome to the Breathing Activity\n\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n", "Breathing Activity")
    {
    }

    private void BreathIn(int breatheDuration)
    {
        DateTime end = DateTime.Now.AddSeconds(breatheDuration);
        int i = breatheDuration;
        Console.Write("Breathe in...");
        while (DateTime.Now < end)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            int digitCount = i.ToString().Length;
            string backspace = new string('\b', digitCount);
            string space = new string(' ', digitCount);
            Console.Write(backspace + space + backspace);
            i--;
        }
        Console.WriteLine();
    }
    
    private void BreathOut(int breatheDuration)
    {
        DateTime end = DateTime.Now.AddSeconds(breatheDuration);
        int i = breatheDuration;
        Console.Write("Now breathe out..");
        while (DateTime.Now < end)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            int digitCount = i.ToString().Length;
            string backspace = new string('\b', digitCount);
            string space = new string(' ', digitCount);
            Console.Write(backspace + space + backspace);
            i--;
        }
        Console.WriteLine();
    }

    public void UseBreathingActivity()
    {
        base.DisplayWelcome();
        Console.Write("How long would you like the breathe in to last? (It is not recommended to go over 6, but you do you.) ");
        int breatheIn = int.Parse(Console.ReadLine());
        Console.Write("How long would you like the breathe out to last? (It is not recommended to go over 11, but you do you.) ");
        int breatheOut = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine();
        DateTime end = DateTime.Now.AddSeconds(base.GetTimer());
        while (DateTime.Now < end)
        {
            BreathIn(breatheIn);
            BreathOut(breatheOut);
            Console.WriteLine();
        }
        base.DisplayEnd();
    }
}