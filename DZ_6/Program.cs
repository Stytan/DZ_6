using System;

namespace DZ_6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IntList il = new IntList();
            Console.WriteLine("il.Length = {0}", il.Length);
            Console.WriteLine("il.Count = {0}", il.Count);
            for (int i = 0; i < 15; ++i)
                il.Add(i * 3);
            foreach (int i in il)
                Console.Write("{0} ", i);
            Console.WriteLine("\nil.Contains(9) = {0}", il.Contains(9));
            Console.WriteLine("il.IndexOf(9) = {0}", il.IndexOf(9));
            il.RemoveAt(3);
            Console.WriteLine("il.RemoveAt(3);");
            foreach (int i in il)
                Console.Write("{0} ", i);
            il.Remove(12);
            Console.WriteLine("\nil.Remove(12);");
            foreach (int i in il)
                Console.Write("{0} ", i);
            Console.WriteLine("\nil.Length = {0}", il.Length);
            Console.WriteLine("il.Count = {0}", il.Count);
        }
    }
}