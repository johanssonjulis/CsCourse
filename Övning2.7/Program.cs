Console.WriteLine("Skriv in lite text");
string text = Console.ReadLine();

char tecken = 'a';
// Vi förutsätter att texten inte innehåller ett litet a tills vi hittar ett
bool textInnehållerA = false;

for (int i = 0; i < text.Length; i++)
{
    if (text[i] == tecken)
    {
        textInnehållerA = true;
    }
}

// Om texten innehåller minst ett 'a' så är variabeln true
if (textInnehållerA)
{
    Console.WriteLine("Din text innehåller minst ett 'a'");
}
else
{
    Console.WriteLine("Din text innehåller INTE något 'a'");
}