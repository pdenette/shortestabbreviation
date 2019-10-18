using System;
using System.IO;
using System.Linq;

namespace shortestabbreviation
{
    class Program
    {
        static bool checkArrayForDuplicates(string[] abDay)
        {
            if (abDay.Distinct().Count() != abDay.Count())
            {
                return true;
            }
            return false;
        }

        static void writeShortestAbbreviationToFile(string[] shortestAbbreviation)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@".\abbreviated.txt", true))
            {
                file.WriteLine(string.Join(" ", shortestAbbreviation));
            }
        }

        static void findShortestPossibleAbbriviation(string[] days)
        {
            string[] abDay = new string[days.Length];
            // Console.WriteLine(abDay[6]);
            int incrementAbb = 1;

            while (checkArrayForDuplicates(abDay))
            {
                int incrementDay = 0;
                foreach (String w in days)
                {
                    if (w.Length >= incrementAbb)
                    {
                        abDay[incrementDay] = w.Substring(0, incrementAbb);
                    }
                    incrementDay++;
                }
                incrementAbb++;
            }
            writeShortestAbbreviationToFile(abDay);
        }

        static void Main(string[] args)
        {
            //if exists delete file 
            foreach (string line in File.ReadLines(@".\list.txt"))
            {
                string[] words = line.Split(' ');
                findShortestPossibleAbbriviation(words);
            }
        }
    }
}
