using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.DataStructureLinkedList
{
    public class MyDoublyLinkedLList<T>
    {
        internal NodeDoubleLinkedList<T> head;
        internal NodeDoubleLinkedList<T> tail;
        internal int lenght;
        public MyDoublyLinkedLList(T value)
        {
            NodeDoubleLinkedList<T> new_node = new NodeDoubleLinkedList<T>(value);
            head = new_node;
            tail = head;
            lenght = 1;
        }
        /// <summary>
        /// A method for adding to the last item of [MyLinkedList]
        /// </summary>
        /// <param name="new_data"></param>
        internal void Append(T new_data)
        {
            NodeDoubleLinkedList<T> new_node = new NodeDoubleLinkedList<T>(new_data);
            new_node.previous = tail;
            tail.next = new_node;
            tail = new_node; lenght++; 
        }
        /// <summary>
        /// A method for adding to the first item of [MyLinkedList]
        /// </summary>
        /// <param name="new_data"></param>
        internal void Prepend(T new_data) 
        { 
            NodeDoubleLinkedList<T> new_node = new NodeDoubleLinkedList<T>(new_data);
            new_node.next = head;
            head.previous = new_node;
            head = new_node; lenght++; 
        }
        internal List<Tuple<T, T>> PrintList()
        {
            List<Tuple<T,T>> list = new List<Tuple<T, T>>() ;
            var currentNodeDoubleLinkedList = head;
            var currentNodeDoubleLinkedListBack = tail;
            while (currentNodeDoubleLinkedList != null)
            {
                list.Add(new Tuple<T,T>(currentNodeDoubleLinkedList.data, currentNodeDoubleLinkedListBack.data));
                currentNodeDoubleLinkedList = currentNodeDoubleLinkedList.next;
                currentNodeDoubleLinkedListBack = currentNodeDoubleLinkedListBack.previous;
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
           
            NodeDoubleLinkedList<T> new_node = new NodeDoubleLinkedList<T>(data);

            var leader = TraveseToIndex(index - 1);
            var follower = leader.next;
            leader.next = new_node;
            new_node.previous = leader;
            new_node.next = follower;
            follower.previous = new_node;
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
                NodeDoubleLinkedList<T> itemAtBeforeIndex = TraveseToIndex(index - 1);
                ///A a pointer from the value aster the index to the value before the index
                itemAtBeforeIndex.next.next.previous = itemAtBeforeIndex;
                ///A a pointer from the value before the index to the value after the index
                itemAtBeforeIndex.next = itemAtBeforeIndex.next.next;

            }
        }
        /// <summary>
        /// A  method that remove the first item from 
        /// [MyLinkedList] by making the pointer of the 
        /// current head.Next to be the Current Head
        /// </summary>
        internal void RemoveFirst() 
        { 
            head = head.next;
            head.previous = null;
            lenght--; 
        }
        /// <summary>
        /// by going through the [MyLinkedList] and 
        /// making the pointet of the second to the last
        /// item the new tail
        /// </summary>
        internal void RemoveLast() 
        { 
            var itemAtIndex = TraveseToIndex(lenght - 2);
            tail = itemAtIndex;
            tail.next = null;
            lenght--; 
        }

        NodeDoubleLinkedList<T> TraveseToIndex(int index)
        {
            int count = 0;
            var currentNodeDoubleLinkedList = head;
            while (count != index)
            {
                currentNodeDoubleLinkedList = currentNodeDoubleLinkedList.next;
                count++;
            }
            return currentNodeDoubleLinkedList;
        }
        bool OutOfRange(int index) => (index! > 0 && index! < lenght - 1);
        internal void InsertLast(T new_data)
        {
            NodeDoubleLinkedList<T> new_node = new NodeDoubleLinkedList<T>(new_data);
            if (head == null)
            {
                head = new_node;
                return;
            }
            //NodeDoubleLinkedList lastNodeDoubleLinkedList = GetLastNodeDoubleLinkedList(singlyList);
            // lastNodeDoubleLinkedList.next = new_node;
        }
    }
    public class NodeDoubleLinkedList<T>
    {
        public T data;
        public NodeDoubleLinkedList<T> next;
        public NodeDoubleLinkedList<T> previous;
        public NodeDoubleLinkedList(T d)
        {
            data = d;
            next = null;
            previous = null;
        }
    }
}
