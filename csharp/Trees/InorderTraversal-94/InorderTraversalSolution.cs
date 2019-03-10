using System.Collections.Generic;

namespace Solutions.Trees
{
    // https://leetcode.com/problems/binary-tree-inorder-traversal
    public class InorderTraversalSolution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            // InorderTraversalRecursive(root, result);
            InorderTraversalIterative(root, result);
            return result;
        }

        private void InorderTraversalRecursive(TreeNode node, IList<int> values)
        {
            if (node == null)
            {
                return;
            }

            InorderTraversalRecursive(node.left, values);
            values.Add(node.val);
            InorderTraversalRecursive(node.right, values);
        }

        private void InorderTraversalIterative(TreeNode node, IList<int> values)
        {
            if (node == null)
            {
                return;
            }

            var stack = new Stack<TreeNode>();
            stack.Push(node);

            while (node.left != null)
            {
                stack.Push(node.left);
                node = node.left;
            }

            while (stack.Count != 0)
            {
                var temp = stack.Pop();
                values.Add(temp.val);
                if (temp.right != null)
                {
                    stack.Push(temp.right);
                    var temp2 = temp.right;
                    while (temp2.left != null)
                    {
                        stack.Push(temp2.left);
                        temp2 = temp2.left;
                    }
                }
            }
        }

        private void InorderTraversalIterative2(TreeNode node, IList<int> values)
        {
            if (node == null)
            {
                return;
            }

            var stack = new Stack<TreeNode>();
            var current = node;

            while (current != null || stack.Count != 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }

                current = stack.Pop();
                values.Add(current.val);
                current = current.right;
            }
        }

    }
}