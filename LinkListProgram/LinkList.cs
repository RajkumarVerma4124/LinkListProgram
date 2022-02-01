using System;
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
            Console.Write("{0} is inserted into linklist", node.data);
            Console.ReadLine();
        }


       
        //Displaying the data from linklist nodes(UC1)
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
