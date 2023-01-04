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

        public void delete()
        {
            if (Alif == null)
            {
                Console.WriteLine("Queue is empty !!");
                return;
            }
            Alif = Alif.next;
            if (Alif == null)
                Rachman = null;
        }

        public void display()
        {
            if (Alif == null)
            {
                Console.WriteLine(" Queue is empty!!");
                return;
            }
            Node display;
            for (display = Alif; display != null; display = display.next)
                Console.WriteLine(display.name);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. Do insert operation");
                    Console.WriteLine("2. Do delete operation");
                    Console.WriteLine("3. Do Display operation");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nEnter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}
