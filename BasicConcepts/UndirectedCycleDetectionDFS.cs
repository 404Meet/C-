// using System;
// using System.Collections.Generic;

// class UndirectedCycleDetectionDFS
// {
//     public static void Main()
//     {
//         List<List<int>> adj = new List<List<int>> {
//             new List<int>{1, 2},
//             new List<int>{0, 2},
//             new List<int>{0, 1, 3},
//             new List<int>{2}
//         };

//         // Create Solution instance and run cycle check
//         UndirectedCycleDetectionDFS sol = new UndirectedCycleDetectionDFS();
//         bool hasCycle = sol.IsCycle(4, adj);
//         Console.WriteLine(hasCycle ? "Cycle detected" : "No cycle");
//     }

//     public bool IsCycle(int V, List<List<int>> adj)
//     {
//         bool[] visited = new bool[V];

//         for (int i = 0; i < V; i++)
//         {
//             if (!visited[i])
//             {
//                 if (DFSCycle(i, -1, adj, visited))
//                 {
//                     return true;
//                 }
//             }
//         }

//         return false;
//     }

//     public bool DFSCycle(int node, int parent, List<List<int>> adj, bool[] visited)
//     {
//         visited[node] = true;

//         foreach (int neighbor in adj[node])
//         {
//             if (!visited[neighbor])
//             {
//                 if (DFSCycle(neighbor, node, adj, visited))
//                 {
//                     return true;
//                 }
//             }
//             else if (neighbor != parent)
//             {
//                 // If visited and not parent => cycle
//                 return true;
//             }
//         }

//         return false;
//     }
// }
// //Time Complexity:O(N+2E)+O(N) can be  said O(V+E) traverse all nodes +O(N) for loop for component graphs.
// //Space Complexity: O(N): Auxilary Stack Space, visted array.....
