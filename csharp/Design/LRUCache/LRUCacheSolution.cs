using System;
using System.Collections.Generic;

namespace Solutions.Design
{
    // 146. LRU Cache
    // https://leetcode.com/problems/lru-cache/
    public class LRUCacheSolution
    {
        private int maxCapacity;
        private Dictionary<int, ListNode> hash;

        private ListNode head;
        private ListNode tail;

        public LRUCacheSolution(int capacity)
        {
            maxCapacity = capacity;
            hash = new Dictionary<int, ListNode>();
        }

        public int Get(int key)
        {
            if (hash.ContainsKey(key))
            {
                var node = hash[key];
                removeNode(node);
                appendNodeToTheHead(node);
                return node.Value;
            }
            else
            {
                return -1;
            }

        }

        public void Put(int key, int value)
        {
            if (hash.ContainsKey(key))
            {
                var node = hash[key];
                node.Value = value;
                removeNode(node);
                appendNodeToTheHead(node);
            }
            else
            {
                var node = new ListNode(key, value);

                if (hash.Count >= maxCapacity)
                {
                    hash.Remove(tail.Key);
                    removeNode(tail);
                }

                appendNodeToTheHead(node);

                hash[key] = node;
            }
        }

        private void appendNodeToTheHead(ListNode node)
        {
            node.Prev = null;
            node.Next = head;

            if (head != null)
            {
                head.Prev = node;
            }

            head = node;

            if (tail == null)
            {
                tail = head;
            }
        }

        private void removeNode(ListNode node)
        {
            if (node.Prev != null)
            {
                node.Prev.Next = node.Next;
            }
            else
            {
                head = node.Next;
            }

            if (node.Next != null)
            {
                node.Next.Prev = node.Prev;
            }
            else
            {
                tail = node.Prev;
            }

        }


        private class ListNode
        {
            public ListNode Prev { get; set; }

            public ListNode Next { get; set; }

            public int Value { get; set; }

            public int Key { get; set; }

            public ListNode(int key, int value)
            {
                Key = key;
                Value = value;
            }
        }
    }
}