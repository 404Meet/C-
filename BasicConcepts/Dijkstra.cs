// using System;
// using System.Collections.Generic;
// using System.Xml;

// public class DijkstraProgram
// {
//     public static void Main(string[] args)
//     {
//         // ------- Generate edges list here -------
//         // Example directed graph
//         int V = 6;
//         int src = 0;

//         int[][] edges = new int[][]
//         {
//             new int[]{0,1,2},
//             new int[]{0,4,1},
//             new int[]{1,2,3},
//             new int[]{4,2,2},
//             new int[]{2,3,6},
//             new int[]{4,5,4},
//             new int[]{5,3,1}
//         };

//         bool directed = true; // set false if you want undirected

//         int[] dist = Dijkstra(V, edges, src, directed);

//         Console.WriteLine("Distances from src = " + src);
//         for (int i = 0; i < V; i++)
//         {
//             if (dist[i] >= (int)1e9) Console.Write("INF ");
//             else Console.Write(dist[i] + " ");
//         }
//         Console.WriteLine();
//     }

//     public static int[] Dijkstra(int V, int[][] edges, int src, bool directed)
//     {
//         //Adj List
//         List<List<int[]>> adj = new List<List<int[]>>();
//         for(int i = 0; i < V; i++)
//         {
//             adj.Add(new List<int[]>());
//         }
//         for(int i=0;i<edges.Length;i++)
//         {
//             int u=edges[i][0];
//             int v=edges[i][1];
//             int w=edges[i][2];
//             adj[u].Add(new int[]{v,w});
//             if (directed == false)
//             {
//                 adj[v].Add(new int[]{u,w});
//             }
//         }

//         //relaxation of edges(need a distance array) and find shortest path
//         int[] distance = new int[V];
//         for(int i = 0; i < V; i++)
//         {
//             distance[i]=(int)1e9;
//         }
//         distance[src]=0;
//         PriorityQueue<int,int> pq = new PriorityQueue<int, int>();
//         pq.Enqueue(src,0);

//         while(pq.Count>0)
//         {
//             pq.TryDequeue(out int node, out int dis);

//             if (dis > distance[node])// if(dis != distance[node]). 
//             {
//                 continue;
//             }
//             foreach(var edge in adj[node])
//             {
//                 int neighbor=edge[0];
//                 int wt=edge[1];
//                 if (distance[node] + wt < distance[neighbor])
//                 {
//                     distance[neighbor]=distance[node]+wt;
//                     pq.Enqueue(neighbor,distance[neighbor]);
//                 }
//             }
//         }
//         return distance;

//     }
// }