
namespace proba
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Func<int, int, int> sum = Sum;

            Console.WriteLine(Sum(12, 18));
        }
        static int Sum(int x, int y) => x + y;

        static int AlternativeSum(int x, int y)
        {
            return x + y;
        }
    }
}

    
