using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.Trees
{
    public class Contacts_application
    {
        public class Node
        {
            public int wordsCount;
            public Dictionary<char, Node> Character;
            public bool isWord = false;
            public Node()
            {
                wordsCount = 0;
                Character = new Dictionary<char, Node>();
            }
        }
        Node Root = new Node();
        public List<int> contacts(List<List<string>> queries)
        {
            var result = new List<int>();
            foreach (var item in queries)
            {
                if (item[0] == "add")
                {
                    Add(item[1]);
                }
                else
                {
                   result.Add( Find(item[1]));
                }
            }
            return result;
        }
        int numWordss = 0;
        int Find(string partial)
        {
            numWordss = 0;

            if (!Root.Character.Any())
                return 0;
            var currentNode = Root.Character['\0'];
            int count = 0;
            foreach (char word in partial)
            {
                count++;
                if (currentNode.Character.ContainsKey(word))
                {
                    if (count == partial.Length)
                    {
                        if (currentNode.Character[word].isWord == true)
                        {
                            return currentNode.wordsCount;
                            //numWordss++;
                        }
                    }
                   
                    currentNode = currentNode.Character[word];
                }
                else
                {
                    return 0;
                }
            }

            if (currentNode.Character.Any())
            {
                return currentNode.wordsCount;
                //branches(currentNode);
            }
            return numWordss;
        }
       
       
        void Add(string words)
        {
            if (!Root.Character.Any())
            {
                Root.Character.Add('\0', new Node());
            }
            int count = 0;
            var currentNode = Root.Character['\0'];
            currentNode.wordsCount++;
            foreach (char word in words)
            {
                count++;
                if (!currentNode.Character.Any())
                {
                    currentNode.Character.Add(word, new Node());
                    currentNode.wordsCount++;
                    currentNode = currentNode.Character[word];
                    if (count == words.Length)
                    {
                        currentNode.isWord = true;
                    }
                }
                else
                {
                    if (currentNode.Character.ContainsKey(word))
                    {
                        currentNode.wordsCount++;
                        currentNode = currentNode.Character[word];
                    }
                    else
                    {
                        currentNode.Character.Add(word, new Node());
                        currentNode.wordsCount++;
                        currentNode = currentNode.Character[word];
                        if (count == words.Length)
                        {
                            currentNode.isWord = true;
                        }
                    }
                }
            }
        }
        void branches(Node node)
        {
            foreach (var nod in node.Character)
            {
                if (nod.Value.isWord == true)
                {
                    numWordss++;
                }
                if (nod.Value.Character.Count != 0)
                {
                    branches(nod.Value);
                }
            }

        }
    }
}
