class Entry
{
    public DateOnly _date;

    public String _userEntry;
    public String _entryName;
    public String _prompt;

    public void Display()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_entryName}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_userEntry}");
    }
}