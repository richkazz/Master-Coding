using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.Graphs
{
    public class Graph
    {
        int numberOfNodes;
        Dictionary<int, List<int>> adjacentList;
        public Graph()
        {
            numberOfNodes = 0;
            adjacentList = new Dictionary<int, List<int>>();
        }
        public void addVertex(int Node)
        {
            if (!adjacentList.ContainsKey(Node))
            {
                adjacentList.Add(Node, new List<int>());
                numberOfNodes++;
            }
           
        }

        void addEdges(int node1,int node2)
        {
            if (adjacentList.ContainsKey(node1)&&adjacentList.ContainsKey(node2))
            {
                adjacentList[node1].Add(node2);
                adjacentList[node2].Add(node1);
            }
        }
    }
}
