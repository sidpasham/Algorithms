using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Graph
    {
        private int value;

        private LinkedList<int>[] adjLinkedList;

        public Graph(int v)
        {
            value = v;
            adjLinkedList = new LinkedList<int>[v];

            for (int i = 0; i < v; i++)
            {
                adjLinkedList[i] = new LinkedList<int>();
            }
        }

        static void AddEdge(Graph graph, int src, int dest)
        {
            //add source to destination
            graph.adjLinkedList[src].AddLast(dest);

            //since its un-directed graph add destination to source
            graph.adjLinkedList[dest].AddLast(src);
        }

        static void PrintGraph(Graph graph)
        {
            if(graph == null) return;

            for (int i = 0; i < graph.value; i++)
            {
                foreach (var val in graph.adjLinkedList[i])
                {
                    Console.WriteLine(val);
                }
            }
        }


    }
}
