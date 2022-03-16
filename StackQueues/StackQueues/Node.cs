using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueues
{
    public class Node
    {
        /// <summary>
        /// Node is an element of linkedlist that hold data and address of next node.
        /// </summary>
        
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
}
