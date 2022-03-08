using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.Cracking_the_Coding_Interview
{
    public  class Remove_Duplicates_from_Sorted_List_II
    {
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
        public ListNode DeleteDuplicates(ListNode head)
        {
           //head = new ListNode(1, new ListNode(1, new ListNode(3, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6, new ListNode(6))))))));
            //head = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(3)))));
            head = new ListNode(1, new ListNode(1));
            if (head == null)
                return head;
            if (head.next == null)
                return head;

            var currentNode = head;
            var holdPrevious = currentNode;
            int checkerValue = head.val;
            bool isDuplicate = false;
            if (holdPrevious.val == holdPrevious.next.val)
            {
                //Remove beginning duplicate
                holdPrevious = RemoveStartingDuplicate(holdPrevious);
                if (holdPrevious != null)
                {
                    head = holdPrevious;
                    currentNode = holdPrevious;
                    checkerValue = currentNode.val;
                }
                else
                {
                    return null;
                }
                
            }
            
            while (currentNode.next != null)
            {
                if (currentNode.next.val != checkerValue)
                {
                    
                    if (isDuplicate)
                    {
                        holdPrevious.next = currentNode.next;
                        checkerValue = currentNode.next.val;
                        isDuplicate = false;
                    }
                    else
                    {
                        checkerValue = currentNode.next.val;
                        holdPrevious = currentNode;
                    }
                   
                }
                else
                {
                    isDuplicate = true;
                }
                currentNode = currentNode.next;
            }
            if (isDuplicate)
            {
                holdPrevious.next = null;
            }
            
            return head;
        }
        ListNode RemoveStartingDuplicate(ListNode holdPrevious)
        {
            bool onlyDuplicate = false;

            while (holdPrevious.next != null)
            {
                if (holdPrevious.val != holdPrevious.next.val)
                {

                    onlyDuplicate = false;
                    holdPrevious = holdPrevious.next;
                    if (holdPrevious.next == null)
                        return holdPrevious;
                    if (holdPrevious.val == holdPrevious.next.val)
                    {

                    }
                    else
                    {
                        break;
                    }

                }
                else
                {
                    onlyDuplicate = true;
                    holdPrevious = holdPrevious.next;
                }
            }
            if (!onlyDuplicate)
                return holdPrevious;
            return null;
        }
    }
}
