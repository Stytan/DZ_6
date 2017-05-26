using System;

namespace DZ_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack St = new MyStack(15);
            Console.WriteLine("St.Length = {0}", St.Length);
            Console.WriteLine("St.Count = {0}", St.Count);
            for (int i = 0; i < 15; ++i)
                St.Push(i);
            foreach (int i in St)
                Console.Write("{0} ", i);
            Console.WriteLine("\nSt.Peek() = {0}", St.Peek());
            Console.WriteLine("St.Pop()");
            St.Pop();
            foreach (int i in St)
                Console.Write("{0} ", i);
            Console.WriteLine("\nSt.Length = {0}", St.Length);
            Console.WriteLine("St.Count = {0}", St.Count);
        }
    }
}
