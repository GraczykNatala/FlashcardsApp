using System;
namespace FlashcardsApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        FlashcardSet fcs = new FlashcardSet();
        fcs.createSet();
    }
}