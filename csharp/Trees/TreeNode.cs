using System;

namespace Solutions.Trees
{
    public class TreeNode : IEquatable<TreeNode>
    {
        public int val;

        public TreeNode left;

        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as TreeNode);
        }

        public bool Equals(TreeNode p)
        {
            if (Object.ReferenceEquals(p, null))
            {
                return false;
            }

            if (Object.ReferenceEquals(this, p))
            {
                return true;
            }

            if (this.GetType() != p.GetType())
            {
                return false;
            }

            return (val == p.val) &&
             TreeNode.Equals(left, p.left) &&
             TreeNode.Equals(right, p.right);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + val.GetHashCode();
                hash = hash * 23 + (left != null ? left.GetHashCode() : 0);
                hash = hash * 23 + (right != null ? right.GetHashCode() : 0);
                return hash;
            }
        }
    }
}