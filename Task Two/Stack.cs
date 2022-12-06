using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Two
{
    public class StackWithLinkedList<T>
    {
        Node<T> top;
        public StackWithLinkedList()
        {
            this.top = null;
        }

        public void Push(T x) // At head linkedlist for stack; you will have the top Node and the tails you will have bottom node
        {
            // create new node temp and allocate memory
            Node<T> temp = new Node<T>(x);

            if (top == null)
            {
                temp.next = null;
            }
            else
            {
                temp.next = top;
            }
            top = temp;
        }

        // Utility function to check if
        // the stack is empty or not
        public bool IsEmpty()
        {
            return top == null;
        }

        // Utility function to return
        // top element in a stack
        public T Peek()
        {
            // check for empty stack
            if (!IsEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return default;
            }
        }

        // Utility function to pop top element from the stack
        public void Pop() // remove at the beginning
        {
            // check for stack underflow
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }

            // update the top pointer to
            // point to the next node
            top = top.next;
            Console.WriteLine(top.data);
        }

        public int Size()
        {
            Node<T> current = top;
            
            if(current == null)
            {
                return 0;
            }
            int counter = 1;

            while (current.next != null)
            {
                current = current.next;
                counter++;
            }

            return counter;
        }

        public void PrintNode()
        {
            Node<T> current = top;
            while (current != null)
            {
                Console.WriteLine("Value of a Node is {0}", current.data);
                current = current.next;

            }
        }
    }
}
