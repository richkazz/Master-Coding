using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class RotateRight
    {
        ListNode tail;
        ListNode last;
        public RotateRight()
        {
            tail = new ListNode();
            last = new ListNode();
        }
        public ListNode RotateRight1(ListNode head, int k)
        {
            if (head == null)
                return head;
            if (head.next == null)
                return head;
            var currentNode = head;
            int length = 0;
            while (currentNode != null)
            {
                last = currentNode;
                length++;
                currentNode = currentNode.next;
            }

            int count = 0;
            if (k > length)
            {
                count = k%length;
                count = length - count;
                if (count == length)
                    return head;
            }
            else
            {
                count = length - k;
            }
            int i = 0;
            currentNode = head;
            while (currentNode.next != null)
            {
                i++;
                tail = currentNode;
                if (i == count)
                    break;
                currentNode = currentNode.next;
            }

            ListNode newNode =new ListNode( tail.next.val,tail.next.next) ;
            tail.next = null;
            last.next = head;
            head = last;
            if (newNode.next == null)
            {
                head = last;
            }
            else
            {
                head = newNode;
            }
           
            
            return head;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
