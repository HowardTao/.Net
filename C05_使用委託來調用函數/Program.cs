using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05_使用委託來調用函數
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessDelegate process;
            Console.WriteLine("輸入兩個數字用,隔開");
            string input =Console.ReadLine();
            string[] ss = input.Split(',');
            double param1 = Convert.ToDouble(ss[0]);
            double param2 = Convert.ToDouble(ss[1]);
            Console.WriteLine("輸入M或D");
            input = Console.ReadLine();
            if (input == "M")
            {
                process = new ProcessDelegate(Multiply);
            }
            else
            {
                process = new ProcessDelegate(Divide);
            }
            Console.WriteLine("結果為{0}", process(param1, param2));
            Console.ReadKey();
        }

        //定義委託
        delegate double ProcessDelegate(double param1, double param2);

        static double Multiply(double param1, double param2)
        {
            return param1 * param2;
        }

        static double Divide(double param1, double param2)
        {
            return param1 / param2;
        }

    }
}
