using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_泛型的搜索和排序
{
    class Program
    {
        static void Main(string[] args)
        {
            Vectors route = new Vectors();
            route.Add (new Vector (2.0,90.0));
            route.Add(new Vector(1.0, 180.0));
            route.Add(new Vector(0.5, 45.0));
            route.Add(new Vector(2.5, 315.0));

            Console.WriteLine(route.Sum());

            //創建一個Comparison<Vector>類型的委託sorte，賦予委託的方法 VectorDelegates.Compare
            Comparison<Vector> sorter = new Comparison<Vector>(VectorDelegates.Compare);
            route.Sort(sorter);
            Console.WriteLine(route.Sum());

            Predicate<Vector> searcher = new Predicate<Vector>(VectorDelegates.TopRightQuadrant);
            Vectors topRightQuadrantRoute = new Vectors(route.FindAll(searcher));
            Console.WriteLine(topRightQuadrantRoute.Sum());

            Console.ReadKey();
        }
    }
}
