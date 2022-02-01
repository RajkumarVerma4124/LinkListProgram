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

            //Creating a single linklist(UC1)
            LinkList list = new LinkList();

            while(true)
            {
                Console.WriteLine("1: Add Element At First \n2: Add Element At Last \n3: Append A Element \n4: Display \n5: Exit");
                Console.Write("Enter The Choice From Above : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Adding the element at first position(UC2)
                        Console.Write("Enter A Number To Add At First Position : ");
                        int numFirst = int.Parse(Console.ReadLine());
                        list.AddFirst(numFirst);
                        break;
                    case 2:
                        //Adding the element at last position(UC1)
                        Console.Write("Enter A Number To Add At Last Positon : ");
                        int numLast = int.Parse(Console.ReadLine());
                        list.AddLast(numLast);
                        break;
                    case 3:
                        //Adding the element at last position(UC1)
                        Console.Write("Enter A Number To Append: ");
                        int numAppend = int.Parse(Console.ReadLine());
                        list.AddLast(numAppend);
                        break;
                    case 4:
                        list.Display();
                        break;
                    case 5:
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
