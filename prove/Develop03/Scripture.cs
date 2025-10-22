class Scripture
{
    private Reference _reference;
    private List<Word> _verse;

    public Scripture(Reference reference, List<Word> verse)
    {
        _reference = reference;
        _verse = verse;
    }

    public void Display()
    {
        _reference.Display();
        foreach (Word word in _verse)
        {
            Console.Write($"{word.GetWord()} ");
        }
    }

    public void HideRanWord()
    {
        Random random = new();
        int loopCounter = 0;
        for (int i = 0; i < 3; i++)
        {
            int ranNumber = random.Next(0, _verse.Count);
            String word = _verse[ranNumber].GetWord();
            if (word.Contains("_"))
            {
                loopCounter++;
                if (loopCounter < 200)
                {
                    i--;
                    continue;
                }
                else
                {
                    break;
                }
            }
            _verse[ranNumber].HideWord();
        }
    }

    public bool CheckForWords()
    {
        bool areWords = false;
        foreach (Word word in _verse)
        {
            String wordString = word.GetWord();
            if (!wordString.Contains("_"))
            {
                areWords = true;
            }
        }
        return areWords;
    }
}