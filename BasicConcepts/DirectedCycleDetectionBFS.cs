// // //Incase input isgiven in int[][] edges format.
// // int[] indegree = new int[V];
// // List<List<int>> adj = new List<List<int>>();
// // for (int i = 0; i < V; i++)
// // {
// //     adj.Add(new List<int>());
// // }
// // foreach (int[] edge in edges)
// // {
// //     int u = edge[0];
// //     int v = edge[1];
// //     adj[u].Add(v);
// //     indegree[v]++;
// // }
// // return new List<int>();

// public class DirectedCycleDetectionBFS
// {
//     public static void Main(string[] args)
//     {
//         List<List<int>> adj = new List<List<int>> {
//         new List<int>{1},        // 0 -> 1
//         new List<int>{2},        // 1 -> 2
//         new List<int>{3},        // 2 -> 3
//         new List<int>{}          // 3
//         };

//          bool hasCycle = BFS(4, adj);
//          Console.WriteLine(hasCycle ? "Cycle detected" : "No cycle");
//     }
//     public static bool BFS(int V, List<List<int>> adj)
//     {
//         int[] indegree = new int[V];
//         Queue<int> q = new Queue<int>();
//         for (int i = 0; i < V; i++)//create an indegree maintainer.
//         {
//             foreach (int neighbor in adj[i])
//             {
//                 indegree[neighbor] += 1;
//             }
//         }
//         for (int i = 0; i < V; i++)//Insert all 0 indegree nodes
//         {
//             if (indegree[i] == 0)
//             {
//                 q.Enqueue(i);
//             }
//         }

//         int index = 0;
//         while (q.Count != 0)//Process Queue;
//         {
//             int node = q.Dequeue();
//             index++;
//             foreach (int neighbor in adj[node])
//             {
//                 indegree[neighbor]--;//Decrease the indegree, to come closer to 0
//                 if (indegree[neighbor] == 0)//If it is already visited in the queue, don't insert
//                 {
//                     q.Enqueue(neighbor);
//                 }
//             }
//         }

//         //Cycle Detection is similar to toposortBFS, only addition is if index is not equal to total elements then cycle is formed.
//         if (index != V)//counter index is not equal to V elements.
//         {
//             return true;//Cycle detected: topological sort not possible.
//         }

//         return false;
//     }
// }