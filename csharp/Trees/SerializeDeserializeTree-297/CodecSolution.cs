using System.Collections.Generic;

namespace Solutions.Trees
{
    // 297. Serialize and Deserialize Binary Tree
    // https://leetcode.com/problems/serialize-and-deserialize-binary-tree/
    public class Codec
    {

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            var queue = new Queue<TreeNode>();

            if (root == null)
            {
                return "";
            }

            queue.Enqueue(root);

            var serializedData = new List<string>();

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                if (node == null)
                {
                    serializedData.Add("null");
                }
                else
                {
                    serializedData.Add(node.val.ToString());
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }

            return string.Join(",", serializedData);
        }


        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            if (data == "")
            {
                return null;
            }

            var nodes = data.Split(",");

            var queue = new Queue<TreeNode>();
            var root = new TreeNode(int.Parse(nodes[0]));
            queue.Enqueue(root);

            var index = 1;
            while (queue.Count != 0)
            {
                var node = queue.Dequeue();

                if (nodes[index] != "null")
                {
                    node.left = new TreeNode(int.Parse(nodes[index]));
                    queue.Enqueue(node.left);
                }
                else
                {
                    node.left = null;
                }
                index++;


                if (nodes[index] != "null")
                {
                    node.right = new TreeNode(int.Parse(nodes[index]));
                    queue.Enqueue(node.right);
                }
                else
                {
                    node.right = null;
                }
                index++;
            }

            return root;

        }
    }
}