using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class LinkedListStack
    {
        internal Node head;
        /// <summary>
        /// UC 1
        /// Logic is just add new element at the start of LinkedList and then print the List. It will work as Stack
        /// </summary>
        /// <param name="data"></param>
        public void Push(int data)
        {
            Console.WriteLine("Pushing {0} into Stack",data);
            Node node = new Node(data);

            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node top = this.head;   //head in LinkedList == Top in stack
                node.next = top;
                this.head = node;
            }

        }

        public void Display()
        {
            Node temp = this.head;
            Console.WriteLine("Displaying Elements of Stack:");

            while (temp != null)
            {
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
            Console.WriteLine();
            
        }
    }
}
