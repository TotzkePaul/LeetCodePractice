using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodePractice
{
    // 146. LRU Cache https://leetcode.com/problems/lru-cache/
    /*
     * Design and implement a data structure for Least Recently Used (LRU) cache. It should support the following operations: get and put.
     * get(key) - Get the value (will always be positive) of the key if the key exists in the cache, otherwise return -1.
     * put(key, value) - Set or insert the value if the key is not already present. When the cache reached its capacity, it should invalidate the least recently used item before inserting a new item.
     * The cache is initialized with a positive capacity.
     */
    public class LRUCacheUnitTests
    {

        [Fact]
        public void LRUCache()
        {
            LRUCache cache = new LRUCache(2 /* capacity */ );

            cache.Put(1, 1);
            cache.Put(2, 2);
            Assert.Equal(1,cache.Get(1));       // returns 1
            cache.Put(3, 3);                    // evicts key 2
            Assert.Equal(-1, cache.Get(2));     // returns -1 (not found)
            cache.Put(4, 4);                    // evicts key 1
            Assert.Equal(-1, cache.Get(1));     // returns -1 (not found)
            Assert.Equal(3, cache.Get(3));      // returns 3
            Assert.Equal(4, cache.Get(4));      // returns 4
        }
    }

    public class LRUCache
    {
        private int capacity;
        private LinkedList<KeyValuePair<int, int>> lruList;
        private Dictionary<int, LinkedListNode<KeyValuePair<int, int>>> cache;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            lruList = new LinkedList<KeyValuePair<int, int>>();
            cache = new Dictionary<int, LinkedListNode<KeyValuePair<int, int>>>(capacity);
        }

        public int Get(int key)
        {
            if (cache.ContainsKey(key))
            {
                LinkedListNode<KeyValuePair<int, int>> node = cache[key];
                lruList.Remove(node);
                lruList.AddLast(node);
                return node.Value.Value;
            }

            return -1;
        }

        public void Put(int key, int value)
        {
            if (lruList.Count == capacity)
            {
                if (cache.ContainsKey(key))
                {
                    LinkedListNode<KeyValuePair<int, int>> node = cache[key];
                    lruList.Remove(node);
                    lruList.AddLast(new KeyValuePair<int, int>(key, value));
                    cache.Remove(key);
                    cache[key] = lruList.Last;
                }
                else
                {
                    LinkedListNode<KeyValuePair<int, int>> lru = lruList.First;
                    lruList.Remove(lru);
                    lruList.AddLast(new KeyValuePair<int, int>(key, value));
                    cache.Remove(lru.Value.Key);
                    cache[key] = lruList.Last;

                }
            }
            else
            {
                if (cache.ContainsKey(key))
                {
                    LinkedListNode<KeyValuePair<int, int>> node = cache[key];
                    lruList.Remove(node);
                    lruList.AddLast(new KeyValuePair<int, int>(key, value));
                    cache.Remove(key);
                    cache[key] = lruList.Last;
                }
                else
                {
                    lruList.AddLast(new KeyValuePair<int, int>(key, value));
                    cache[key] = lruList.Last;
                }
            }
        }
    }
}
