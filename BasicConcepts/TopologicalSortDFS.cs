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

// public class TopoSortDFS
// {
//     public static void Main(string[] args)
//     {
//         List<List<int>> adj = new List<List<int>> {
//         new List<int>{1},        // 0 -> 1
//         new List<int>{2},        // 1 -> 2
//         new List<int>{3},        // 2 -> 3
//         new List<int>{}          // 3
//         };

//         int[] ans = DFSTopoSort(4, adj);
//         foreach (int i in ans)
//         {
//             Console.Write(i);
//         }
//     }
//     public static int[] DFSTopoSort(int V, List<List<int>> adj)
//     {
//         bool[] visited = new bool[V];
//         Stack<int> topostack = new Stack<int>();
//         for (int i = 0; i < V; i++)
//         {
//             if (!visited[i])
//             {
//                 dfs(i, visited, adj, V, topostack);
//             }
//         }
//         int[] temp = new int[V];
//         int it = 0;
//         for(int i=0;i<V;i++)
//         {
//             temp[it++] = topostack.Pop();
//         }
//         //return topostack.ToArray();
//         return temp;
//     }

//     public static void dfs(int node, bool[] visited, List<List<int>> adj, int V, Stack<int> topostack ) {
//         visited[node] = true;
//         foreach (int neighbor in adj[node])
//         {
//             if (!visited[neighbor])
//             {
//                 dfs(neighbor, visited, adj, V, topostack);
//             }
//         }
//         topostack.Push(node);
//     }
// }