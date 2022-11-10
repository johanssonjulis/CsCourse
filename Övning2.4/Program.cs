Console.WriteLine("Skriv ett tal här: ");
int tal1 = int.Parse(Console.ReadLine());
Console.WriteLine("Skriv ytterligare ett tal: ");
int tal2 = int.Parse(Console.ReadLine());

// $ = interpolation
Console.WriteLine($"Summan av dina tal är:{tal1+tal2}");
Console.WriteLine($"Produkten av dina tal är:{tal1*tal2}");