

Console.WriteLine("Hur högt kan du hoppa i höjdhopp mätt i meter?");
string höjdText = Console.ReadLine();           // Här sparar vi höjd i en string
double höjd = double.Parse(höjdText);
double rekord = 2.45;                           // du kan även göra en double skillnad = 2.45 - höjd
Console.WriteLine("Världsrekordet i hoppning är 2.45m. Det är en skillnad på" + (rekord - höjd) + " meter." );

