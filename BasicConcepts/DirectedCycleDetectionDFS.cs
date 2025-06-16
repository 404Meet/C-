// using System;
// using System.Collections.Generic;

// class DirectedCycleDetectionDFS
// {
//     public static void Main()
//     {
//         List<List<int>> adj = new List<List<int>> {
//             new List<int>{1},        // 0 -> 1
//             new List<int>{2},        // 1 -> 2
//             new List<int>{3,0},     // 2 -> 0, 3
//             new List<int>{}          // 3 -> ∅
//         };


//         // Create Solution instance and run cycle check
//         DirectedCycleDetectionDFS sol = new DirectedCycleDetectionDFS();
//         bool hasCycle = sol.IsCycle(4, adj);
//         Console.WriteLine(hasCycle ? "Cycle detected" : "No cycle");
//     }

//     public bool IsCycle(int V, List<List<int>> adj)
//     {
//         bool[] visited = new bool[V];
//         bool[] pathvisited = new bool[V];
//         for (int i = 0; i < V; i++)
//         {
//             if (!visited[i])
//             {
//                 if (dfs(i, visited, pathvisited, adj, V))
//                 {
//                     return true;
//                 }
//             }
//         }
//         return false;
//     }

//     public bool dfs(int node, bool[] visited, bool[] pathvisited, List<List<int>> adj, int V)
//     {
//         visited[node] = true;
//         pathvisited[node] = true;

//         foreach (var neighbor in adj[node])
//         {
//             if (!visited[neighbor])
//             {
//                 if (dfs(neighbor, visited, pathvisited, adj, V))
//                 {
//                     return true;
//                 }
//             }
//             else if (pathvisited[neighbor])
//             {
//                 return true;
//             }
//         }
//         pathvisited[node] = false;
//         return false;

//     }
// }
// // //Time Complexity:O(V+E)+O(N) can be  said O(V+E) traverse all nodes +O(N) for loop for component graphs. E (not 2E) because, it's a directed graph. 
// // //Space Complexity: O(N): Auxilary stack space, visted array.....