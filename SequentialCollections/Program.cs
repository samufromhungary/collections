using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SequentialCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("first");
            queue.Enqueue("second");
            queue.Enqueue("third");
            queue.Enqueue("fourth");

            while(queue.Count > 0)
            {
                object obj = queue.Dequeue();

                Console.WriteLine("From queue: {0}", obj);
            }

            Console.WriteLine("\r\n");

            Stack stack = new Stack();
            stack.Push("first");
            stack.Push("second");
            stack.Push("third");
            stack.Push("fourth");

            while(stack.Count > 0)
            {
                object obj = stack.Pop();
                Console.WriteLine("From stack: {0}", obj);
            }

            Console.ReadKey();
        }
    }
}
