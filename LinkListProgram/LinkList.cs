﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListProgram
{
    public class LinkList
    {
        public Node head;

        //Creating add last method to add the data in linklist sequentially(UC1)
        public void AddLast(int data)
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
            }
            Console.Write("{0} is inserted into linklist \n", node.data);
            Console.ReadLine();
        }

        //Creating add first method to add the element at first position i.e head(UC2)
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = this.head;
            this.head = newNode;
            Console.WriteLine("{0} is inserted into linklist \n", newNode.data);
        }

        //Creating append method to add the element at last position i.e tail(UC3)
        public void Append(int data)
        {
            AddLast(data);
        }

        //Displaying the data from linklist nodes(UC1 & UC2)
        public void Display()
        {
            //Storing the head to temp node
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkList Is Empty");
                Console.ReadLine();
            }
            else
            {
                Console.Write("The Elements In LinkList Are : ");
                while (temp != null)
                {
                    Console.Write(temp.data+" ");
                    temp = temp.next;
                }
                Console.ReadLine();
            }
        }
    }
}
