// using System;
// using System.Collections.Generic;

// public class BFSGraph
// {
//     // BFS for a single connected component starting from node 0
//     public List<int> BfsFromNode(List<List<int>> adj)
//     {
//         int V = adj.Count;
//         bool[] visited = new bool[V];
//         Queue<int> q = new Queue<int>();
//         List<int> bfsOrder = new List<int>();

//         q.Enqueue(0);
//         visited[0] = true;

//         while (q.Count != 0)
//         {
//             int node = q.Dequeue();
//             bfsOrder.Add(node);

//             foreach (int nbr in adj[node])
//             {
//                 if (!visited[nbr])
//                 {
//                     visited[nbr] = true;
//                     q.Enqueue(nbr);
//                 }
//             }
//         }

//         return bfsOrder;
//     }

//     // BFS for all disconnected components
//     public List<List<int>> BfsDisconnected(List<List<int>> adj)
//     {
//         int V = adj.Count;
//         bool[] visited = new bool[V];
//         Queue<int> q = new Queue<int>();
//         List<List<int>> allComponents = new List<List<int>>();

//         for (int start = 0; start < V; start++)
//         {
//             if (visited[start]) continue;

//             List<int> componentOrder = new List<int>();
//             q.Enqueue(start);
//             visited[start] = true;

//             while (q.Count != 0)
//             {
//                 int node = q.Dequeue();
//                 componentOrder.Add(node);

//                 foreach (int nbr in adj[node])
//                 {
//                     if (!visited[nbr])
//                     {
//                         visited[nbr] = true;
//                         q.Enqueue(nbr);
//                     }
//                 }
//             }

//             allComponents.Add(componentOrder);
//         }

//         return allComponents;
//     }

//     public static void Main()
//     {
//         BFSGraph sol = new BFSGraph();

//         // Sample Input 1: Connected Graph
//         List<List<int>> connectedGraph = new List<List<int>> {
//             new List<int>{1, 2},
//             new List<int>{0, 3},
//             new List<int>{0, 4},
//             new List<int>{1},
//             new List<int>{2}
//         };

//         Console.WriteLine("BFS from node 0 (connected graph):");
//         var bfs1 = sol.BfsFromNode(connectedGraph);
//         Console.WriteLine(string.Join(", ", bfs1));

//         // Sample Input 2: Disconnected Graph
//         List<List<int>> disconnectedGraph = new List<List<int>> {
//             new List<int>{1},
//             new List<int>{0},
//             new List<int>{3},
//             new List<int>{2},
//             new List<int>{}, // isolated node
//             new List<int>{6},
//             new List<int>{5}
//         };

//         Console.WriteLine("\nBFS for disconnected graph (components):");
//         var bfs2 = sol.BfsDisconnected(disconnectedGraph);
//         int componentIndex = 1;
//         foreach (var comp in bfs2)
//         {
//             Console.WriteLine($"Component {componentIndex++}: {string.Join(", ", comp)}");
//         }
//     }
// }

// //Time Complexity: O(N) Queue + O(2E) foreach Loops through all the neighbours(i.e)edges (Ajaceny List = 2*Edges in Undirected Graph)
// //Space Complexity: O(3N) Queue,VisitedArray,BFSList
// // BFS from node 0 (connected graph):
// // 0, 1, 2, 3, 4

// // BFS for disconnected graph (components):
// // Component 1: 0, 1
// // Component 2: 2, 3
// // Component 3: 4
// // Component 4: 5, 6
