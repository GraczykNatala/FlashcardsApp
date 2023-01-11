using System.Xml.Schema;

namespace FlashcardsApp;

public class TypeTheWordGame : Game
{
    public override void RunGame(List<Flashcard> n)
    {
        bool streak = true;

        do
        {
            Flashcard question = CurrentQuestion(n);
            string definition = question.Text;
            Console.WriteLine(definition);
            string answer = question.Meaning;
            string usersAnswer = Console.ReadLine();
            streak = CheckAnswer(usersAnswer, answer, streak);
        } while (streak);
    }

    public override bool CheckAnswer(string userAnswer, string answer, bool streak)
    {
        return base.CheckAnswer(userAnswer, answer, streak);
    }

    public override Flashcard CurrentQuestion(List<Flashcard> n)
    {
        return base.CurrentQuestion(n);
    }
}