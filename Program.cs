
namespace proba
{
    internal class Program
    {
        public delegate TResult Myfunc<TInput, TResult>(TInput input);
        public static void Main(string[] args)
        {
            //Delegate with lamba expression string as input and int as output
             
            Myfunc<string, int> stringToInt = input => input.Length;

            string str = "Hello, world!";
            int result = stringToInt(str);

            Console.WriteLine($"Length of '{str}' is {result}");
        }

        private static void MethodA(string msg)
        {
            
        }


    }
}

    
