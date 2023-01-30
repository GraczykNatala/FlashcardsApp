// See https://aka.ms/new-console-template for more information

using FlashcardsApp;
using System.Xml.Serialization;
using System.IO;

List<FlashcardSet> flashcardSets = new List<FlashcardSet>();

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
        Console.WriteLine("Wybierz zestaw po numerze");
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
        Console.WriteLine( i + ". " + flashcardSets[i].Name);
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
