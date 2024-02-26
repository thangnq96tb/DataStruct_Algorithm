using System;
using System.Collections.Generic;

namespace ReviewCode
{
    public class Graph 
    {
        private int V; 
        private Dictionary<int, List<int>> adj;

        public Graph(int v)
        {
            V = v;
            for (int i = 0; i < v; ++i)
            {
                adj = new Dictionary<int, List<int>>();
            }
        }

        public void AddEdge(int v, int w)
        {
            if (!adj.ContainsKey(v))
            {
                adj[v] = new List<int>();
            }

            if (!adj.ContainsKey(w))
            {
                adj[w] = new List<int>();
            }

            adj[v].Add(w);
            // Nếu đồ thị vô hướng, thêm cạnh ngược để đảm bảo tính liên thông
            adj[w].Add(v);
        }

        public void DFS(int v, Dictionary<int, bool> visited)
        {
            visited[v] = true;
            Console.Write(v + " ");

            if (adj.ContainsKey(v))
            {
                foreach (int i in adj[v])
                {
                    if (!visited[i])
                    {
                        DFS(i, visited);
                    }
                }
            }
        }

        public void DFS_Perform(int start)
        {
            Dictionary<int, bool> visited = new Dictionary<int, bool>();
            foreach (var v in adj.Keys)
            {
                visited[v] = false;
            }
            DFS(start, visited);
        }

        public void BFS(int v, Dictionary<int, bool> visited)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(v);
            visited[v] = true;
            Console.Write(v + " ");

            while(queue.Count > 0)
            {
                int u = queue.Peek();
                queue.Dequeue();

                if (adj.ContainsKey(u))
                {
                    foreach (int i in adj[u])
                    {
                            if (!visited[i])
                            {
                                queue.Enqueue(i);
                                visited[i] = true;
                                Console.Write(i + " ");
                            }
                    }
                }
            }
        }

        public void BFS_Perform(int start)
        {
            Dictionary<int, bool> visited = new Dictionary<int, bool>();
            foreach (var v in adj.Keys)
            {
                visited[v] = false;
            }
            BFS(start, visited);
        }
    }
}