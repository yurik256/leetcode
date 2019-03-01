using System.Collections.Generic;

namespace Solutions.Trees
{
    public class LevelOrderTraversalSolution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();

            if (root == null)
            {
                return result;
            }

            Queue<QueueItem> queue = new Queue<QueueItem>();
            var currentLevel = 1;
            queue.Enqueue(new QueueItem
            {
                Node = root,
                Level = 1
            });

            var level = new List<int>();

            while (queue.Count != 0)
            {
                var queueItem = queue.Dequeue();

                if (currentLevel != queueItem.Level)
                {
                    result.Add(new List<int>(level));
                    level = new List<int>();
                    currentLevel = queueItem.Level;
                }

                level.Add(queueItem.Node.val);

                if (queueItem.Node.left != null)
                {
                    queue.Enqueue(new QueueItem
                    {
                        Node = queueItem.Node.left,
                        Level = queueItem.Level + 1
                    });
                }

                if (queueItem.Node.right != null)
                {
                    queue.Enqueue(new QueueItem
                    {
                        Node = queueItem.Node.right,
                        Level = queueItem.Level + 1
                    });
                }
            }

            if (level.Count != 0)
            {
                result.Add(new List<int>(level));
            }

            return result;
        }

        private class QueueItem
        {
            public TreeNode Node { get; set; }
            public int Level { get; set; }
        }
    }
}

