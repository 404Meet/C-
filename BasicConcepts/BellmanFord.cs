// using System;
// using System.Collections.Generic;
// using System.Xml;

// public class BellmanFordProgram
// {
//     public static void Main(string[] args)
//     {
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

//         int[] dist = BellmanFord(V, edges, src);

//         if(dist.Length == 1 && dist[0]==-1)
//         {
//             Console.WriteLine("Negative Cycle Detected");
//             return;
//         }

//         Console.WriteLine("Bellman Ford: Distances from src = " + src);
//         for (int i = 0; i < V; i++)
//         {
//             Console.Write(dist[i] + " ");
//         }
//         Console.WriteLine();
//     }

//     public static int[] BellmanFord(int V, int[][] edges, int src)
//     {

//         //relaxation of edges(need a distance array) and find shortest path
//         int[] distance = new int[V];
//         for(int i = 0; i < V; i++)
//         {
//             distance[i]=(int)1e9;
//         }
//         distance[src]=0;

//         for(int i = 0; i < V - 1; i++)
//         {
//             foreach(var edge in edges)
//             {
//                 int u=edge[0];
//                 int v=edge[1];
//                 int w=edge[2];
//                 if (distance[u]!=(int)1e9 && distance[u] + w < distance[v])
//                 {
//                     distance[v]=distance[u]+w;
//                 }
//             }
//         }

//         foreach(var edge in edges)
//         {
//             int u=edge[0];
//             int v=edge[1];
//             int w=edge[2];
//             if (distance[u]!=(int)1e9 && distance[u] + w < distance[v])
//             {
//                 return new int[1]{-1};
//             }
//         }
//         return distance;
//     }
// }