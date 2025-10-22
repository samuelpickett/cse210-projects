using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new();
        string[] lines = File.ReadAllLines("scriptures.csv");
        foreach (string line in lines)
            {
            string[] parts = line.Split("|");
            char[] separators = { ' ', ':', '-' };
            string[] refer = parts[0].Split(separators);
            if (refer.Length < 4)
            {
                Reference reference = new(refer[0], refer[1], int.Parse(refer[2]));
                List<Word> verse = TurnScriptureToList(parts[1].Trim());
                Scripture toAdd = new(reference, verse);
                scriptures.Add(toAdd);

            }
            else
            {
                Reference reference = new(refer[0], refer[1], int.Parse(refer[2]),  int.Parse(refer[3]));
                List<Word> verse = TurnScriptureToList(parts[1].Trim());
                Scripture toAdd = new(reference, verse);
                scriptures.Add(toAdd);
            }
                
            }
        Random random = new();
        int rand = random.Next(0, scriptures.Count);
        Scripture scripture = scriptures[1];

        String quit = "";
        while (quit != "quit")
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            Console.WriteLine(scripture.CheckForWords());
            quit = Console.ReadLine();
            if (!scripture.CheckForWords())
            {
                break;
            }
            scripture.HideRanWord();

            
        }
        
        
        


    }
    public static List<Word> TurnScriptureToList(String scripture)
    {
        String[] scriptureArray = scripture.Split(" ");
        List<string> myList = new List<string>(scriptureArray);
        List<Word> verse = new();
        foreach(String word in myList)
        {
            Word word1 = new(word);
            verse.Add(word1);
        }
        return verse;
    }
}