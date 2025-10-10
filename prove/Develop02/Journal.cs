using System.Text;

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<string> _prompts = new List<string>();


    public String Prompt()
    {
        Random promptGetter = new();
        int ranIndex = promptGetter.Next(_prompts.Count);
        return _prompts[ranIndex];
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void Save()
    {
        Console.WriteLine("Where would you like to save the file? (journal.csv)");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName, append: true))
        {
            foreach (Entry entry in _entries) {
                outputFile.WriteLine($"{entry._date}|{entry._entryName}|{entry._prompt}|{entry._userEntry}");
            }
    
        }

    }

    public void Load()
    {
        Console.WriteLine("This will clear the current journal, would you like to continue? Y/N");
        String confirm = Console.ReadLine();
        if (confirm == "Y")
        {
            _entries.Clear();
            Console.WriteLine("Where would you like to load the file from? (journal.csv)");
            string fileName = Console.ReadLine();
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                Entry entry = new();
                string[] parts = line.Split("|");
                entry._date = DateOnly.Parse(parts[0]);
                entry._entryName = parts[1];
                entry._prompt = parts[2];
                entry._userEntry = parts[3];
                _entries.Add(entry);
            }
        }
    }

    public void Write()
    {
        Entry entry1 = new();
        entry1._date = DateOnly.FromDateTime(DateTime.Now);
        String prompt1 = Prompt();
        entry1._prompt = prompt1;
        Console.WriteLine(prompt1);
        Console.Write("> ");
        entry1._userEntry = Console.ReadLine();
        Console.WriteLine("What would you like to name your entry? ");
        entry1._entryName = Console.ReadLine();
        _entries.Add(entry1);
    }

}