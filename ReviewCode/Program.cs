using System;

namespace ReviewCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(10);
            g.AddEdge(1, 2);
            g.AddEdge(1, 3);
            g.AddEdge(1, 5);
            g.AddEdge(1, 10);
            g.AddEdge(2, 4);
            g.AddEdge(3, 6);
            g.AddEdge(3, 7);
            g.AddEdge(3, 9);
            g.AddEdge(6, 7);
            g.AddEdge(5, 8);
            g.AddEdge(8, 9);

            g.DFS_Perform(1);
        }
    }
}
