using System;
using System.Collections.Generic;
using System.Xml;

public class FlyodWarshallProgram
{
    public static void Main(string[] args)
    {
        int V = 6;
        int src = 0;

        int[][] edges = new int[][]
        {
            new int[]{0,1,2},
            new int[]{0,4,1},
            new int[]{1,2,3},
            new int[]{4,2,2},
            new int[]{2,3,6},
            new int[]{4,5,4},
            new int[]{5,3,1}
        };

        int[][] dist = FlyodWarshall(V, edges);

        for(int i=0;i<V;i++)
        {
            if (dist[i][i] < 0)
            {
                Console.WriteLine("Negative Cycle Detected");
                return;
            }
        }

        Console.WriteLine("Flyod Warshall Distances Matric");
        for (int i = 0; i < V; i++)
        {
            for(int j = 0; j < V; j++)
            {
                
                if (dist[i][j] != (int)1e9)
                {
                    Console.Write(dist[i][j] + " ");
                }
                else
                {
                    Console.Write("INF" + " ");
                }
            }
            Console.WriteLine();
        }
    }

    public static int[][] FlyodWarshall(int V, int[][] edges)
    {
        int[][] dist = new int[V][];
        for(int i = 0; i < V; i++)
        {
            dist[i]=new int[V];
        }
        // Step 1: Initialize matrix
        for (int i = 0; i < V; i++)
        {
            for (int j = 0; j < V; j++)
            {
                if (i == j)
                    dist[i][j] = 0;
                else
                    dist[i][j] = (int)1e9;
            }
        }

        // Step 2: Fill edge weights
        foreach(var edge in edges)
        {
            int u=edge[0];
            int v=edge[1];
            int w=edge[2];
            dist[u][v]=w;
        }

        // Step 3: Floyd Warshall
        for(int k = 0; k < V; k++)
        {
            for(int i = 0; i < V; i++)
            {
                for(int j = 0; j < V; j++)
                {
                    if (dist[i][k] != (int)1e9 && dist[k][j] != (int)1e9)
                    {
                        dist[i][j]=Math.Min(dist[i][j],dist[i][k]+dist[k][j]);
                    }
                }
            }
        }
        return dist;
    }
}