using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Extensions;

namespace LeetCodePractice
{
    public class TreesAndGraphs
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }


        // 98. Validate Binary Search Tree https://leetcode.com/problems/validate-binary-search-tree/
        /// <summary>
        /// Given a binary tree, determine if it is a valid binary search tree (BST).
        ///         Assume a BST is defined as follows:
        ///         The left subtree of a node contains only nodes with keys less than the node's key.
        ///         The right subtree of a node contains only nodes with keys greater than the node's key.
        ///         Both the left and right subtrees must also be binary search trees.
        /// </summary>
        [Theory] 
        [MemberData(nameof(GetValidateBinarySearchTreeData))]
        public void ValidateBinarySearchTree(TreeNode root, bool expected)
        {
            bool result = false;

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetValidateBinarySearchTreeData()
        {
            return new[]
            {
                  //  2
                  // / \
                  //1   3
                new object[] { new TreeNode(2) { left = new TreeNode(1), right = new TreeNode(3) }, true },
                   // 5
                  // / \
                  //1   4
                  //   / \
                  //  3   6
                new object[] { new TreeNode(5) { left = new TreeNode(1), right = new TreeNode(4) { left = new TreeNode(3), right = new TreeNode(6) } }, false }
            };            
        }


        // 124. Binary Tree Maximum Path Sum https://leetcode.com/problems/binary-tree-maximum-path-sum/
        /// <summary>
        /// Given a *non-empty* binary tree, find the maximum path sum.
        /// For this problem, a path is defined as any sequence of nodes from some starting node to any node in the tree along the parent-child connections. 
        /// The path must contain *at least one* node and does not need to go through the root.
        /// </summary>
        [Theory]
        [MemberData(nameof(GetBinaryTreeMaximumPathSumData))]
        public void BinaryTreeMaximumPathSum(TreeNode root, int expected)
        {
            int result = 0;

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetBinaryTreeMaximumPathSumData()
        {
            return new[]
            {
                 //  1
                 // / \
                 //2   3
                new object[] { new TreeNode(1) { left = new TreeNode(2), right = new TreeNode(3) }, 6 },
                  // -10
                  // / \
                  //9  20
                  //  /  \
                  // 15   7
                new object[] { new TreeNode(-10) { left = new TreeNode(9), right = new TreeNode(20) { left = new TreeNode(15), right = new TreeNode(7) } }, 42 }
            };
        }
    }
}
