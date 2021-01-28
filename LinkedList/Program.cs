using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyLinkedList();
            Console.WriteLine("*******init size*******");
            Console.WriteLine(list.Size());
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddFirst(15);
            Console.WriteLine("******valid indexof*******");
            Console.WriteLine(list.IndexOf(30));
            
            Console.WriteLine("******invalid indexof*******");
            Console.WriteLine(list.IndexOf(11));

            Console.WriteLine("******valid contains*******");
            Console.WriteLine(list.Contains(20));
            
            Console.WriteLine("*******invalid contains*******");
            Console.WriteLine(list.Contains(11));
            
            Console.WriteLine("*******size*******");
            Console.WriteLine(list.Size());
            
            Console.WriteLine("*******read*******");
            
            list.ReadList();

            Console.WriteLine("*******read as list*******");
            var generic = list.ToGenericList();
            foreach (var item in generic)
                Console.WriteLine(item);
        }
    }
}