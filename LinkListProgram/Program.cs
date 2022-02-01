using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Displaying the welcome message
            Console.WriteLine("Welcome To The Linklist Program");
            Console.ReadLine();

            //Creating a simple linklist of 56,30 and 70(UC1)
            LinkList list = new LinkList();
            list.AddLast(56);
            list.AddLast(30);
            list.AddLast(70);
            list.Display();
        }
    }
}
