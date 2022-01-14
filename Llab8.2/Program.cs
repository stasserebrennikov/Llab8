using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Llab8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Lab_VIII.txt";
            Random random = new Random();

            using (StreamWriter sw = new StreamWriter(path))
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(0, 10));
                }

            int s = 0;
            using (StreamReader sr = new StreamReader(path))
                for (int i = 0; i < 10; i++)
                {
                    int x = Convert.ToInt32(sr.ReadLine());
                    Console.Write($"{x} ");
                    s += x;
                }
            Console.WriteLine();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
