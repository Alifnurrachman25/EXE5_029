using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_029
{
    class Node
    {
        public string name;
        public Node next;
    }

    class Queue
    {
        Node Alif, Rachman;

        public Queue()
        {
            Alif = null;
            Rachman = null;
        }

        public void insert()
        {
            string nm;
            Node newnode = new Node();
            Console.WriteLine("Masukkan element");
            nm = Console.ReadLine();
            newnode.name = nm;
            newnode.next = null;
            if (Alif == null)
            {
                Alif = new Node();
                Rachman = new Node();
                return;
            }
            Rachman.next = newnode;
            Rachman = newnode;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
