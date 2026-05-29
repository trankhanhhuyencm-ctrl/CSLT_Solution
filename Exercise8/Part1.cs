using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_Solution.Properties.Exercise8
{
    internal class Part1
    {
        static int count_words(string s)
        {
            string sep = " ";
            string[] words = s.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"So tu trong chuoi la: {words.Length}");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            return words.Length;
        }
        public static void Main(String[] args)
        {
            string s = "Hello world! This is a test string.";
            int sotu = count_words(s.Trim());
        }
    }
}
