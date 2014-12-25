using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10_實現一個迭代器
{
    class Program
    {
        static void Main(string[] args)
        {
            Primes primesFrom2To1000 = new Primes(2, 1000);
            foreach (long i in primesFrom2To1000)
            {
                Console.Write(" {0}  ", i);
            }
            Console.ReadKey();
        }
    }
}
