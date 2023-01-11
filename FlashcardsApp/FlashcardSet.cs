namespace FlashcardsApp;

public class FlashcardSet
{
    public string Name { get; set; }
    public List<Flashcard> ListOfFlashcards { get; set; }

    public FlashcardSet()
    {
    }
    
    public FlashcardSet(string name, List<Flashcard> listOfFlashcards)
    {
        this.Name = name;
        this.ListOfFlashcards = listOfFlashcards;
    }

     public FlashcardSet createSet()
    {
        Console.WriteLine("Podaj nazwę nowego zestawu");
        string name = Console.ReadLine();
        
        Console.WriteLine("Ile elementów chcesz dodać?");
        string amountString = Console.ReadLine();
        int amount = int.Parse(amountString);
        List<Flashcard> NewList = new List<Flashcard>();
        FlashcardSet NewFcSet = new FlashcardSet(name, NewList);
        Console.WriteLine("Stworzono zestaw: " + name);

        for (int i = 0; i < amount; i++)
        {
            Flashcard fc = new Flashcard();
            NewList.Add(fc.createFlashcard());
        }

        return NewFcSet;
        
    }
}