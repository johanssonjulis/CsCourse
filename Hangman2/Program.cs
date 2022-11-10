namespace Hangman;

class Program
{
    static void Main(string[] args)
    {
        //gör en metod och döp till game, kalla på den här för att köra
    }
    
    Random rnd = new Random();
int random = rnd.Next(0, 10);       //döper vår int till random
int attempts = 6;
char[] usedLetters = new char[29];
string guessedLetter = "";


void PrintSecretWord(char[] secretWord)
{
    for (int i = 0; i < secretWord.Length; i++)
    {
        Console.Write($"{secretWord[i]}");
    }
}

void PrintUi(char[] secretWord, string usedLetters, int attemptsLeft)
{
  
    PrintSecretWord(secretWord);
    Console.WriteLine();
    Console.WriteLine($"Used letters: {usedLetters}");
    Console.WriteLine();
    Console.WriteLine($"Attempts left: {attemptsLeft}");
}

char ReadLetter(string message)
{
    Console.Write(message);
    var input = Console.ReadLine();
    return string.IsNullOrEmpty(input)
        ? input[0]
        : default;
}
}