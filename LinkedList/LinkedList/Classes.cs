using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class MyList
    {
        string test;
        public Node Head { get; set; }
        public string NodeToString()
        {
            Node tempNode = Head;
            while (tempNode != null)
            {
                Console.WriteLine(tempNode.Data.ToString());
                tempNode = tempNode.Next;
            }
            return "This index does not exits.";
        }
        public void Insert(ClubMember clubMember)
        {
            Node newNode = new Node() { Next = Head, Data = clubMember };
            Head = newNode;
        }
        public void Delete()
        {
            Head = Head.Next;
        }
        public Node Search(int index)
        {
            Node tempNode = Head;
            if (tempNode == null)
            {
                Console.WriteLine("Det findes ikke.");
            }
            else
            {
                for (int i = 1; i < index; i++)
                {
                    tempNode = tempNode.Next;
                }
            }
            return tempNode;
        }
    }
    class Node
    {
        public Node Next { get; set; }
        public ClubMember Data { get; set; }
    }
    class ClubMember
    {
        public int Nr { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Nr.ToString() + " " + Fname + " " + Lname + " " + Age.ToString();
        }
    }

}
