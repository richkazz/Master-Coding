using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
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
    public class Design_Linked_List
    {
        Node tail;
        Node head;
        int length = 0;
        public Design_Linked_List()
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
                
                length++;
            }
            
        }

        public void DeleteAtIndex(int index)
        {
            if (index >= length || head == null)
                return;
            else if (index == 0)
                head = head.next;
            else
            {
                var current = getNode(index - 1);
                if (current.next != null)
                {
                    current.next = current.next.next;
                    if (index == length - 1)
                        tail = current;
                }
            }

            length--;
        }

        Node getNode(int index)
        {
            if (index == 54)
            {
                int u = 0;
            }
                
            int i = 0;
            var current = head;
            while (i < index)
            {
                if (i == 45)
                {
                    int u = 0;
                }
                current = current.next;
                i++;
            }
            return current;
        }

        public void Testing(string[] method, string value, Design_Linked_List design_Linked_List)
        {
            var temp = value.Split(",");
            var list = new List<string>();
            var c = 2;
            for (var i = 1; i < temp.Length; i++)
            {
                var hold = "";
                bool addIndex = true;
                for (var j = 0; j < temp[i].Length; j++)
                {
                    if (temp[i][0] != '[' && addIndex)
                    {

                        list[i - c] += '|';
                        addIndex = false;
                    }
                    if ((temp[i][j] != '[' && temp[i][j] != ']') && addIndex)
                    {
                        hold += temp[i][j];

                    }
                    else
                    {
                        if (temp[i][j] != ']' && !addIndex)
                            list[i - c] += temp[i][j];
                    }
                }
                if (hold != "")
                    list.Add(hold);
                else
                    c++;

            }
            int u = 1;
            foreach (var item in list)
            {
                if (item.Contains("|"))
                {
                    var k = item.Split("|");
                    design_Linked_List.AddAtIndex(int.Parse(k[0]), int.Parse(k[1]));
                }
                else
                {
                    if (item == "54")
                    {
                        int uio = 0;
                    }
                    if (method[u] == "addAtHead")
                        design_Linked_List.AddAtHead(int.Parse(item));
                    else if (method[u] == "addAtTail")
                        design_Linked_List.AddAtTail(int.Parse(item));
                    else if (method[u] == "get")
                        Console.WriteLine(design_Linked_List.Get(int.Parse(item)));
                    else
                        design_Linked_List.DeleteAtIndex(int.Parse(item));

                }
                u++;
            }
        }
    }
}
