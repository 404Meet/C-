// public class ShortestPath_DAG_BFS
// {
//     public static void Main(string[] args)
//     {
//         // -------- Generate edges list here (DAG) --------
//         // V = 6, src = 0
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

//         int[] dist = ShortestPathDAG_BFSTopo(V, edges, src);

//         Console.WriteLine("Distances from src = " + src);
//         for (int i = 0; i < V; i++)
//         {
//             if (dist[i] >= (int)1e9) Console.Write("INF ");
//             else Console.Write(dist[i] + " ");
//         }
//         Console.WriteLine();
//     }

//     public static int[] ShortestPathDAG_BFSTopo(int V, int[][] edges,int src)
//     {
//         List<List<int[]>> adj = new List<List<int[]>>();
//         for(int i = 0; i < V; i++)
//         {
//             adj.Add(new List<int[]>());
//         }
//         for(int i = 0; i < edges.Length; i++)
//         {
//             int u=edges[i][0];
//             int v=edges[i][1];
//             int w=edges[i][2];
//             adj[u].Add(new int[]{v,w});
//         }

//         //TopoSort
//         int[] indegree = new int[V];
//         for(int i = 0; i < V; i++)
//         {
//             foreach(var edge in adj[i])
//             {
//                 int j=edge[0];
//                 indegree[j]++;  
//             }
//         }
//         Queue<int> q = new Queue<int>();
//         for(int i = 0; i < V; i++)
//         {
//             if (indegree[i] == 0)
//             {
//                 q.Enqueue(i);
//             }
//         }
//         int index=0;
//         int[] topo = new int[V];
//         while (q.Count > 0)
//         {
//             int node=q.Dequeue();
//             topo[index++]=node;
//             foreach(var edge in adj[node])
//             {
//                 int neighbor = edge[0];
//                 indegree[neighbor]--;
//                 if (indegree[neighbor] == 0)
//                 {
//                     q.Enqueue(neighbor);
//                 }
//             }
//         }


//         //relaxation of edges(need a distance array) and find shortest path
//         int[] dis = new int[V];
//         for(int i = 0; i < V; i++)
//         {
//             dis[i]=(int)1e9;
//         }
//         dis[src]=0;//Always enter the source first, source=0;
//         for(int i = 0; i < V; i++)
//         {
//             int node=topo[i];
//             if (dis[node] == (int)1e9)
//             {
//                 continue;
//             }
//             foreach(var edge in adj[node])
//             {
//                 int neighbor=edge[0];
//                 int w=edge[1];
//                 if (dis[node] + w < dis[neighbor])
//                 {
//                     dis[neighbor]=dis[node]+w;
//                 }
//             }
//         }
//         return dis;

//     }
// }