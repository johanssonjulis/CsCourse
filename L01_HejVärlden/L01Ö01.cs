
// parse är den som konventerar string -> int, det behövs för att göra matematiska uträkning--
// -- så om du skriver 2+3 i en string så kommer outputen bli 23

Console.WriteLine("Skriv ett tal här: ");
int tal1 = int.Parse(Console.ReadLine());
Console.WriteLine("Skriv ytterligare ett tal: ");
int tal2 = int.Parse(Console.ReadLine());

// $ = interpolation
Console.WriteLine($"Summan av dina tal är:{tal1+tal2}");
Console.WriteLine($"Produkten av dina tal är:{tal1*tal2}");

