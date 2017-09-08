using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Threading;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Words w = new Words("dictionary.txt");
            Console.Write("Please, enter your word: ");
            string request = Console.ReadLine();
            if (request == "###")
            {
                Console.Write("Application is over");
                Thread.Sleep(2000);
                return;
            }
            else
            {
                w.Complete(request);
            }
            Console.ReadKey(true);
        }
    }
}
