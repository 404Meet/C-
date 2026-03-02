
// // DAG Shortest Path using DFS TopoSort + Relaxation
// // Input edges format: int[][] edges where each edge = {u, v, w}
// // Adjacency format inside: List<List<int[]>> adj where each edge = {v, w}
// using System;
// using System.Collections.Generic;
// public class ShortestPath_DAG_DFS
// {
//     public static void Main(string[] args)
//     {
//         // -------- Generate edges list here (DAG) --------
//         // V = 6, src = 0
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

//         int[] dist = ShortestPathDAG_DFSTopo(V, edges, src);

//         Console.WriteLine("Distances from src = " + src);
//         for (int i = 0; i < V; i++)
//         {
//             if (dist[i] >= (int)1e9) Console.Write("INF ");
//             else Console.Write(dist[i] + " ");
//         }
//         Console.WriteLine();
//     }

//     public static int[] ShortestPathDAG_DFSTopo(int V, int[][] edges, int source)
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
//         }
        
//         //TopoSort
//         int[] visited = new int[V];
//         Stack<int> st= new Stack<int>();
//         for(int i = 0; i < V;i++)
//         {
//             if (visited[i] == 0)
//             {
//                 toposort(i,visited,st,adj);
//             }
//         }

//         //relaxation of edges(need a distance array) and and find shortest
//         int[] dis = new int[V];
//         for(int i = 0; i < V; i++)
//         {
//             dis[i]=(int)1e9; // Assigning infinite to every node at beginning
//         }
//         dis[source]=0;//Always enter the source first, source=0;
//         while (st.Count > 0)  //for(i - V)
//         {
//             int node=st.Pop();
//             if (dis[node] == (int)1e9) continue;//node is unreacheable from source , multiple components not a single graph
//             foreach(int[] edge in adj[node])
//             {
//                 int neighbor=edge[0];
//                 int w=edge[1];
//                 if (dis[node]+w < dis[neighbor]) //First neighbor element: node weight 0(source weight) + some weight < infinite (neighbor's wreight), so ofcourse neighbor weight will be 0+some weight.
//                 {
//                     dis[neighbor]=dis[node]+w;
//                 }
//             }
//         }
//         return dis;

//     }

//     public static void toposort(int node, int[] visited, Stack<int> st, List<List<int[]>> adj)
//     {
//         visited[node]=1;
//         foreach(int[] edge in adj[node])
//         {
//             int neighbor = edge[0];
//             if (visited[neighbor] == 0)
//             {
//                 toposort(neighbor,visited,st,adj);
//             }
//         }
//         st.Push(node);
//     }
// }