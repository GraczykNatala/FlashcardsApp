namespace FlashcardsApp;
public class AnagramGame : Game

{
    public override void RunGame(List<Flashcard> n)
    {
        bool streak = true;
        do
        {
            Flashcard question = CurrentQuestion(n);
            string definition = question.Text;
            List<char> anagram = definition.ToList();
            anagram = anagram.OrderBy(x => Rand.Next()).ToList();
            for (int i = 0; i < anagram.Count; i++)
            {
                Console.Write(anagram[i]);
            }
            Console.WriteLine();

            string usersAnswer = Console.ReadLine();
            streak = CheckAnswer(usersAnswer, definition, streak);
        }
        while(streak);
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