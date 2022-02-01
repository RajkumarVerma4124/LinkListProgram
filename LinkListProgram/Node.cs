using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListProgram
{
    //Creating the node class
    public class Node
    {
        //Creating the node with data and next reference
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
}
