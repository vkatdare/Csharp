using System;

namespace CsharpProj
{
    class Program
    {
        static float n1 = 234, n2 = 345;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Add());
            Console.WriteLine(Subtract());
            Console.WriteLine(Mult());
            Console.WriteLine(Divide());
        }

        private static float Add()
        {
            return n1 + n2;
           
        }

        private static float Subtract()
        {
            var result = n1 - n2;
            return result;
        }

        private static float Mult()
        {

            return n1 * n2;
        }

        private static float Divide()
        {
            var result = n1 / n2;
            return result;
        }
    }

}
