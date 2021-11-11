using System;
using System.Collections.Generic;
using ListLib;

namespace ListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            List<int> l = new List<int>();
            l.Add(4);
            l.Add(5);
            l.Add(3);
            l.Add(8);
            l.Add(6);
            **/
          //  Console.WriteLine(l.FindAll(n => n > 3));


            Console.WriteLine("Custom listimiz");

            MyList<int> list = new MyList<int>();
            list.Add(4);
            list.Add(5);
            list.Add(3);
            list.Add(8);
            list.Add(6);
            list.Add(5);
            list.Add(6);
            list.Add(4);
            list.Add(4);
            list.Remove(4);
            for (int i = 0; i < list.GetLength(); i++)
            {
                Console.WriteLine(list[i]);
            }

            /**
           // Console.WriteLine(list.Find(n => n>3));
            MyList<int> myList=list.FindAll(n => n%2==0);
            for (int i = 0; i < myList.GetLength(); i++)
            {
                Console.WriteLine(myList[i]);
            }



            }
              
            **/


            /**

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

               

               Console.WriteLine( k.LastIndexOf(3) );




               Console.WriteLine("Hello World!");**/
        }
    }
}
