using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureApp
{
    public class GraphNode
    {

        public int value { get; set; }
        public List<GraphNode> neighbors { get; set; }

        public GraphNode(int value)
        {
            this.value = value;
            neighbors = new List<GraphNode>();
        }

        public void AddNeighbor(GraphNode neighbor)
        {
            neighbors.Add(neighbor);
        }
        public override string ToString()
        {
            StringBuilder nodeString = new StringBuilder();
            nodeString.Append("Node Value : " + value + "Neighbors");
            foreach (var item in neighbors)
            {
                nodeString.Append(" -> " + item.value);
            }
            return nodeString.ToString();
        }
    }

    public class MyGraph
    {
        List<GraphNode> graphNodes = new List<GraphNode>();


        //add node

        public GraphNode AddNode(int value)
        {
            GraphNode newNode = new GraphNode(value);
            graphNodes.Add(newNode);
            return newNode;

        }
        // add edge
        public void AddEdge(GraphNode node1, GraphNode node2)
        {

            if (Exists(node1.value) != null && Exists(node2.value) != null)
            {
                node1.AddNeighbor(node2);
            }
        }

        public GraphNode Exists(int value)
        {
            foreach (GraphNode item in graphNodes)
            {
                if (item.value.Equals(value))
                {
                    return item;
                }
            }
            return null;
        }

        //get nodes
        public IList<GraphNode> GetNodes()
        {
            return graphNodes.AsReadOnly();
        }


        //size the total number of nodes in the graph
        public int Size()
        {
            return graphNodes.Count;
        }

       public List<GraphNode> BreadthFirst(GraphNode node)
       {
            List<GraphNode> nodes = new List<GraphNode>();
            Queue<GraphNode> breadth = new Queue<GraphNode>();
            List<GraphNode> visited = new List<GraphNode>();

            breadth.Enqueue(node);
            visited.Add(node);

            while(breadth != null)
            {
                GraphNode front = breadth.Dequeue();
                nodes.Add(front);

                foreach(GraphNode item in front.neighbors)
                {
                    if (!visited.Contains(item))
                    {
                        visited.Add(item);
                        breadth.Enqueue(item);
                    }
                }
            }

            return nodes;


        }


        public HashSet<GraphNode> DFS(MyGraph graph, GraphNode start)
        {
            var visited = new HashSet<GraphNode>();
            
            if (graph.Exists(start.value) != null)
                return visited;

            var stack = new Stack<GraphNode>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                var vertex = stack.Pop();

                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                foreach (var neighbor in graph.graphNodes)
                    if (!visited.Contains(neighbor))
                        stack.Push(neighbor);
            }

            return visited;
        }
    }
}
