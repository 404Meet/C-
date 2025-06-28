// using System;
// using System.Collections.Generic;

// class DFSGraph
// {
//     // DFS from node 0 (connected graph only)
//     public List<int> DfsFromNode(List<List<int>> adj)
//     {
//         int V = adj.Count;
//         bool[] visited = new bool[V];
//         List<int> dfsList = new List<int>();

//         DfsRecursion(0, adj, visited, dfsList);
//         return dfsList;
//     }

//     // DFS for all components (handles disconnected graphs)
//     public List<int> DfsDisconnected(List<List<int>> adj)
//     {
//         int V = adj.Count;
//         bool[] visited = new bool[V];
//         List<int> dfsList = new List<int>();

//         for (int i = 0; i < V; i++)
//         {
//             if (!visited[i])
//             {
//                 DfsRecursion(i, adj, visited, dfsList);
//             }
//         }

//         return dfsList;
//     }

//     // Shared DFS utility
//     private void DfsRecursion(int node, List<List<int>> adj, bool[] visited, List<int> dfsList)
//     {
//         visited[node] = true;
//         dfsList.Add(node);

//         foreach (int neighbor in adj[node])
//         {
//             if (!visited[neighbor])
//             {
//                 DfsRecursion(neighbor, adj, visited, dfsList);
//             }
//         }
//     }

//     // Entry point for testing
//     public static void Main()
//     {
//         DFSGraph sol = new DFSGraph();

//         List<List<int>> connectedGraph = new List<List<int>> {
//             new List<int>{1, 2},
//             new List<int>{0, 3},
//             new List<int>{0},
//             new List<int>{1}
//         };

//         Console.WriteLine("DFS from node 0 (connected graph):");
//         var dfs1 = sol.DfsFromNode(connectedGraph);
//         Console.WriteLine(string.Join(", ", dfs1));

//         // Sample Input 2: Disconnected Graph
//         List<List<int>> disconnectedGraph = new List<List<int>> {
//             new List<int>{1},
//             new List<int>{0},
//             new List<int>{3},
//             new List<int>{2},
//             new List<int>{},      // isolated node
//             new List<int>{6},
//             new List<int>{5}
//         };

//         Console.WriteLine("\nDFS for disconnected graph:");
//         var dfs2 = sol.DfsDisconnected(disconnectedGraph);
//         Console.WriteLine(string.Join(", ", dfs2));
//     }
// }


// //Time Complexity:O(N)+O(2*E) travese number of nodes and foreach neighbour of a single node. Total degree for undirected graph(2*E).For Directed Graph TC: O(N+E),where E varies depending on incoming, outgoing edges.
// //Space Complexity:O(3N) DFSList, Visited Array, Auxilary Stack Space
// // DFS from node 0 (connected graph):
// // 0, 1, 3, 2
// // DFS for disconnected graph:
// // 0, 1, 2, 3, 4, 5, 6