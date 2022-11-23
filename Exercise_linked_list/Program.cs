using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_linked_list
{
    class Node
    {
        /*create node for the circular nexted list*/
        public int rollNumber;
        public string name;
        public Node next;
    }
    class CircularList
    {
        Node LAST;
        
        public CircularList()
        {
            LAST = null;
        }

        public bool Search(int rollNo, ref Node previous, ref Node current)/*search for the specified node*/
        {
            for (previous = current = LAST.next; current != LAST; previous = current, current = current.next)
            {
                if (rollNo == current.rollNumber)
                    return (true);/*return true if the node is found*/
            }
            if (rollNo == LAST.rollNumber)/* if the node is present at the end*/
                return true;
            else
                return (false);/* return false if the node is not found*/
        }
        public bool listEmpty()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
