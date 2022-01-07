using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Words_Data_Structure
    {
        public class Node
        {
            public Dictionary<char, Node> Character;
            public bool isWord;
            public Node()
            {
                Character = new Dictionary<char, Node>();
                isWord = false;
            }
        }
        Node Root;
        public Words_Data_Structure()
        {
            var newNode = new Node();
            newNode.Character['\0'] = new Node();
            Root = newNode;
        }

        public void AddWord(string word)
        {
            var currentNode = Root.Character['\0'];
            int count = 0;
            foreach (char cha in word)
            {
                count++;
                if (!Root.Character['\0'].Character.Any())
                {
                    currentNode.Character[cha] = new Node();
                }
                if (currentNode.Character.ContainsKey(cha))
                {
                    if (count == word.Length)
                    {
                        currentNode.Character[cha].isWord = true;
                        return;
                    }
                    currentNode = currentNode.Character[cha];

                }
                else
                {

                    currentNode.Character[cha] = new Node();
                    if (count == word.Length)
                    {
                        currentNode.Character[cha].isWord = true;
                    }
                    currentNode = currentNode.Character[cha];
                }


            }
        }

        public bool Search(string word)
        {
            if (!Root.Character['\0'].Character.Any())
                return false;
            int count = 0;
            var currentNode = Root.Character['\0'];
            var keep = word;
            foreach (char cha in word)
            {
                count++;
                if (currentNode.Character.ContainsKey(cha))
                {
                    keep = keep.Substring(1);
                    currentNode = currentNode.Character[cha];
                    if (count == word.Length && currentNode.isWord == true)
                    {
                        return true;
                    }
                }
                else if(cha=='.')
                {
                    
                    return DFSPreOrder(currentNode, keep, count);
                }
                else
                {
                    return false;
                }


            }
            return false;
        }
        public bool Search(string word,Node node)
        {
            if (!node.Character.Any())
                return false;
            int count = 0;
            var currentNode = node;
            var keep = word;

            foreach (char cha in word)
            {
                count++;
                if (currentNode.Character.ContainsKey(cha))
                {
                    keep = keep.Substring(1);

                    currentNode = currentNode.Character[cha];
                    if (count == word.Length && currentNode.isWord == true)
                    {
                        return true;
                    }
                }
                else if(cha=='.')
                {
                    
                    return DFSPreOrder(currentNode,keep,count);
                }
                else
                {
                    return false;
                }


            }
            return false;
        }

        bool TraversePreOrder(Node node, string word, int index)
        {
            if (string.IsNullOrEmpty(word))
                return false;
            foreach(var cha in node.Character.Keys)
            {
                if (word == "." && node.Character[cha].isWord == true)
                {
                    return true;
                }
                if (node.Character[cha].Character.Any()&&word.Length>1)
                {
                    var result = Search(word.Substring(1), node.Character[cha]);
                    if (result == true)
                    {
                        return result;
                    }
                   
                }
            }
            return false;
        }
        bool DFSPreOrder(Node node, string word,int index)
        {
            return TraversePreOrder(node,word,index);
        }

    }
}
