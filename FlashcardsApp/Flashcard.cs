namespace FlashcardsApp;

public class Flashcard
{
    public string Text { get; set; }
    public string Meaning { get; set; }
    public Flashcard()
    {
    }
    public Flashcard(string text, string meaning)
    {
        this.Text = text;
        this.Meaning = meaning;
    }

    public override string ToString()
    {
        return Text + "-" + Meaning;
    }

    public Flashcard createFlashcard()
    {
        Console.WriteLine("Podaj słowo");
        string text = Console.ReadLine();
        Console.WriteLine("Podaj znaczenie");
        string meaning = Console.ReadLine();
        Flashcard fc = new Flashcard(text, meaning);
        return fc;
    }
    
}