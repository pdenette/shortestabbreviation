using System;
using System.IO;
using System.Linq;

namespace shortestabbreviation
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string line in File.ReadLines(@".\list.txt"))
            {
                // Console.WriteLine(line);
                string[] words = line.Split(' ');
                foreach (String w in words)
                {
                    Console.WriteLine(w.Substring(0, 3));
                }
                if (words.Distinct().Count() != words.Count())
                {
                    Console.WriteLine("Duplicate Found");
                }

                break;
            }
        }
    }
}
