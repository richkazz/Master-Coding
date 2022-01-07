using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.Trees
{
    public class BinarySearchTree
    {
        Node Root;
        public BinarySearchTree()
        {
            Root = null;
        }
        public void Insert(int value)
        {
            Node newNode = new Node(value);
            if (Root == null)
            {
                Root = newNode;
                return;
            }
                
            var currentNode = Root;
            while (true)
            {
                if (value >= currentNode.Value)
                {
                    if (currentNode.Right == null)
                    {
                        currentNode.Right = newNode;
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.Right;
                    }

                }
                else
                {
                    if (currentNode.Left == null)
                    {
                        currentNode.Left = newNode;
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.Left;
                    }

                }
            }
           
            //Code here
        }
        public bool Lookup(int value)
        {
            if (Root == null)
            {
               
                return false;
            }
            var currentNode = Root;
            while (currentNode != null)
            {
                if (value < currentNode.Value)
                {
                    currentNode = currentNode.Left;

                }
                else if(value > currentNode.Value)
                {
                    currentNode = currentNode.Right;

                }
                else if (value == currentNode.Value)
                {
                    return true;
                }
                
            }

            //Code here
            return false;
        }
        public void Remove(int value)
        {
            if (Root == null)
            {

                return;
            }
            var currentNode = Root;
            Node parentNode = null;
            while (currentNode != null)
            {
                if (value < currentNode.Value)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.Left;

                }
                else if (value > currentNode.Value)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.Right;
                }
                else if (value == currentNode.Value)
                {
                    if(currentNode.Right == null)
                    {
                        if(parentNode == null)
                        {
                            Root = currentNode.Left;
                        }
                        else
                        {
                            if (currentNode.Value < parentNode.Value)
                            {
                                parentNode.Left = currentNode.Left;
                            }else if(currentNode.Value > parentNode.Value)
                            {
                                parentNode.Right = currentNode.Left;
                            }

                        }
                    }
                    else if (currentNode.Right.Left == null)
                    {
                        if (parentNode == null)
                        {
                            Root = currentNode.Left;
                        }
                        else
                        {
                            currentNode.Right.Left = currentNode.Left;
                        }
                        if (currentNode.Value < parentNode.Value)
                        {
                            parentNode.Left = currentNode.Right;
                        }
                        else if (currentNode.Value > parentNode.Value)
                        {
                            parentNode.Right = currentNode.Right;
                        }
                    }
                    else
                    {
                        //find the Right child's left most child
                        var leftmost = currentNode.Right.Left;
                        var leftmostParent = currentNode.Right;
                        while (leftmost.Left != null)
                        {
                            leftmostParent = leftmost;
                            leftmost = leftmost.Left;
                        }

                        //Parent's left subtree is now leftmost's right subtree
                        leftmostParent.Left = leftmost.Right;
                        leftmost.Left = currentNode.Left;
                        leftmost.Right = currentNode.Right;

                        if (parentNode == null)
                        {
                            Root = leftmost;
                        }
                        else
                        {
                            if (currentNode.Value < parentNode.Value)
                            {
                                parentNode.Left = leftmost;
                            }
                            else if (currentNode.Value > parentNode.Value)
                            {
                                parentNode.Right = leftmost;
                            }
                        }
                    }
                }
                    
                    return;
                
            }

        }
        public List<int> BredthFirstSearchR(List<int> list, Queue<Node> queue)
        {
            

            if (queue.Count == 0)
            {
                return list;
            }
            var currentNode = queue.Dequeue();
            list.Add(currentNode.Value);
            if (currentNode.Left != null)
            {
                queue.Enqueue(currentNode.Left);
            }
            if (currentNode.Right != null)
            {
                queue.Enqueue(currentNode.Right);
            }
            return BredthFirstSearchR(list,queue);
        }
        public List<int> BredthFirstSearch()
        {
            var currentNode = Root;
            var list = new List<int>();
            var queue = new Queue<Node>();
            queue.Enqueue(currentNode);
            var ss = BredthFirstSearchR(list, queue);
            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                list.Add(currentNode.Value);
                if (currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }
                if(currentNode.Right!= null)
                {
                    queue.Enqueue(currentNode.Right);
                }
            }
            return list;
        }

        public List<int> DFSInOrder()
        {
            return TraverseInOrder(Root, new List<int>() { });
        }
        public List<int> DFSPostOrder()
        {
            return TraversePostOrder(Root, new List<int>() { });

        }
        public List<int> DFSPreOrder()
        {
            return TraversePreOrder(Root, new List<int>() { });
        }

        List<int> TraversePostOrder(Node node, List<int> list)
        {
            if (node.Left != null)
            {
                TraversePostOrder(node.Left, list);
            }
            if (node.Right != null)
            {
                TraversePostOrder(node.Right, list);
            }
            list.Add(node.Value);
            return list;
        }
        List<int> TraversePreOrder(Node node, List<int> list)
        {
            list.Add(node.Value);
            if (node.Left != null)
            {
                TraversePreOrder(node.Left, list);
            }
            if (node.Right != null)
            {
                TraversePreOrder(node.Right, list);
            }
            return list;
        }
        List<int> TraverseInOrder(Node node,List<int> list)
        {
            if(node.Left !=null)
            {
                TraverseInOrder(node.Left, list);
            }
            list.Add(node.Value);
            if(node.Right !=null)
            {
                TraverseInOrder(node.Right, list);
            }

            return list;
        }

    }
    public class Node
    {
        public Node Left;
        public Node Right;
        public int Value;
        public Node(int value)
        {
            Left = null;
            Right = null;
            Value = value;
        }
    }
}
