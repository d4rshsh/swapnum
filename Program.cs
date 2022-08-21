namespace aug17product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Problem 12 - String check");
            string name = String.Empty;
            Console.WriteLine("Enter text");
            name = Console.ReadLine();
            int p = Int32.Parse(name);
            if (!String.IsNullOrEmpty(name))
            {
                Console.WriteLine("string is {0}", p);
            }
            else
            {
                Console.WriteLine("may be null or number");
            }
            Console.ReadLine();
        }
    }
}