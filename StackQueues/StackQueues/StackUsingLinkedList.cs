using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueues
{
    /// <summary>
    /// Implenting Stack using LinkedList.
    /// </summary>
    class StackUsingLinkedList
    {
        private Node top;
        public StackUsingLinkedList()
        {
            this.top = null;
        }
        /// <summary>
        /// Pushing data to the top of stack.
        /// </summary>
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        /// <summary>
        /// method to display all the elements of stack.
        /// </summary>
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}