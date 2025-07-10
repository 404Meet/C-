using System;
using System.Collections.Generic;

public class TreeNode {
    public int val;
    public TreeNode left, right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class LeftRightViewBinaryTree {
    public IList<int> LeftView(TreeNode root) {
        List<int> result = new List<int>();
        DFSLeft(root, 0, result);
        return result;
    }

    public IList<int> RightView(TreeNode root) {
        List<int> result = new List<int>();
        DFSRight(root, 0, result);
        return result;
    }

    private void DFSLeft(TreeNode node, int level, List<int> view) {
        if (node == null) return;
        if (level == view.Count)
            view.Add(node.val);
        DFSLeft(node.left, level + 1, view);
        DFSLeft(node.right, level + 1, view);
    }

    private void DFSRight(TreeNode node, int level, List<int> view) {
        if (node == null) return;
        if (level == view.Count)
            view.Add(node.val);
        DFSRight(node.right, level + 1, view);
        DFSRight(node.left, level + 1, view);
    }
}

public class Program {
    public static void Main() {
        TreeNode root = new TreeNode(1) {
            left = new TreeNode(2) {
                left = new TreeNode(4),
                right = new TreeNode(5) {
                    right = new TreeNode(7)
                }
            },
            right = new TreeNode(3) {
                right = new TreeNode(6)
            }
        };

        LeftRightViewBinaryTree sol = new LeftRightViewBinaryTree();
        var left = sol.LeftView(root);
        var right = sol.RightView(root);

        Console.WriteLine("Left View (DFS):  [" + string.Join(", ", left) + "]");
        Console.WriteLine("Right View (DFS): [" + string.Join(", ", right) + "]");
    }
}
