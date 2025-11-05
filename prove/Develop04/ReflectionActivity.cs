using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
class ReflectionActivity : Activity
{
    private List<String> _prompts = new List<String> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    private List<String> _questions = new List<String> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    public ReflectionActivity() : base("Welcome to the Reflection Activity.\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Breathing Activity")
    {

    }

    private void DisplayPrompt()
    {
        Random rand = new();
        int ranNumber = rand.Next(0, _prompts.Count);
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($" --- {_prompts[ranNumber]} ---");
    }

    private void DisplayQuestions()
    {
        List<String> questions = [];
        DateTime end = DateTime.Now.AddSeconds(base.GetTimer());
        while (DateTime.Now < end)
        {
            Random rand = new();
            int ranNumber = rand.Next(0, _questions.Count);
            if (questions.Count == _questions.Count)
            {
                questions.Clear();
            }
            while (questions.Contains(_questions[ranNumber]))
            {
                ranNumber = rand.Next(0, _questions.Count);
            }
            questions.Add(_questions[ranNumber]);
            Console.Write($"> {_questions[ranNumber]} ");
            base.Spinner();
            base.Spinner();
            Console.WriteLine();
        }
        Console.WriteLine();
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
    
    public void UseReflectionActivity()
    {
        base.DisplayWelcome();
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        CountDown();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience. ");
        Console.Clear();
        DisplayQuestions();
        base.DisplayEnd();
    }
}