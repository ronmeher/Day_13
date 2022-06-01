using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = { 112, 223, 334, 445, 556 };
            GenericMax<int> gen = new GenericMax<int>(arr);
            gen.printMaxValue();
            Console.ReadLine();

        }
    }
}
