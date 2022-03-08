using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public static class Swap_Nodes_in_Pairs
    {
        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null ||head.next == null)
                return head;
            var current = head;
            var temp = new ListNode();
            
            var tail = new ListNode();
            head = current.next;
            tail = head;
            int i = 0;
            while (current!= null&&current.next != null)
            {
                temp = current.next.next;
                current = current.next;
                current.next = current;
                current.next.next = temp;
                if(i == 1)
                {
                    
                    tail.next = current;
                    tail = tail.next.next;
                    
                }
                else
                {
                    tail = tail.next;
                    i = 1;
                }
                current = temp;


            }
            return head;
        }
    }
}
