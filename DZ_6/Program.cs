using System;
using System.Collections;

namespace DZ_6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IntList il = new IntList();
            Console.WriteLine("il.Length = {0}", il.Length);
            for (int i = 0; i < 15; ++i)
                il.Add(i * 3);
            foreach (int i in il)
                Console.Write("{0}\t", i);
            Console.WriteLine("\nil.Length = {0}", il.Length);

            Console.WriteLine("Hello, Dcoder!");
        }
    }
}