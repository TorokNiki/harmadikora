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
            int N = 0;
            Console.WriteLine("Hány elemű legyen a tömbünk?: ");
            N = int.Parse(Console.ReadLine());
            int[] tomb = new int[N];
            int max = 0;
            Console.WriteLine("Most {0}db egész számot kérünk öntöl.",N);
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
