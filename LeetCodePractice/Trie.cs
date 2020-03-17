using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodePractice
{
    public class TrieUnitTests
    {
        // 208. Implement Trie (Prefix Tree) https://leetcode.com/problems/implement-trie-prefix-tree/
        // Implement a trie with insert, search, and startsWith methods.
        [Fact]
        public void ImplementTrie()
        {
            Trie trie = new Trie();

            trie.Insert("apple");
            trie.Search("apple");   // returns true
            trie.Search("app");     // returns false
            trie.StartsWith("app"); // returns true
            trie.Insert("app");
            trie.Search("app");     // returns true
        }
    }

    public class Trie
    {

        /** Initialize your data structure here. */
        public Trie()
        {

        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {

        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            return false;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            return false;
        }
    }
}
