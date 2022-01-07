using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    /// <summary>
    /// A class for get the maximum value and removing the maximum value at constant time
    /// </summary>
    public class MaxStack
    {
        /// <summary>
        /// A node of type DoublyLinkedList
        /// </summary>
        private class Node
        {
            public int value;
            public Node Next;
            public Node Previous;
        }
        /// <summary>
        /// A dictionary of type int and List of Node
        /// It is used for:
        /// Geting the maximum value
        /// Getting a reference to the maximum value
        /// </summary>
        private SortedDictionary<int, List<Node>> StoreStackReference;
       
        Node stack;
        int max = 0;
        /// <summary>
        /// A method for adding to the stack
        /// </summary>
        /// <param name="val"></param>
        public void Push(int val)
        {
            if (max < val)
                max = val;

            if (stack == null)
            {   
                stack = new Node();
                stack.value = val;
                StoreStackReference = new SortedDictionary<int, List<Node>>();
                List<Node> listOfNode = new List<Node>();
                listOfNode.Add(stack);
                StoreStackReference.Add(val, listOfNode); /// add to the dictionary for the first time               
            }
            else
            {
                Node newNode = new Node();
                newNode.value = val;
                newNode.Next = stack;
                stack.Previous = newNode; 
                if (StoreStackReference.ContainsKey(val))
                {
                    StoreStackReference[val].Add(newNode);
                }
                else
                {
                    List<Node> listOfNode = new List<Node>();
                    listOfNode.Add(newNode);
                    StoreStackReference.Add(val, listOfNode);
                }
                stack = newNode;                
            }
        }

        public void Pop()
        {
            if (stack == null)
                return;
            if(stack.Next==null && stack.Previous == null)
            {
                stack = null;
                StoreStackReference = null;
                return;
            }
            var x = StoreStackReference[stack.value];
            if (x.Count == 1)
            {
                StoreStackReference.Remove(stack.value);
            }
            else
            {
                x.RemoveAt(x.Count - 1);

            }
            Node newNode = new Node();
            newNode = stack.Next;
            stack = newNode;
            stack.Previous = null;
        }
        public int Top()
        {
            if (stack == null)
                return -1;
            return stack.value;
        }

        public int GetMax()
        {
            if (stack == null)
                return -1;
            if (StoreStackReference == null)
                return -1;
            return StoreStackReference.ElementAt(StoreStackReference.Count-1).Key;
        }

        public void RemoveMaxVal()
        {
            if (stack == null)
                return;

            if (stack.Next == null && stack.Previous == null)
            {
                stack = null;
                StoreStackReference = null;
                return;
            }

            var x = StoreStackReference.ElementAt(StoreStackReference.Count - 1);
            if (x.Value.Count == 1)
            {
                Node newNode = new Node();
                if (x.Value[0].Next == null)
                {
                   
                    newNode = x.Value[0].Previous;
                    newNode.Next = null;
                }
                else
                {
                    newNode = x.Value[0].Previous;
                    newNode.Next.Next.Previous = newNode;
                    newNode.Next = newNode.Next.Next;
                    
                }
               

                StoreStackReference.Remove(x.Key);
            }
            else
            {
                Node newNode = new Node();
                if (x.Value[0].Next == null)
                {
                    newNode = x.Value[0].Previous;
                    newNode.Next = null;
                }
                else
                {
                    newNode = x.Value[0].Previous;
                    newNode.Next.Next.Previous = newNode;
                    newNode.Next = newNode.Next.Next;

                }
                x.Value.RemoveAt(0);

            }
        }
    }
}
