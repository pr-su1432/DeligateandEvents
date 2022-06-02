// See https://aka.ms/new-console-template for more information
using System;
namespace DelegateandEvents
{

    // Delegate Definition or Declaration
    public delegate int operation(int x, int y);
    class program
    {
        // Method that is passes  as an Argument
        // It has same signature as Delegates
        static int Addition(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate of!");

            //Deligate instantiation
            operation obj = new operation(Addition);

            //output
            Console.WriteLine("Addition is={0}",obj(56,78));
            Console.WriteLine();
            MultipleDelegates value = new MultipleDelegates();
            value.ImplementDelegate();

        }
    }
}
