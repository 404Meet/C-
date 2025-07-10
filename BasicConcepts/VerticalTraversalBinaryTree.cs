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

// public class VerticalTraversalBinaryTree {
//     public IList<IList<int>> VerticalTraversal(TreeNode root) {
//         SortedDictionary<int, List<(int y, int val)>> columnTable = new SortedDictionary<int, List<(int, int)>>();
//         Queue<(TreeNode node, int x, int y)> queue = new Queue<(TreeNode, int, int)>();
//         queue.Enqueue((root, 0, 0));

//         while (queue.Count > 0) {
//             var (node, x, y) = queue.Dequeue();

//             if (!columnTable.ContainsKey(x))
//                 columnTable[x] = new List<(int, int)>();
//             columnTable[x].Add((y, node.val));

//             if (node.left != null)
//                 queue.Enqueue((node.left, x - 1, y + 1));
//             if (node.right != null)
//                 queue.Enqueue((node.right, x + 1, y + 1));
//         }

//         List<IList<int>> result = new List<IList<int>>();
//         foreach (var kvp in columnTable) {
//             var list = kvp.Value;
//             list.Sort((a, b) => a.y != b.y ? a.y.CompareTo(b.y) : a.val.CompareTo(b.val));
//             List<int> column = new List<int>();
//             foreach (var item in list)
//                 column.Add(item.val);
//             result.Add(column);
//         }

//         return result;
//     }
// }

// public class Program {
//     public static void Main() {
//         // Build the test tree:
//         //         1
//         //        / \
//         //       2   3
//         //      /   / \
//         //     4   5   6
//         //          \
//         //           7
//         TreeNode root = new TreeNode(1) {
//             left = new TreeNode(2) {
//                 left = new TreeNode(4)
//             },
//             right = new TreeNode(3) {
//                 left = new TreeNode(5) {
//                     right = new TreeNode(7)
//                 },
//                 right = new TreeNode(6)
//             }
//         };

//         VerticalTraversalBinaryTree sol = new VerticalTraversalBinaryTree();
//         var result = sol.VerticalTraversal(root);

//         // Print output
//         foreach (var column in result) {
//             Console.WriteLine("[" + string.Join(", ", column) + "]");
//         }
//     }
// }
