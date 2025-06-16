// using System;
// using System.Collections.Generic;

// class Bipartite
// {
//     public static bool IsBFSBipartite(int V, List<List<int>> adj)
//     {
//         int[] color = new int[V];
//         for (int i = 0; i < V; i++) color[i] = -1;

//         for (int start = 0; start < V; start++)
//         {
//             if (color[start] == -1)
//             {
//                 if (!CheckBipartiteBFS(start, adj, color))
//                 {
//                     return false;
//                 }
//             }
//         }
//         return true;
//     }

//     private static bool CheckBipartiteBFS(int start, List<List<int>> adj, int[] color)
//     {
//         Queue<int> q = new Queue<int>();
//         q.Enqueue(start);
//         color[start] = 0;

//         while (q.Count > 0)
//         {
//             int node = q.Dequeue();
//             foreach (int neighbor in adj[node])
//             {
//                 if (color[neighbor] == -1)
//                 {
//                     color[neighbor] = 1 - color[node];
//                     q.Enqueue(neighbor);
//                 }
//                 else if (color[neighbor] == color[node])
//                 {
//                     return false;
//                 }
//             }
//         }
//         return true;
//     }
//     public static bool IsDFSBipartite(int V, List<List<int>> adj)
//     {
//         int[] color = new int[V];
//         for (int i = 0; i < V; i++) color[i] = -1;

//         for (int start = 0; start < V; start++)
//         {
//             if (color[start] == -1)
//             {
//                 if (!CheckBipartiteDFS(start, 0, adj, color))
//                 {
//                     return false;
//                 }
//             }
//         }
//         return true;
//     }

//     private static bool CheckBipartiteDFS(int node, int currColor, List<List<int>> adj, int[] color)
//     {
//         color[node] = currColor;

//         foreach (int neighbor in adj[node])
//         {
//             if (color[neighbor] == -1)
//             {
//                 if (!CheckBipartiteDFS(neighbor, 1 - currColor, adj, color))
//                 {
//                     return false;
//                 }
//             }
//             else if (color[neighbor] == color[node])//Already Visited and colored
//             {
//                 return false;
//             }
//         }
//         return true;
//     }
    
//      public static void Main() {

//         List<List<int>> adj = new List<List<int>> {
//             new List<int>{1, 2},
//             new List<int>{0, 3},
//             new List<int>{0},
//             new List<int>{1}
//         };
//         Console.WriteLine("BFS: " + (IsBFSBipartite(4, adj) ? "Bipartite" : "Not bipartite"));
//         Console.WriteLine("DFS: " + (IsBFSBipartite(4, adj) ? "Bipartite" : "Not bipartite"));
//     }
// }