using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestTask
{
    class Dictionary
    {
        public SortedSet<string> sortedWords;               // будут храниться сортированные слова из файла

        public Dictionary(string path)
        {
            string[] readedwords = File.ReadAllLines(path, Encoding.GetEncoding(1251));
            sortedWords = new SortedSet<string>(readedwords);
        }
        public void Complete(string request)                //метод, реализующий дополнение
        {
            int count = 0;                                  //счетчик количества выводимых в консоль слов
            foreach (string word in sortedWords)
                if (word.StartsWith(request) && count <= 4)
                {
                    Console.WriteLine(word);
                    ++count;
                }
            if (count == 0)
                Console.WriteLine("No matches found");
        }
    }
}
