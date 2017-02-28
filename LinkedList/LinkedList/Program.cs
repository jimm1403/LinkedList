using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    public class Program
    {
        MyList myList = new MyList();
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
            myProgram.Search();
            
        }
        public void Run()
        {
            
            ClubMember newMember1 = new ClubMember() { Nr = 1, Fname = "Jimmi", Lname = "Christensen", Age = 24 };
            ClubMember newMember2 = new ClubMember() { Nr = 2, Fname = "Lars", Lname = "Christensen", Age = 23 };
            ClubMember newMember3 = new ClubMember() { Nr = 3, Fname = "Hans", Lname = "Christensen", Age = 22 };
            ClubMember newMember4 = new ClubMember() { Nr = 4, Fname = "Katrine", Lname = "Christensen", Age = 21 };
            //Console.WriteLine("Add new member, with a nr, first name, lastname and age.");
            //ClubMember newMember = new ClubMember();
            //Console.WriteLine("Nr.");
            //newMember.Nr = int.Parse(Console.ReadLine());
            //Console.WriteLine("First name.");
            //newMember.Fname = Console.ReadLine();
            //Console.WriteLine("Last name.");
            //newMember.Lname = Console.ReadLine();
            //Console.WriteLine("Age.");
            //newMember.Age = int.Parse(Console.ReadLine());
            myList.Insert(newMember1);
            myList.Insert(newMember2);
            myList.Insert(newMember3);
            myList.Insert(newMember4);

            //myList.NodeToString();
            //Console.ReadKey();

        }
        public void Search()
        {
            Console.WriteLine("Search by index 1 - 4.");
            int tempSearchIndex = int.Parse(Console.ReadLine());
            Console.WriteLine(myList.Search(tempSearchIndex).Data.ToString());
            Console.ReadKey();
        }
    }
}

