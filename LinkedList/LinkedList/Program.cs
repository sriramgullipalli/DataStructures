using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    class LinkedList
    {
        node head;
        public class node
        {
            public int data;
            public node next;

            public node(int d)
            {
                data = d;
                next = null;
            }

        }


        public static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            ll.head = new node(1);
            node first = new node(2);
            node secound = new node(3);

            ll.head.next = first;
            first.next = secound;

            while (ll.head != null)
            {
                Console.WriteLine(ll.head.data + " ");
                ll.head = ll.head.next;
            }

        }

    }
}

