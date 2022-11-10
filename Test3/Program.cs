namespace Test3
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            AssignValues();
        }

        public static void AssignValues()
        {
            var person = new Person();

            Console.WriteLine("Enter person Id");
            person.Id = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter name");
            person.Name = Console.ReadLine();

            Console.WriteLine("Enter adress");
            person.Adress = Console.ReadLine();

            Console.WriteLine("Enter mobile number");
            person.MobileNumber = Console.ReadLine();
            
            Console.WriteLine("Hej {0}");

        }
    }
}