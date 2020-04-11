using System;
using static Diameter_of_Binary_Tree.Program.BinaryTree;

/*
 * Given a binary tree, you need to compute the length of the diameter of the tree.
 * The diameter of a binary tree is the length of the longest path between any two nodes in a tree.
 * This path may or may not pass through the root.
 * 
 * Note: The length of path between two nodes is represented by the number of edges between them.
 * 
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

namespace Diameter_of_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the binary tree
            BinaryTree tree = new BinaryTree();
            int[] arr = { 1, 2, 3, 4, 5 };

            tree.root = tree.InsertLevelOrder(arr, tree.root, 0);
            tree.Print(tree.root);

            Console.WriteLine();
            Console.WriteLine("Diameter is: " + DiameterOfBinaryTree(tree.root));
        }

        public static int DiameterOfBinaryTree(TreeNode root)
        {
            int max = 0;
            DepthSearch(root);

            return max;

            int DepthSearch(TreeNode node)
            {
                if (node == null)
                    return 0;

                int left = DepthSearch(node.left);
                int right = DepthSearch(node.right);
                max = Math.Max(max, left + right);

                return Math.Max(left, right) + 1;
            }
        }

        public class BinaryTree
        {
            public TreeNode root;

            // Tree Node 
            public class TreeNode
            {
                public int val;
                public TreeNode left;
                public TreeNode right;
                public TreeNode(int x) { val = x; }
            }

            // Insert nodes in level order
            public TreeNode InsertLevelOrder(int[] arr, TreeNode root, int i)
            {
                if (i < arr.Length)
                {
                    TreeNode temp = new TreeNode(arr[i]);
                    root = temp;

                    // Insert left child 
                    root.left = InsertLevelOrder(arr, root.left, 2 * i + 1);

                    // Insert right child 
                    root.right = InsertLevelOrder(arr, root.right, 2 * i + 2);
                }
                return root;
            }

            // Print nodes 
            public void Print(TreeNode root)
            {
                if (root != null)
                {
                    Print(root.left);
                    Console.Write(root.val + " ");
                    Print(root.right);
                }
            }
        }
    }
}
