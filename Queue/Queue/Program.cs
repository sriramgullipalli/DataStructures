using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        int[] e;
        int rear;
        int front;
        int max;

        public Queue(int size)
        {
            e = new int[size];
            rear = -1;
            front = 0;
            max = size;
        }

        public void enqueue(int item)
        {
            if(rear == max-1)
            {
                Console.WriteLine("Queue OverFlow");
            }
            else
            {
                e[++rear] = item;
            }
        }
        public int dequeue()
        {
            if(front == rear-1)
            {
                Console.WriteLine("Queue is UnderFlow");return -1;
            }
            else
            {
                Console.WriteLine("{0} is dequeue", e[front]);
                front++;
                Console.WriteLine("Front item is {0}", e[front]);
                Console.WriteLine("Rear item is {0} ", e[rear]);
             
                return 0;
            }
        }

        public void print()
        {
            if (front == (rear-1))
            {
                Console.WriteLine("Queue is UnderFlow"); 
            }
            else
            {
                for(int i = front;i <= rear;i++)
                {
                    Console.WriteLine(e[i]);
                }
            }
        }
        static void Main(string[] args)
        {

            Queue q = new Queue(5);
            q.enqueue(10);
            q.enqueue(20);
            q.enqueue(30);
            q.enqueue(40);
            q.print();
            q.dequeue();
           
        }
    }
}
