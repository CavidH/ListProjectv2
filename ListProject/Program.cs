using System;
using System.Collections.Generic;
using ListLib;

namespace ListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2); 
            list.Add(3);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(4);
            list.Add(4);
            list.RemoveAt(5);
            Console.WriteLine(list[5]);
            List<int> k = new List<int>();
            k.Add(4);
            k.Add(5);
            k.Add(6);
            k.Add(3);
            k.Add(3);
            k.Add(1);
            k.Remove(6);

            for (int i = 0; i < k.Count; i++)
            {
                Console.WriteLine(k[i]);
            }/**

            Console.WriteLine( k.LastIndexOf(3) );




            Console.WriteLine("Hello World!");**/
        }
    }
}
