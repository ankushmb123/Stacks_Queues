﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            StackUsingLinkedList stackUsingLinkedList = new StackUsingLinkedList();
            stackUsingLinkedList.Push(70);
            stackUsingLinkedList.Push(30);
            stackUsingLinkedList.Push(56);
            Console.WriteLine("Stack Structure- ");
            stackUsingLinkedList.Display();
            Console.ReadLine();
        }
    }
}
