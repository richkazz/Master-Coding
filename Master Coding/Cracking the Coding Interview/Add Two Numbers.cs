using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.Cracking_the_Coding_Interview
{
    public class Add_Two_Numbers
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
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            ListNode head = null;
            ListNode current = null;
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int val1 = (l1 == null) ? 0 : l1.val;
                int val2 = (l2 == null) ? 0 : l2.val;
                int sum = val1 + val2 + carry;

                ListNode newNode = new ListNode { val = sum % 10 };
                carry = sum / 10;
                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;

                if (head == null)
                {
                    head = newNode; current = newNode;
                }
                else
                {
                    current.next = newNode;
                    current = newNode;
                }
            }
            if (carry == 1)
            {
                ListNode newNode = new ListNode { val = 1 };
                current.next = newNode;
            }

            return head;
        }
        public ListNode AddTwoNumbers1(ListNode l1, ListNode l2)
        {
            l1 = CreateNewLinkedList(new char[] {'9','9','9','9','9','9','9','9','9','9','9' } );
            l2 = CreateNewLinkedList(new char[] { '9', '9', '9', '9' }); 

            List<int> hold = new List<int>();
            GetValues(hold, l1);
            Reverse(hold);
            var sumL1 = BigInteger.Parse(AsString(hold));
            hold = new List<int>();
            GetValues(hold, l2);
            Reverse(hold);
            var sumL2 = BigInteger.Parse(AsString(hold));
            var total = (sumL1 + sumL2).ToString().ToArray();
            Reverse(total);
            return CreateNewLinkedList(total);
        }
        string AsString(List<int> hold)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(var item in hold)
            {
                stringBuilder.Append(item);
            }
            return stringBuilder.ToString();
        }
        ListNode CreateNewLinkedList(char[] total)
        {
            ListNode node = new ListNode();
            var result = node;
            foreach (var item in total)
            {
               var newNode = new ListNode(int.Parse(item.ToString()));
                node.next = newNode;
                node = newNode;
            }
            return result.next;
        }
        void GetValues(List<int> hold, ListNode l)
        {
            while (l != null)
            {
                hold.Add(l.val);
                l = l.next;
            }
        }
        void Reverse(List<int> hold)
        {
            int i = 0;
            int j = hold.Count - 1;
            while (i < j)
            {
                Swap(hold, i++, j--);
            }
        }
        void Reverse(char[] hold)
        {
            int i = 0;
            int j = hold.Length - 1;
            while (i < j)
            {
                Swap(hold, i++, j--);
            }
        }
        void Swap(List<int> hold, int i, int j)
        {
            var temp = hold[i];
            hold[i] = hold[j];
            hold[j] = temp;
        }
        void Swap(char[] hold, int i, int j)
        {
            var temp = hold[i];
            hold[i] = hold[j];
            hold[j] = temp;
        }
    }
}
