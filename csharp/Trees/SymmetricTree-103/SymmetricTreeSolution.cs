
using System.Collections.Generic;

namespace Solutions.Trees
{
    public class SymmetricTreeSolution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            return IsSymmetricIterative(root);
            // return IsSymmetricRecursive(root.left, root.right);
        }

        private bool IsSymmetricRecursive(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
            {
                return left == right;
            }

            if (left.val != right.val)
            {
                return false;
            }

            return IsSymmetricRecursive(left.left, right.right) && IsSymmetricRecursive(left.right, right.left);
        }

        private bool IsSymmetricIterative(TreeNode node)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();

            stack.Push(node.right);
            stack.Push(node.left);

            while (stack.Count != 0)
            {
                var left = stack.Pop();
                var right = stack.Pop();

                if (left == null && right == null) continue;

                if (left == null || right == null || left?.val != right?.val)
                {
                    return false;
                }

                stack.Push(right.right);
                stack.Push(left.left);

                stack.Push(right.left);
                stack.Push(left.right);
            }

            return true;
        }
    }
}
