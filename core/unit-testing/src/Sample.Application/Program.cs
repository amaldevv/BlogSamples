
using static System.Console;
namespace Sample.Application
{
    public class Utils
    {
        public int Sum(int a, int b) => a+b;
        

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var utilsObj = new Utils();
            WriteLine($"Sum of 1 and 5 is {utilsObj.Sum(1,5)}");
        }
    }
}
