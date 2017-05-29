using System;
using System.IO;
using System.Collections.Generic;

namespace DZ_6_3
{
    /// <summary>
    /// Description of CountryDictionary.
    /// </summary>
    public class CountryDictionary
    {
        const string path = @".\dict.txt";
        SortedList<string, string> ruToEnDict = new SortedList<string, string>(200);
        SortedList<string, string> enToRuDict = new SortedList<string, string>(200);
        public CountryDictionary()
        {
            using (var sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                var buf = new string[2];
                while ((line = sr.ReadLine()) != null)
                {
                    buf = line.Split('\t');
                    try
                    {
                        ruToEnDict.Add(buf[0], buf[1]);
                        enToRuDict.Add(buf[1], buf[0]);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("An element {0} - {1} already exists.", buf[0], buf[1]);
                    }
                }
            }
        }
        public string TranslateRuToEn(string ru)
        {
            string en;
            try
            {
                en = ruToEnDict[ru];
            }
            catch (KeyNotFoundException)
            {
                en = ru + " is not found.";
            }
            return en;
        }
        public string TranslateEnToRu(string en)
        {
            string ru;
            try
            {
                ru = enToRuDict[en];
            }
            catch (KeyNotFoundException)
            {
                ru = en + " is not found.";
            }
            return ru;
        }
    }
}
