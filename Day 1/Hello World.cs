namespace syntax
{
    class myFirstCde
    {
        public static void Main(string[] args) // This is the main function
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine(5 + 7);
            /*
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name); // My name is Kevin
            */

            Console.Write("Hello\nworld!\n");
            Console.WriteLine('H' + 'e' + 'l' + 'l' + 'o');

            bool stat = default;
            if (stat == true)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}