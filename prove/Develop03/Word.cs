class Word
{
    private String _word;

    public Word(String word)
    {
        _word = word;
    }

    public void HideWord()
    {
        _word = new string('_', _word.Length);
    }

    public void Display()
    {
        Console.WriteLine(_word);
    }

    public void SetWord(String word)
    {
        _word = word;
    }

    public String GetWord()
    {
        return _word;
    }
}