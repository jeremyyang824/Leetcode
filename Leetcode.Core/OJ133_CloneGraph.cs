using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Clone an undirected graph. Each node in the graph contains a label and a list of its neighbors.
     */
    public class OJ133_CloneGraph
    {
        public UndirectedGraphNode CloneGraph(UndirectedGraphNode node)
        {
            if (node == null)
                return null;

            Queue<UndirectedGraphNode> queue = new Queue<UndirectedGraphNode>();    //old
            Dictionary<UndirectedGraphNode, UndirectedGraphNode> map = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();  //old, new

            UndirectedGraphNode newHead = new UndirectedGraphNode(node.label);
            queue.Enqueue(node);
            map.Add(node, newHead);

            //BFS
            while (queue.Count > 0)
            {
                UndirectedGraphNode oldNode = queue.Dequeue();
                IList<UndirectedGraphNode> oldNeighbors = oldNode.neighbors;

                foreach (UndirectedGraphNode oldNeighbor in oldNeighbors)
                {
                    if (!map.ContainsKey(oldNeighbor))
                    {
                        //to travel
                        queue.Enqueue(oldNeighbor);

                        //build new node
                        UndirectedGraphNode newNode = new UndirectedGraphNode(oldNeighbor.label);
                        map.Add(oldNeighbor, newNode);
                    }

                    //build relation
                    map[oldNode].neighbors.Add(map[oldNeighbor]);
                }
            }
            return newHead;
        }
    }

    public class UndirectedGraphNode
    {
        public int label;
        public IList<UndirectedGraphNode> neighbors;
        public UndirectedGraphNode(int x)
        {
            label = x; neighbors = new List<UndirectedGraphNode>();
        }
    };
}
