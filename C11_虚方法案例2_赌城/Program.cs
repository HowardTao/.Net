using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11_虚方法案例2_赌城
{
    class Program
    {
        static void Main(string[] args)
        {
            CardPusher cp = new CardPusher();
            Card c = cp.GetCard();
            c.Show();
            Console.ReadKey();
        }
    }
}
