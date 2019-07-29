using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class stack
    {
        private int[] el;
        private int top;
        private int max;

        public stack(int size)
        {
            el = new int[size];
            top = -1;
            max = size;
        }
        public void push(int item)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                el[++top] = item;
            }
        }

        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow"); return -1;
            }
            else
            {
                return el[top--];
            }
        }
        public int peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow"); return -1;
            }
            else
            {
                return el[top];
            }
        }

        public void print()
        { 
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                   Console.WriteLine(el[i]);
                }
            }
        }
        
        static void Main(string[] args)
        {
            stack s = new stack(5);
            s.push(10);
            s.pop(); s.print();
            s.push(1);
            s.push(2);
           



        }
    }
}

