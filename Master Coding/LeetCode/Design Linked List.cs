using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Design_Linked_List
    {
        class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        public class MyLinkedList
        {
            Node tail;
            Node head;
            int length = 0;
            public MyLinkedList()
            {
                tail = head;
            }

            public int Get(int index)
            {
                if (head == null || index >= length)
                    return -1;
                if (index == length - 1)
                {
                    return tail.data;
                }
                else if (index == 0)
                {
                    return head.data;
                }
                var current = getNode(index);
                return current.data;
            }

            public void AddAtHead(int val)
            {
                length++;
                if (head == null)
                {
                    head = new Node(val);
                    tail = head;
                    return;
                }
                var newNode = new Node(val);
                newNode.next = head;
                head = newNode;
            }

            public void AddAtTail(int val)
            {
                length++;
                if (head == null)
                {
                    head = new Node(val);
                    tail = head;
                    return;
                }
                var newNode = new Node(val);
                tail.next = newNode;
                tail = newNode;
            }

            public void AddAtIndex(int index, int val)
            {
                if (index == length)
                {
                    AddAtTail(val);
                }
                else if (index == 0)
                {
                    AddAtHead(val);
                }
                else if (index < 0 || index > length)
                {
                    return;
                }
                else
                {
                    var current = getNode(index - 1);
                    var newNode = new Node(val);
                    newNode.next = current.next;
                    current.next = newNode;

                }
                length++;
            }

            public void DeleteAtIndex(int index)
            {
                if (index < 0 || index > length)
                    return;
                var current = getNode(index - 1);
                if (current.next != null)
                {
                    current.next = current.next.next;
                }
                length--;
            }
            Node getNode(int index)
            {
                int i = 0;
                var current = head;
                while (i < index)
                {
                    current = current.next;
                    i++;
                }
                return current;
            }
        }

        /**
         * Your MyLinkedList object will be instantiated and called as such:
         * MyLinkedList obj = new MyLinkedList();
         * int param_1 = obj.Get(index);
         * obj.AddAtHead(val);
         * obj.AddAtTail(val);
         * obj.AddAtIndex(index,val);
         * obj.DeleteAtIndex(index);
         */
    }
}
