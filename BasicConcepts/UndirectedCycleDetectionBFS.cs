// using System;
// using System.Collections.Generic;

// class  UndirectedCycleDetectionBFS{
//     public static void Main() {
//         List<List<int>> adj = new List<List<int>> {
//             new List<int>{1, 2},
//             new List<int>{0, 2},
//             new List<int>{0, 1, 3},
//             new List<int>{2}
//         };

//         // Create Solution instance and run cycle check
//         UndirectedCycleDetectionBFS sol = new UndirectedCycleDetectionBFS();
//         bool hasCycle = sol.IsCycle(4, adj);
//         Console.WriteLine(hasCycle ? "Cycle detected" : "No cycle");
//     }

//     public bool IsCycle(int V, List<List<int>> adj) {
//         bool[] visited = new bool[V];

//         for (int i = 0; i < V; i++) {
//             if (!visited[i]) {
//                 if (BFSCycle(i, adj, visited)) {
//                     return true;
//                 }
//             }
//         }

//         return false;
//     }

//     public bool BFSCycle(int start, List<List<int>> adj, bool[] visited) {
//         Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
//         visited[start] = true;
//         q.Enqueue(Tuple.Create(start, -1));

//         while (q.Count > 0) {
//             var current = q.Dequeue();
//             int node = current.Item1;
//             int parent = current.Item2;

//             foreach (int neighbor in adj[node]) {
//                 if (!visited[neighbor]) {
//                     visited[neighbor] = true;
//                     q.Enqueue(Tuple.Create(neighbor, node));
//                 } else if (neighbor != parent) {
//                     //  Is the neighbor already visited and not the parent we just came from?
//                     // Neighbor is visited and not parent => cycle
//                     return true;
//                 }
//             }
//         }

//         return false;
//     }
// }
// //Time Complexity:O(N+2E)+O(N) can be  said O(V+E) traverse all nodes +O(N) for loop for component graphs.
// //Space Complexity: O(N): Queue, visted array.....