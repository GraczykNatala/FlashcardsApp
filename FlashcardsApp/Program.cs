// See https://aka.ms/new-console-template for more information

using FlashcardsApp;

Console.WriteLine("Hello, World!");
List<FlashcardSet> flashcardSets = new List<FlashcardSet>();
FlashcardSet testFC = new FlashcardSet("test",createExampleSet());
flashcardSets.Add(testFC);
menu();


void menu()
{
    showMenu();
    string choiceString = Console.ReadLine();
    int choice = int.Parse(choiceString);

    if (choice == 1)
    {
        FlashcardSet fcs = new FlashcardSet().createSet();
        flashcardSets.Add(fcs);
        menu();
    }
    else if (choice == 2)
    {
        showAllSets();
        Console.WriteLine("Wybierz zestaw po numerze od 0");
        String chosenSetString = Console.ReadLine();
        int chosenSetNum = int.Parse(chosenSetString);
        FlashcardSet currentSet = flashcardSets[chosenSetNum];
        showGamesMenu();
        String chosenGameString = Console.ReadLine();
        int chosenGame = int.Parse(chosenGameString);

        if (chosenGame == 1)
        {
           new TestGame().RunGame(currentSet.ListOfFlashcards); 
           menu();
        }
        else if (chosenGame == 2)
        {
            new AnagramGame().RunGame(currentSet.ListOfFlashcards); 
            menu();
        }
        else if (chosenGame == 3)
        {
            new TypeTheWordGame().RunGame(currentSet.ListOfFlashcards); 
            menu();
        }
    }
   else if (choice == 3)
    {
    }
}





void showAllSets()
{
    for (int i = 0; i < flashcardSets.Count; i++)
    {
        Console.WriteLine(flashcardSets[i].Name);
    }
}

void showMenu()
{
    Console.WriteLine( Enum.GetName(Menu.Stwórz_nowy_zestaw) + " - 1 ");
    Console.WriteLine( Enum.GetName(Menu.Przeglądaj_zestawy) + " - 2 ");
    Console.WriteLine( Enum.GetName(Menu.Wyjdź) + " - 3 ");
}
void showGamesMenu()
{
    Console.WriteLine( Enum.GetName(GamesMenu.TEST) + " - 1 ");
    Console.WriteLine( Enum.GetName(GamesMenu.ANAGRAM) + " - 2 ");
    Console.WriteLine( Enum.GetName(GamesMenu.WPISYWANIE_POPRAWNEJ_ODPOWIEDZI) + " - 3 ");
}
 List<Flashcard> createExampleSet() {

    Flashcard t1 = new Flashcard("Take off", "Startować");
    Flashcard t2 = new Flashcard("Aisle seat", "Miejsce od środka");
    Flashcard t3 = new Flashcard("Hand luggage", "Bagaż podręczny");
    Flashcard t4 = new Flashcard("Fasten the belt", "zapiąc pasy");
    Flashcard t5 = new Flashcard("Duty-free shop", "sklep bezcłowy");
    Flashcard t6 = new Flashcard("Board the plane", "Wejść na pokład");
    Flashcard t7 = new Flashcard("Gate", "Bramka");
    Flashcard t8 = new Flashcard("Departures board", "Tablica odlotów");
    Flashcard t9 = new Flashcard("Check in", "zameldować się");
    List<Flashcard> testFC = new List<Flashcard>();
    testFC.Add(t1);
    testFC.Add(t2);
    testFC.Add(t3);
    testFC.Add(t4);
    testFC.Add(t5);
    testFC.Add(t6);
    testFC.Add(t7);
    testFC.Add(t8);
    testFC.Add(t9);
    return testFC;
    
 }