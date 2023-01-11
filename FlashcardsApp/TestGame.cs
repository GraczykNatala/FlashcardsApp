namespace FlashcardsApp;

public class TestGame : Game
{
    public override void RunGame(List<Flashcard> n)
    {
        bool streak = true;
        do
        {
            Flashcard question = CurrentQuestion(n);
            string definition = question.Text;
            string answer = question.Meaning;
            Console.WriteLine(definition);
            List<string> answers = new List<string>();
            answers.Add(answer);
            do
            {
                Flashcard fakeAnswer = n[Rand.Next(n.Count)];
                if (!answers.Contains(fakeAnswer.Meaning))
                {
                    answers.Add(fakeAnswer.Meaning);
                }
            } while (answers.Count <= 3);

            //* sprawdzić czy shuffle działa poprawnie
             answers.OrderBy(item => Rand.Next());
             int answerNum = answers.IndexOf(answer) ;
            
             for (int j = 1; j < answers.Count()+1; j++) {
                 Console.WriteLine(j + "-" + answers[j-1] + "   ");
             }

             string usersAnswerString = Console.ReadLine();
             int usersAnswer = int.Parse(usersAnswerString);
             
             streak = CheckAnswer(usersAnswer.ToString(), (answerNum + 1).ToString(), streak);
        } while (streak);
    }
    
    
}