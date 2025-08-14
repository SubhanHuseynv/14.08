using work.Utilities.Extensions;

namespace work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = -93;
            string b = "A3bhfh7676";
            Console.WriteLine(a.IsOdd());
            Console.WriteLine(a.IsEven());
            Console.WriteLine(b.HasDigit());
            Console.WriteLine(b.CheckPassword());
            Console.WriteLine("slaldfkm".Capitalize());
            
        }
    }
}

