class Entry
{
    public DateOnly _date;

    public String _userEntry;
    public String _entryName;
    public String _prompt;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Name: {_entryName}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"{_userEntry}");
    }
}