﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class LinkedListQueue
    {
        internal Node head;
        internal Node front;
        internal Node rear;

        /// <summary>
        /// UC 3
        /// Here, insertion is done from (rear)end which is enqueue and deletion is done from (front)start which is dequeue
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                rear = node;
            }
        }

        /// <summary>
        /// UC 4
        /// </summary>
        public void Dequeue()
        {
            front = this.head;
            Console.WriteLine("After Dequeue, element returned is {0}",front.data);
            Node temp = this.head;
            temp = temp.next;
            front = temp;
            this.head = front;
        }

        /// <summary>
        /// UC 4
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (this.head == null)
            {
                return true;
            }
            return false;
        }

        public void Display()
        {
            Node temp = this.head;
            Console.WriteLine("Queue Elements are");
            while (temp != null)
            {
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
