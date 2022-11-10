/* skriv in ålder på flera personer
 fråga först om en ålder - skriva ny ålder? j/n
 loopa fram tills anv. skriver in nej
 skriv ut alla åldrar anv. skrev in
 upp till 100 åldrar - "programmet har inte plats för fler åldrar"
 */
 

int[] ålder = new int[100];
bool j = true;

    while (j)
    {
        Console.WriteLine("Skriv in en ålder på en person:");
        //int ålderInput = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < ålder.Length; i++)
        {
            Console.WriteLine(ålder[i]);
            ålder[i] = int.Parse(Console.ReadLine());

            
        Console.WriteLine("Vill du skriva in en ålder till? j/n.");
        string svar = Console.ReadLine();

        if (svar == "n")
        {
            j = false;
        }
    }
}

