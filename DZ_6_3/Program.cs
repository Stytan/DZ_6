using System;

namespace DZ_6_3
{
    class Program
    {
        private delegate string transDelegate(string country);
        public static void Main(string[] args)
        {
            CountryDictionary cd;
            try
            {
                cd = new CountryDictionary();
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Error: Not found dict.txt");
                return;
            }
            ConsoleKeyInfo key;
            transDelegate trans;
            Console.WriteLine("Translator of the names of the countries of the world");
            do
            {
                Console.WriteLine("\n1 - Translate from Russian to English");
                Console.WriteLine("2 - Translate from English to Russian");
                Console.WriteLine("0 - Exit");
                Console.Write("Select translation direction: ");
                key = Console.ReadKey();
                switch (key.KeyChar)
                {
                    case '1':
                        {
                            trans = cd.TranslateRuToEn;
                            break;
                        }
                    case '2':
                        {
                            trans = cd.TranslateEnToRu;
                            break;
                        }
                    case '0':
                        {
                            continue;
                        }
                    default:
                        {
                            Console.WriteLine("\nInvalid choice. Try again");
                            continue;
                        }
                }
                do
                {
                    Console.Write("\nEnter name of country to translate: ");
                    Console.WriteLine("Translate: " + trans(Console.ReadLine()));
                    Console.Write("next country? (y/n): ");
                } while (Console.ReadKey().KeyChar == 'y');
                trans = null;
            } while (key.KeyChar != '0');
            Console.Write("\nPress any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
