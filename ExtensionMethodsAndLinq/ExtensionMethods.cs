using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExtensionMethodsAndLinq
{
    public static class ExtensionMethods
    {
        public static int ReverseDigits(this int input)
        {
            char[] temp = input.ToString().ToCharArray();
            Array.Reverse(temp);
            return int.Parse(new string(temp));
        }

        public static string SortAlphabetically(this string input)
        {
            char[] temp = input.ToCharArray();
            Array.Sort(temp);
            return new string(temp);
        }

        public static Dictionary<string, string> Read()
        {
            var d = new Dictionary<string, string>();
            // Read each line.
            using (StreamReader r = new StreamReader("Words/WORD.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    // Alphabetize the line for the key.
                    // ... Then add to the value string.
                    string a = SortAlphabetically(line);
                    string v;
                    if (d.TryGetValue(a, out v))
                    {
                        d[a] = v + "," + line;
                    }
                    else
                    {
                        d.Add(a, line);
                    }
                }
            }
            return d;
        }

        public static void Show(this string thingy, Dictionary<string, string> d, string w)
        {
            // Write value for alphabetized word.
            string v;
            if (d.TryGetValue(SortAlphabetically(w), out v))
            {
                Console.WriteLine(v);
            }
            else
            {
                Console.WriteLine("-");
            }
        }

        public static IEnumerable<T> DoStuff<T>(this IEnumerable<T> query, Func<T, IEnumerable<T>> ienum)
        {
            //Example 
            //return query.Where(v => v.EffectiveFrom < DateTime.Now &&
            //                   v.EffectiveTo > DateTime.Now);
        }
    }


}


