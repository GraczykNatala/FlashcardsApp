namespace FlashcardsApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        FlashcardSet fcs = new FlashcardSet();
        List<FlashcardSet> flashcardSets = new List<FlashcardSet>();
        flashcardSets.Add(fcs.createSet());
    }
}