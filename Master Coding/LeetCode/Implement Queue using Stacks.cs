using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Implement_Queue_using_Stacks
    {
        Stack<int> Queue;
        public Implement_Queue_using_Stacks()
        {
            Queue = new Stack<int>();
        }

        public void Push(int x) 
        {
            Queue.Push(x);
        }

        public int Pop()=> Queue.Pop();

        public int Peek() => Queue.Peek();

        public bool Empty() => Queue.Any()?false:true;
      
    }
}
