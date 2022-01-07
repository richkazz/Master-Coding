using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class MinStack
    { 
        private class Node
        {
            
            public int value;
            public Node Next;
            public Node oldMin;
        }
        
        Node stack;
        public MinStack()
        {
           
        }

        public void Push(int val)
        {
            if(stack == null)
            {
                stack = new Node();
                stack.value = val;
                Node newNodeMin = new Node();

                newNodeMin.value = val;
                stack.oldMin = newNodeMin;
            }
            else
            {
                Node newNode = new Node();
                newNode.value = val;
                if(stack.oldMin.value > val)
                {
                    Node newNodeMin = new Node();

                    newNodeMin.value = val;
                    newNode.oldMin = newNodeMin;
                }
                else
                {
                    Node newNodeMin = new Node();

                    newNodeMin.value = stack.oldMin.value;
                    newNode.oldMin = newNodeMin;
                }
                newNode.Next = stack; stack = newNode;
            }
        }

        public void Pop()
        {
            if (stack == null)
                return;
            Node newNode = new Node();
            newNode = stack.Next;
            stack = newNode;
            
           
        }
        public int Top()
        {
            if (stack == null)
                return -1;
            return stack.value;
        }

        public int GetMin()
        {
            if (stack == null)
                return -1;
            if (stack.oldMin == null)
                return stack.value;
            return stack.oldMin.value;
        }

    }
}
