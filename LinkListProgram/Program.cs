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
                                "\n5: Delete Element From First Position \n6: Delete Element From Last Position \n7: Search Node Show Last \n8: Display"+
                                "\n9: Exit");
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
                        //Deleting the first element(UC5)
                        int deleteFirst = list.DeleteFirst();
                        if(deleteFirst != 0)
                            Console.WriteLine("Deleted the element {0} at first position", deleteFirst);
                        break;
                    case 6:
                        //Deleting the last element(UC6)
                        int deleteLast = list.DeleteLast();
                        if (deleteLast != 0)
                            Console.WriteLine("Deleted the element {0} at last position", deleteLast);
                        break;
                    case 7:
                        //Show the search element is present or not(UC6)
                        Console.Write("Enter a number to search in linklist : ");
                        //int searchValue = int.Parse(Console.ReadLine());
                        int searchValue = list.Search(int.Parse(Console.ReadLine()));
                        if(searchValue != 0)
                            Console.WriteLine("{0} is present in the current linklist", list.Search(searchValue));
                        break;
                    case 8:
                        list.Display();
                        break;
                    case 9:
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
