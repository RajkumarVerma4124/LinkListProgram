using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListProgram
{
    public class Program
    {
        //Creating a single linklist(UC1)
        public static LinkList list = new LinkList();
        public static void Main(string[] args)
        {
            //Displaying the welcome message
            Console.WriteLine("Welcome To The Linklist Program");
            Console.ReadLine();

            while(true)
            {
                Console.WriteLine("1: Add Element At First \n2: Add Element At Last \n3: Display \n4: Exit");
                Console.Write("Enter The Choice From Above : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Adding the element at first position(UC2)
                        Console.Write("Enter A number : ");
                        int numFirst = int.Parse(Console.ReadLine());
                        list.AddFirst(numFirst);
                        break;
                    case 2:
                        //Adding the element at last position(UC1)
                        Console.Write("Enter A number : ");
                        int numLast = int.Parse(Console.ReadLine());
                        list.AddLast(numLast);
                        break;
                    case 3:
                        list.Display();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter A Right Choice");
                        continue;
                }
            }
        }
    }
}
