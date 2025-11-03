class ListingActivity: Activity
{
    List<String> _prompts = new List<String> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    List<String> _entries = new List<String> { };

    public ListingActivity() :
    base("Welcome to the Listing Activity.\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    private void DisplayPrompt()
    {
        Random rand = new();
        int ranNumber = rand.Next(0, _prompts.Count);
        Console.WriteLine("List as many response as you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[ranNumber]} ---");
    }

    private void CountDown()
    {
        DateTime end = DateTime.Now.AddSeconds(4);
        int i = 4;
        Console.Write("You may being in: ");
        while (DateTime.Now < end)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;
        }
        Console.WriteLine();
    }

    private void AddEntries()
    {
        DateTime end = DateTime.Now.AddSeconds(base.GetTimer());
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            _entries.Add(Console.ReadLine());
        }
    }
    public void UseListingActivity()
    {
        base.DisplayWelcome();
        DisplayPrompt();
        CountDown();
        AddEntries();
        Console.WriteLine($"You listed {_entries.Count} items!");
        base.DisplayEnd("Listing Activity");
    }
}