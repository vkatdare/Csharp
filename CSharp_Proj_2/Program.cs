using System;
using CSharp_Proj_2.Classes;

namespace CSharp_Proj_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount("Jane", 125461f);
            ChildBankAccount bankAccount2 = new ChildBankAccount("Bob", 1334f, "Jane");

            Console.WriteLine(bankAccount1.Balance);

            Console.WriteLine(bankAccount2.Balance);

            Console.WriteLine(bankAccount1.AddBalance(456f));

            Console.WriteLine(bankAccount2.AddBalance(-143f, true));

            Console.WriteLine(bankAccount2.AddBalance(-9f, true));
        }
    }

    class SimpleMath
    {

        public static float Add(float n1, float n2) {

            return n1 + n2;

        }

        public static float Subtract(float n1, float n2)
        {

            return n1 - n2;

        }
        public static float Mult(float n1, float n2)
        {

            return n1 * n2;

        }
        public static float Divide(float n1, float n2)
        {

            return n1 / n2;

        }

    }
}
