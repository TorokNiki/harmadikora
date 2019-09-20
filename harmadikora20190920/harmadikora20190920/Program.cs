using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadikora20190920
{
    class Program
    {
        static void Main(string[] args)
        {
            int legnagyobb = elso();
            Console.WriteLine("A legnagyobb szám a: "+legnagyobb);
        }
        public static int elso()
        {
            int[] tomb = new int[10];
            int max = 0;
            Console.WriteLine("Most 10db egész számot kérünk öntöl.");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("Kérem adja meg a {0}. számot: ",i+1);
                tomb[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < tomb.Length; i++)
            {
                if (max<tomb[i])
                {
                    max = tomb[i];
                }
            }
            return max;
        }
    }
}
