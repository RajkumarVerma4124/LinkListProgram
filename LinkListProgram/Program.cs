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
                Console.WriteLine("1: Add Element At First \n2: Add Element At Last \n3: Append A Element \n4: Insert Element At Particular Index"+
                                "\n5: Delete Element From First Position \n6: Display \n7: Exit");
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
                        //Appending the element at last position(UC3)
                        Console.Write("Enter A Number To Append: ");
                        int numAppend = int.Parse(Console.ReadLine());
                        list.AddLast(numAppend);
                        break;
                    case 4:
                        //Inserting the element at particular index(UC4)
                        Console.Write("Enter A Number To Insert: ");
                        int numInsert = int.Parse(Console.ReadLine());
                        Console.Write("Enter Index Position You Want The Number To Add: ");
                        int numIndex = int.Parse(Console.ReadLine());
                        list.InsertAt(numIndex, numInsert);
                        break;
                    case 5:
                        list.DeleteFirst();
                        break;
                    case 6:
                        list.Display();
                        break;
                    case 7:
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
