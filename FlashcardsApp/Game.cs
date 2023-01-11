namespace FlashcardsApp;

public abstract class Game
{
    public Random Rand = new Random();

    public abstract void RunGame(List<Flashcard> n);

    public virtual Boolean CheckAnswer(string userAnswer, string answer, bool streak)
    {
        if (userAnswer.Equals(answer))
        {
            Console.WriteLine("brawo!");
        }
        else
        {
            Console.WriteLine("przegrana :(");
            streak = false;
        }

        return streak;
    }

   public virtual Flashcard CurrentQuestion(List<Flashcard> n)
    {
        Flashcard question = n[Rand.Next(n.Count)];
        string definition = question.Text;
        string answer = question.Meaning;
        return new Flashcard(definition, answer);}
}