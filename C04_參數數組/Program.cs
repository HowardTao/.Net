using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04_參數數組
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = SumVals(1, 2, 2, 2);
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        //c#允許為函數指定一個(只能指定一個)特定的參數，
        //這個參數必須是函數定義中最後一個參數,稱為參數數組。
        static int SumVals(params int[] vals)
        {
            int sum = 0;
            foreach (int val in vals)
            {
                sum += val;
            }
            return sum;
        }
    }
}
