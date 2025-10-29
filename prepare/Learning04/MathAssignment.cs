class MathAssignment : Assignment
{
    private String _textbookSection;
    private String _problems;

    public MathAssignment(String name, String topic, String textbookSection, String problems) : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }


    public String GetHomeWorkList()
    {
        return base.GetSummary() + $"\nSection {_textbookSection} Problems {_problems}";
    }
}