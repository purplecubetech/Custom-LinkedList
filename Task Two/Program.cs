using System;

namespace Task_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            //StackWithLinkedList<int> x = new StackWithLinkedList<int>();

            //x.Push(3);
            //x.Push(5);
            //x.Push(2);
            //x.Push(2);
            //x.PrintNode();
            //x.Pop();
            //Console.WriteLine(x.Size());
            //Console.WriteLine(x.Peek());
            //x.PrintNode();

            //QueueLinkedList<string> y = new QueueLinkedList<string>();
            //y.Enqueue("hello");
            //y.Enqueue("hshsh");
            //y.Enqueue("gsgs");
            //y.Enqueue("4grd43");
            //y.PrintNode();
            //y.Dequeue();         
          
            //Console.WriteLine(y.IsEmpty());
            //Console.WriteLine(y.Size());
            //Console.WriteLine("----------------");
            //y.PrintNode();



            SinglyLinkedList<int> z = new SinglyLinkedList<int>();

            z.AddToTail(1);
            z.AddToTail(2);
            z.AddToTail(3);
            z.AddToTail(4);
            z.PrintNode();
            Console.WriteLine(z.CheckValue(4));
            z.RemoveFirstOccurance(3);
            z.PrintNode();



        }
    }
}
