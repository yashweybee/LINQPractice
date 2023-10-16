using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>()
            //{
            //    "ausgd",
            //    "zxcv",
            //    "qwet"
            //};

            List<int> intLIst = new List<int>()
            {
                1,2,3,4,5,6,7,8,8,9,10,11,12
            };

            //var r = from i in list
            //        where i.Contains("ausgd")
            //        select i;

            //var q = list.Where(a => a.Contains("zxcv"));

            //var num = from obj in intLIst
            //          where obj == 1
            //          select obj;


            //List<string> country = new List<string>();
            //country.Add("Ind");
            //country.Add("Agf");

            //IEnumerable<string> c1 = country.Select(x => x);

            //foreach (var item in c1)
            //{
            //    Console.WriteLine(item);
            //}
            int[] arr = { 1, 2, 3, 45, 23, 56, 324, 76, 123 };
            string[] arr2 = { "a", "b", "c", "d", "e", "f" };
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Sum());
            Console.WriteLine(arr.Average());
            Console.WriteLine(arr2.Count());
            Console.WriteLine(arr2.Aggregate((a, b) => a + ',' + b));


            Console.ReadLine();
        }
    }
}
