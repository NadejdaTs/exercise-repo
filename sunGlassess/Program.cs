using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sunGlassess
{
    class Program
    {
        static void Main(string[] args)
        {
                int n = int.Parse(System.Console.ReadLine());
                if (n >= 3 && n <= 100)
                {
                    var strtEnd = new string('*', n * 2) + new string(' ', n) + new string('*', n * 2);
                    Console.WriteLine(strtEnd);
                    for (int i = 1; i < n-1; i++)
                    {
                        var glass = '*' + new string('/', (n * 2) - 2) + '*';
                        if (i == ((n - 1) / 2))
                        {
                            Console.WriteLine(glass + new string('|', n) + glass);
                            //Console.WriteLine(glass + new string('|', n) + glass);
                        }
                        else
                        {
                           Console.WriteLine(glass + new string(' ', n) + glass);
                        }                
                    }
                    Console.WriteLine(strtEnd);
                }
        }
    }
}
