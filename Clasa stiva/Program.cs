using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_stiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Stiva<string> StrStack = new Stiva<string>(5);

            StrStack.Push("a");
            StrStack.Push("b");
            StrStack.Push("c");
            StrStack.Push("d");
            StrStack.Push("e");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(StrStack.Pop());
            }


            Stiva<int> IntStack = new Stiva<int>(5);

            for (int i = 0; i < 5; i++)
            {
                IntStack.Push(i);
            }

            IntStack.Clear();

            Console.WriteLine(IntStack.Pop());
        }
    }
}
