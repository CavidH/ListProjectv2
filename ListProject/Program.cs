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
        
         

            for (int i = 0; i < list.GetLength(); i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("--------------");
            list.Reverse();
            for (int i = 0; i < list.GetLength(); i++)
            {
                Console.WriteLine(list[i]);
            }

            /**

            Console.WriteLine( k.LastIndexOf(3) );




            Console.WriteLine("Hello World!");**/
        }
    }
}
