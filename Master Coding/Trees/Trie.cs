using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.Trees
{
    public class Trie
    {
        public class Node
        {
            public Dictionary<char, Node> Character ;
            public bool isWord;
            public Node()
            {
                Character = new Dictionary<char, Node>();
                isWord = false;
            }
        }
        Node Root;
        public Trie()
        {
            var newNode = new Node();
            newNode.Character['\0'] = new Node();
            Root = newNode;
        }

        public void Insert(string word)
        {
            var currentNode = Root.Character['\0'];
            int count = 0;
            foreach(char cha in word)
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
            foreach (char cha in word)
            {
                count++;
                if (currentNode.Character.ContainsKey(cha))
                {
                    currentNode = currentNode.Character[cha];
                    if (count == word.Length&& currentNode.isWord ==true)
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }


            }
            return false;
        }
        public bool Search1(string word)
        {
            if (!Root.Character['\0'].Character.Any())
                return false;
            int count = 0;
            var currentNode = Root.Character['\0'];
            for(var i = 0; i < word.Length; i++)
            {

            }
            return false;
        }
       
        public bool StartsWith(string prefix)
        {
            if (!Root.Character['\0'].Character.Any())
                return false;
            var currentNode = Root.Character['\0'];
            foreach (char cha in prefix)
            {
                if (currentNode.Character.ContainsKey(cha))
                {
                    currentNode = currentNode.Character[cha];
                   
                }
                else
                {
                    return false;
                }


            }
            return true;
        }
    }
    
}
