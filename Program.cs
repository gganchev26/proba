
namespace proba
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Func<string, string, string> sum = Sum;

            Console.WriteLine(Sum("Hello ", "World"));
        }
        static string Sum(string x, string y) => x + y;

        static string AlternativeSum(string x, string y)
        {
            return x + y;
        }

        private static void MethodA(string msg)
        {
            
        }


    }
}

    
