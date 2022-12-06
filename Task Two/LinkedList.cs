using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Two
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T value)
        {
            data = value;
            next = null;
        }
    }
    public class SinglyLinkedList<T>
    {
        Node<T> head;

        public SinglyLinkedList()
        {
            head = null;

        }

        public void AddToTail(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
                return;
            }

            Node<T> current = head;
            while (current.next != null)
            {
                current = current.next;
            }

            current.next = new Node<T>(data);
        }
        

        public bool CheckValue(T value)
        {
            Node<T> current = head;
            while (current != null)
            {
                if(value.Equals(current.data))
                {
                    return true;
                }
                current = current.next;

            }

            return false;
        }

        public int Index(T value)
        {
            Node<T> current = head;
            int count = 0;
            while (current != null)
            {
                if (value.Equals(current.data))
                {
                    return count;
                }
                current = current.next;
                count++;
            }

            return count;
        }


        public bool RemoveFirstOccurance(T value)
        {
            Node<T> current = head;            
            Node<T> temp = null;

            while (current.next != null)
            {
                if (value.Equals(current.data))
                {
                    temp.next = current.next;
                    return true;
                }
                else
                {
                    temp = current;
                    current = current.next;

                }
                
            }
            return false;
        }


        public void PrintNode()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.WriteLine("Value of a Node is {0}", current.data);
                current = current.next;

            }
        }
    }
}
