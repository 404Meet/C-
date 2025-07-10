// using System;
// using System.Collections.Generic;

// public class TreeNode {
//     public int val;
//     public TreeNode left, right;
//     public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
//         this.val = val;
//         this.left = left;
//         this.right = right;
//     }
// }

// public class TopViewBinaryTree {
//     public IList<int> TopView(TreeNode root) {
//         if (root == null) return new List<int>();

//         // Dictionary: HD (horizontal distance) -> node value
//         SortedDictionary<int, int> topNodes = new SortedDictionary<int, int>();
//         Queue<(TreeNode node, int hd)> queue = new Queue<(TreeNode, int)>();
//         queue.Enqueue((root, 0));

//         while (queue.Count > 0) {
//             var (node, hd) = queue.Dequeue();

//             // Only record the first node at each HD
//             if (!topNodes.ContainsKey(hd)) {
//                 topNodes[hd] = node.val;
//             }

//             if (node.left != null)
//                 queue.Enqueue((node.left, hd - 1));
//             if (node.right != null)
//                 queue.Enqueue((node.right, hd + 1));
//         }

//         return new List<int>(topNodes.Values);
//     }
// }
// public class Program {
//     public static void Main() {
//         // Build the test tree
//         TreeNode root = new TreeNode(1) {
//             left = new TreeNode(2) {
//                 right = new TreeNode(4)
//             },
//             right = new TreeNode(3) {
//                 right = new TreeNode(5) {
//                     right = new TreeNode(6)
//                 }
//             }
//         };

//         TopViewBinaryTree sol = new TopViewBinaryTree();
//         var topView = sol.TopView(root);

//         Console.WriteLine("Top View:");
//         Console.WriteLine("[" + string.Join(", ", topView) + "]");
//     }
// }
