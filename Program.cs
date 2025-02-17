
namespace proba
{
    internal class Program
    {
        public delegate void Mydelegate(string msg);
        static void Main(string[] args)
        {
            Mydelegate del = MethodA;
            del("Hello World!");

            
        }

        private static void MethodA(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
