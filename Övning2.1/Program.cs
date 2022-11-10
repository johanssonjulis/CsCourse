/*int [] numbers = new int[5];

numbers[0] = 4;
numbers[1] = 8;
numbers[2] = 15;
numbers[3] = 16;
numbers[4] = 23;
//numbers[5] = 42;

//Console.WriteLine(numbers[1]);
Console.WriteLine(numbers.Length);
Console.ReadLine();
*/

//int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

string [] names = new string[] {"martin", "julia", "olof"};

    
/*
for (int i = 0; i < names.Length; i++)
    {
        Console.WriteLine(names[i]);
    }
    Console.ReadLine();
    */

/* foreach (string name in names)
{
    Console.WriteLine(name);
    
}
Console.ReadLine();
*/

string zig = "jag heter julia" + "vad heter du?";
char [] charArray = zig.ToCharArray();
Array.Reverse(charArray);

foreach (char zigChar in charArray)
{
    Console.Write(zigChar);
    
}
Console.ReadLine();