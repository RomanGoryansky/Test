using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestTask
{
    class Words
    {
        public SortedSet<string> sortedWords;

        public Words(string path)
        {
            string[] readedwords = File.ReadAllLines(path, Encoding.GetEncoding(1251));
            sortedWords = new SortedSet<string>(readedwords);
        }
        public void Complete(string request)
        {
            int counts = 1;
            foreach (string word in sortedWords)
                if (word.StartsWith(request) && counts <= 5)
                {
                    Console.WriteLine(word);
                    ++counts;
                }
            if (counts == 1)
                Console.WriteLine("No matches found");
        }
    }
}
