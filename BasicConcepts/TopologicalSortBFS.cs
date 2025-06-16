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

// public class TopoSortBFS
// {
//     public static void Main(string[] args)
//     {
//         List<List<int>> adj = new List<List<int>> {
//         new List<int>{1},        // 0 -> 1
//         new List<int>{2},        // 1 -> 2
//         new List<int>{3},        // 2 -> 3
//         new List<int>{}          // 3
//         };

//         int[] ans = BFSTopoSort(4, adj);
//         foreach (int i in ans)
//         {
//             Console.Write(i);
//         }
//     }
//     public static int[] BFSTopoSort(int V, List<List<int>> adj)
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
//         int[] ans = new int[V];
//         while (q.Count != 0)
//         {
//             int node = q.Dequeue();
//             ans[index++] = node;
//             foreach (int neighbor in adj[node])
//             {
//                 indegree[neighbor]--;//Decrease the indegree, to come closer to 0
//                 if (indegree[neighbor] == 0)//If it is already visited in the queue, don't insert
//                 {
//                     q.Enqueue(neighbor);
//                 }
//             }
//         }
//         return ans;
//     }
// }