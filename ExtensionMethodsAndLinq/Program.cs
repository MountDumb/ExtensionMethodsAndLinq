using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExtensionMethodsAndLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.SortStringAplhabeticallyTest();
            p.Anagram();
            
        }

        public void Anagram()
        {
            // Read and sort dictionary.
            
            var d = ExtensionMethods.Read();
            string line;

            
            // Read in user input and show anagrams.

            while ((line = Console.ReadLine()) != "exit")
            {
                //ExtensionMethods.Show(d, line);
                line.Show(d, line);
            }
        }

        public void SortStringAplhabeticallyTest()
        {
            string test = "adkkegt";
            Console.WriteLine(test);
            Console.WriteLine(test.SortAlphabetically());
            Console.ReadLine();
        }

        public void ReverseDigitsTest()
        {
            int test = 12345;

            Console.WriteLine(test);
            Console.WriteLine(test.ReverseDigits());
            Console.ReadLine();
        }


    }
}
