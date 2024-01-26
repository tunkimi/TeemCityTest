using System;
using Newtonsoft.Json;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ratata");
            int a;
            Console.WriteLine("ratata55asdasd5");


            var b = JsonConvert.SerializeObject(new A { x = 4 });
        }

    }


    class A
    {
        public int x;
    }
}
