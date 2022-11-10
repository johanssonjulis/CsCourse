using System.ComponentModel.Design;
    var rnd = new Random();
    var random = rnd.Next(0, 10); //döper vår int till random
    var attempts = 6;
    var usedLetters = new char[29];
    var guessedLetter = "";
    var input = '\0'; //input är null. null är ett värde men skrivs ej ut
    var words = new[]
    {
        "bunny", "rabbit", "monkey", "lingon", "tiger", "goldfish",
        "lion", "marketplace", "minions", "flicka"
    };

    var wordsCharArray = words[random].ToCharArray(); //tar det random valda ordet och lägger det i en ny array
    var secretWord = new char[wordsCharArray.Length]; //secretWord blir det random valda ordet som anv. ska gissa
    //och visas såhär _____
    var guessCount = 0; //räknarvariabel

    for (var i = 0; i < secretWord.Length; i++) secretWord[i] = '_';

while (true)
{
    Console.Clear();
    PrintSecretWord();
    FailedGame();

    for (var i = 0; i < secretWord.Length; i++)
        Console.Write($"{secretWord[i]} ");
    for (var i = 0; i < wordsCharArray.Length; i++)
        Console.Write(wordsCharArray[i]);
    Console.WriteLine();
    Console.Write($"Used letters: ");
    for (int i = 0; i < usedLetters.Length; i++)
    {
        Console.Write($"{usedLetters[i]} ");
    }

    Console.WriteLine();
    Console.WriteLine($"Attempts left: {attempts}");
    Console.Write("Your guess: ");
    guessedLetter = Console.ReadLine().ToLower();
    input = char.Parse(guessedLetter);
    
    CheckGuessedLetters();
    FailedGame();
    void PrintSecretWord()
    {
        for (var i = 0; i < wordsCharArray.Length; i++)
            if (input == wordsCharArray[i]) //kollar om min input är samma som i arrayn
            {
                secretWord[i] = wordsCharArray[i];
            }
    }

    void CheckGuessedLetters()
    {
        if (!usedLetters.Contains(input)) //om input inte finns i used letters så går loopen vidare
        {
            if (wordsCharArray.Contains(input)) //om wordsCharArray innehåller rätt input
            {
                //byts denna ut i secretWord samt skrivs ut i usedLetter-arrayn
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (input == wordsCharArray[i])
                    {
                        secretWord[i] = wordsCharArray[i];
                        Console.Write(secretWord[i]);
                    }
                }

                usedLetters[guessCount] = input;
                guessCount++;
            }
            else
            {
                attempts--;
                usedLetters[guessCount] = input;
                guessCount++;
            }
        }
    }

    void FailedGame()
    {
        if (attempts ==0)
        {
            Console.WriteLine("u lose");
        }
    }

    //if (attempts == 0) Console.WriteLine("U lose!");
}
/* for loop för att kolla om programmet är false: attempts i--
usedLetters behöver skrivas ut, både rätt och fel bokstäver. Undvik dubletter med christoffers kod
göra voids?

*/