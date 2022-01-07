using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.DataStructureLinkedList
{

    public class MyLinkedList<T>
    {
        internal Node<T> head;
        internal Node<T> tail;
        internal int lenght;
        public MyLinkedList(T value)
        {
            Node<T> new_node = new Node<T>(value);
            head = new_node;
            tail = head;
            lenght = 1;
        }
        /// <summary>
        /// A method for adding to the last item of [MyLinkedList]
        /// </summary>
        /// <param name="new_data"></param>
        internal void Append(T new_data) { Node<T> new_node = new Node<T>(new_data); tail.next = new_node; tail = new_node; lenght++; }
        /// <summary>
        /// A method for adding to the first item of [MyLinkedList]
        /// </summary>
        /// <param name="new_data"></param>
        internal void Prepend(T new_data) { Node<T> new_node = new Node<T>(new_data); new_node.next = head; head = new_node; lenght++; }
        internal List<T> PrintList()
        {
            List<T> list = new List<T>();
            var currentNode = head;
            while (currentNode != null)
            {
                list.Add(currentNode.data);
                currentNode = currentNode.next;
            }
            return list;
        }

        internal void Insert(int index, T data)
        {

            if (index >= lenght - 1)
            {
                Append(data);
                return;
            }
            if (index! < 0)
            {
                Prepend(data);
                return;
            }

            Node<T> new_node = new Node<T>(data);

            var leader = TraveseToIndex(index - 1);
            var holdingPointer = leader.next;
            leader.next = new_node;
            new_node.next = holdingPointer;
            lenght++;
        }
        /// <summary>
        /// Remove at a specified index by geting the item 
        /// before the specified index and creating a pointer from the 
        /// item.Next to the item.Next.Next
        /// </summary>
        /// <param name="index"></param>
        internal void Remove(int index)
        {
            ///if it is the first item
            if (index == 0)
            {
                RemoveFirst();
            }
            ///If it is the last item
            if (index == lenght - 1)
            {
                RemoveLast();
            }
            ///Check if the index exit
            if (OutOfRange(index))
            {
                ///get a pointer to the value before the index
                Node<T> itemAtBeforeIndex = TraveseToIndex(index - 1);
                ///A a pointer from the value before the index to the value after the index
                itemAtBeforeIndex.next = itemAtBeforeIndex.next.next;

            }
        }
        /// <summary>
        /// A  method that remove the first item from 
        /// [MyLinkedList] by making the pointer of the 
        /// current head.Next to be the Current Head
        /// </summary>
        internal void RemoveFirst() { head = head.next; lenght--; }
        /// <summary>
        /// by going through the [MyLinkedList] and 
        /// making the pointet of the second to the last
        /// item the new tail
        /// </summary>
        internal void RemoveLast() { var itemAtIndex = TraveseToIndex(lenght - 2); tail = itemAtIndex; tail.next = null; lenght--; }
        internal void Reverse()
        {
            if(head.next == null)
            {
                return;
            }
            ///Create a new [MyLinkedList] with the value head.data
            var myLinkedList = new MyLinkedList<T>(head.data);

            head = head.next;
            while (head != null)
            {
                myLinkedList.Prepend(head.data);
                head = head.next;
            }
            head = myLinkedList.head;
            tail = myLinkedList.tail;
            
        }
        internal void Reverse1()
        {
            if(head.next == null)
            {
                return;
            }
            var first = head;
            tail = head;
            var second = first.next;
            while(second != null)
            {
                Node<T> temp = new Node<T>( second.data);
                temp.next = second.next;
                second.next = first;
                first = second;
                second = temp.next;
            }
            head.next = null;
            head = first;
        }

        List<T> GetDataAsList()
        {
            List<T> keepData = new List<T>();
            while (head != null)
            {
                keepData.Add(head.data);
                head = head.next;
            }
            return keepData;
        }
        Node<T> TraveseToIndex(int index)
        {
            int count = 0;
            var currentNode = head;
            while (count != index)
            {
                currentNode = currentNode.next;
                count++;
            }
            return currentNode;
        }
        bool OutOfRange(int index) => (index! > 0 && index! < lenght - 1);
        internal void InsertLast(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            if (head == null)
            {
                head = new_node;
                return;
            }
            //Node lastNode = GetLastNode(singlyList);
            // lastNode.next = new_node;
        }

    }

    class Node<T>
    {
        public T data;
        public Node<T> next;
        public Node(T d)
        {
            data = d;
            next = null;
        }
    }
}
