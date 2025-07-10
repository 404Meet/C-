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

// public class BottomViewBinaryTree {
//     public IList<int> BottomView(TreeNode root) {
//         if (root == null) return new List<int>();

//         // HD -> node.val
//         SortedDictionary<int, int> bottomNodes = new SortedDictionary<int, int>();
//         Queue<(TreeNode node, int hd)> queue = new Queue<(TreeNode, int)>();
//         queue.Enqueue((root, 0));

//         while (queue.Count > 0) {
//             var (node, hd) = queue.Dequeue();

//             // Overwrite the value for the HD — last one seen at this HD will be the bottom view
//             bottomNodes[hd] = node.val;

//             if (node.left != null)
//                 queue.Enqueue((node.left, hd - 1));
//             if (node.right != null)
//                 queue.Enqueue((node.right, hd + 1));
//         }

//         return new List<int>(bottomNodes.Values);
//     }
// }

// public class Program {
//     public static void Main() {
//         TreeNode root = new TreeNode(1) {
//             left = new TreeNode(2) {
//                 left = new TreeNode(4),
//                 right = new TreeNode(5) {
//                     right = new TreeNode(7)
//                 }
//             },
//             right = new TreeNode(3) {
//                 right = new TreeNode(6)
//             }
//         };

//         BottomViewBinaryTree sol = new BottomViewBinaryTree();
//         var bottomView = sol.BottomView(root);

//         Console.WriteLine("Bottom View:");
//         Console.WriteLine("[" + string.Join(", ", bottomView) + "]");
//     }
// }
