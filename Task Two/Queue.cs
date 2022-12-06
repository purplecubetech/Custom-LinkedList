using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Two
{
    public class QueueLinkedList<T>
    {
        Node<T> front, rear;

        public QueueLinkedList()
        {
            this.front = this.rear = null;
        }

        // Method to add an key to the queue.
        public void Enqueue(T key)
        {

            // Create a new LL node
            Node<T> temp = new Node<T>(key);

            // If queue is empty, then new
            // node is front and rear both
            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }

            // Add the new node at the
            // end of queue and change rear
            this.rear.next = temp;
            this.rear = temp;
        }

        // Method to remove an key from queue.
        public void Dequeue()
        {
            // If queue is empty, return NULL.
            if (this.front == null)
                return;

            // Store previous front and
            // move front one node ahead
            Node<T> temp = this.front;
            this.front = this.front.next;

            // If front becomes NULL,
            // then change rear also as NULL
            if (this.front == null)
                this.rear = null;
        }

        public bool IsEmpty()
        {
            return this.front == null;
        }

        public int Size()
        {
            Node<T> current = front;
            if (current == null)
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
            Node<T> current = front;
            while (current != null)
            {
                Console.WriteLine("Value of a Node is {0}", current.data);
                current = current.next;

            }
        }
    }
}
