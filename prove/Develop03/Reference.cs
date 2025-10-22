class Reference
{
    private String _book;
    private String _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(String book, String chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = startVerse;
    }

    public Reference(String book, String chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public void Display()
    {
        if (_startVerse == _endVerse)
        {
            Console.Write($"{_book} {_chapter}:{_startVerse} ");
        }
        if (_startVerse != _endVerse)
        {
            Console.Write($"{_book} {_chapter}:{_startVerse}-{_endVerse} ");
        }
    }

    public String GetBook()
    {
        return _book;
    }
    public String GetChapter()
    {
        return _chapter;
    }

    public int GetStartVerse()
    {
        return _startVerse;
    }
    public int GetEndVerse()
    {
        return _endVerse;
    }

    public void SetBook(String book)
    {
        _book = book;
    }

    public void SetChapter(String chapter)
    {
        _chapter = chapter;
    }

    public void SetStartVerse(int startVerse)
    {
        _startVerse = startVerse;
    }

    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }


}