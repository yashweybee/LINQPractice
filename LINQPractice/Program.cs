using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

            //int[] arr = { 1, 2, 3, 45, 23, 56, 324, 76, 123 };
            //string[] arr2 = { "a", "b", "c", "d", "e", "f" };

            //Console.WriteLine(arr.Min());
            //Console.WriteLine(arr.Max());
            //Console.WriteLine(arr.Sum());
            //Console.WriteLine(arr.Average());
            //Console.WriteLine(arr2.Count());
            //Console.WriteLine(arr2.Aggregate((a, b) => a + ',' + b));



            //sorting

            List<Students> stdObj = new List<Students>
            {
                new Students(){Id = 123, Name = "Yash",subs =  new List<string> {"Math", "sci"} },
                new Students(){Id = 234, Name = "ahgs",subs =  new List<string> {"yasg", "sdf"} },
                new Students(){Id = 87, Name = "dfh",subs =  new List<string> {"mdfe", "sdty"} },
                new Students(){Id = 37, Name = "sdf",subs =  new List<string> {"yarb", "yasf"} },
                new Students(){Id = 34, Name = "aa",subs =  new List<string> {"aigyr", "siodyf"} }
            };

            //var stdNameOrderBy = stdObj.OrderBy(x => x.Name);
            //var stdNameOrderByDesc = stdObj.OrderByDescending(x => x.Name);
            //var stdNameThenBy = stdObj.OrderBy(x => x.Name).ThenBy(x => x.Id);
            //var stdNameThenBy = stdObj.OrderBy(x => x.Name).ThenByDescending(x => x.Id);

            string[] names = { "aaa", "asdb", "ccc", "bb", "ooo" };
            //var myNames = names.TakeWhile(x => x.StartsWith("a"));
            var newNames = names.SkipWhile(x => x.StartsWith("c"));
            //var namesObj = names.Reverse();

            //IEnumerable<Students> stdTake = stdObj.Take(2);
            //IEnumerable<Students> stdTake2 = (from x in stdObj select x).OrderByDescending(x => x.Id);
            //IEnumerable<Students> stdSkip = stdObj.Skip(3);

            //foreach (var item in newNames)
            //{
            //    Console.WriteLine(item);
            //}

            //Conversion Operators

            string[] myNames = { "aaa", "asdb", "ccc", "bb", "ooo", "nnn", "ppp" };
            List<int> myNums = new List<int> { 22, 44, 11, 45, 123, 787, 23 };

            //List<string> convertedArr = (from x in myNames where x.StartsWith("a") select x).ToList();
            //List<string> convertedArr2 = myNames.ToList();
            //int[] convertedIntArr = myNums.ToArray();

            List<Teachers> teachObj = new List<Teachers>
            {
                new Teachers(){Id = 1, name = "hhh", gender = "m"},
                new Teachers(){Id = 2, name = "uuu", gender = "f"},
                new Teachers(){Id = 3, name = "lll", gender = "f"},
                new Teachers(){Id = 4, name = "www", gender = "m"},
                new Teachers(){Id = 5, name = "aaa", gender = "m"},
                new Teachers(){Id = 6, name = "rrr", gender = "f"},
            };

            var teachToLook = teachObj.ToLookup(x => x.gender);

            //foreach (var s in teachToLook)
            //{
            //    Console.WriteLine(s.Key);

            //    foreach (var t in teachToLook[s.Key])
            //    {
            //        Console.WriteLine(t.name);
            //    }
            //}

            //ArrayList myarryList = new ArrayList() { "ASDF", "asdg", 100, "shf", 800 };
            //int[] numbers = new int[5] { 2, 5, 8, 4, 2 };

            //IEnumerable<string> result = myarryList.Cast<string>();
            //IEnumerable<int> onlyNums = myarryList.OfType<int>();
            //var eNums = numbers.AsEnumerable();
            //var teachDic = teachObj.ToDictionary(x => x.Id, x => x.name);

            //foreach (KeyValuePair<int, string> item in teachDic)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}


            //Element operators

            int[] numbers = { 345, 41234, 3623, 235, 10 };
            int[] numbers2 = { };
            //Console.WriteLine(numbers.FirstOrDefault());
            //Console.WriteLine(numbers.Last());
            //Console.WriteLine(numbers2.LastOrDefault());
            //Console.WriteLine(numbers.ElementAt(2));
            //Console.WriteLine(numbers2.ElementAtOrDefault(2));

            //var teach = teachObj.Single(x => x.name == "www");
            //Console.WriteLine(teach.Id);

            //int val = numbers.SingleOrDefault(x => x < 10);
            //Console.WriteLine(val);

            var res = numbers.DefaultIfEmpty();
            var res2 = numbers2.DefaultIfEmpty(3);

            foreach (int i in res2)
            {
                Console.WriteLine(i);
            }



            Console.ReadLine();
        }
    }

    class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> subs;
    }

    class Teachers
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
    }
}
