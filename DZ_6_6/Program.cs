using System;
using System.Collections.Generic;

namespace DZ_6_6
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Counting the number of identical words in the text");
			Console.WriteLine("Enter text: ");
			string text = Console.ReadLine();
			string[] buf = text.Split(",. ;:!?".ToCharArray());
			var dict = new Dictionary<string,int>();
			if(buf.Length==0)
			{
				Console.WriteLine("Not found a words in text");
			}
			else
			{
				foreach(string str in buf)
				{
					if (str != "") {
						try {
							dict.Add(str, 1);
						} catch (ArgumentNullException) {
							continue;
						} catch (ArgumentException) {
							//такой ключ уже есть в коллекции - добавляем ему значение
							dict[str]++;
						}
					}
				}
				if(dict.Count>0)
				{
					var dictEnum = dict.GetEnumerator();
					while(dictEnum.MoveNext())
					{
						Console.WriteLine(dictEnum.Current.Key + " - " + dictEnum.Current.Value);
					}
				}
			}
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
