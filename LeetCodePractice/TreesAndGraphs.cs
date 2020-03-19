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


        [Theory]
        [MemberData(nameof(GetConstructBinaryTreeFromPreorderAndInorderTraversalData))]
        public void ConstructBinaryTreeFromPreorderAndInorderTraversal(int[] preorder, int[] inorder, TreeNode expected)
        {
            TreeNode result = null;

            Assert.Equal(expected.val, result.val);
        }

        public static IEnumerable<object[]> GetConstructBinaryTreeFromPreorderAndInorderTraversalData()
        {
            return new[]
            {
                new object[] { new[] { 3, 9, 20, 15, 7 }, new[] { 9, 3, 15, 20, 7 }, new TreeNode(3) }
            };
        }


        // 617. Merge Two Binary Trees https://leetcode.com/problems/merge-two-binary-trees/
        /// <summary>
        /// Given two binary trees and imagine that when you put one of them to cover the other, some nodes of the two trees are overlapped while the others are not.
        /// You need to merge them into a new binary tree.
        /// The merge rule is that if two nodes overlap, then sum node values up as the new value of the merged node.Otherwise, the NOT null node will be used as the node of new tree.
        /// Note: The merging process must start from the root nodes of both trees.
        /// </summary>
        [Theory]
        [MemberData(nameof(GetMergTwoBinaryTreesData))]
        public void MergTwoBinaryTrees(TreeNode t1, TreeNode t2, TreeNode expected)
        {
            TreeNode result = null;

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetMergTwoBinaryTreesData()
        {
            var t1 = new TreeNode(1) { left = new TreeNode(3) { left = new TreeNode(5)}, right = new TreeNode(2) };
            var t2 = new TreeNode(2) { left = new TreeNode(1) { right = new TreeNode(4)}, right = new TreeNode(3) { right = new TreeNode(7) } };
            var expected = new TreeNode(3) { left = new TreeNode(4) { left = new TreeNode(5), right = new TreeNode(4)}, right = new TreeNode(5) { right = new TreeNode(7) } };
            return new[]
            {
                //Input: 
                //    Tree 1                     Tree 2
                //          1                         2
                //         / \                       / \                            
                //        3   2                     1   3
                //       /                           \   \                      
                //      5                             4   7
                //Output: 
                //Merged tree:
                //         3
                //        / \
                //       4   5
                //      / \   \
                //     5   4   7
                new object[] { t1, t2, expected }
            };
        }

        // 104. Maximum Depth of Binary Tree https://leetcode.com/problems/maximum-depth-of-binary-tree/
        /// <summary>
        /// Given a binary tree, find its maximum depth.
        /// The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
        /// Note: A leaf is a node with no children.
        /// </summary>
        [Theory]
        [MemberData(nameof(GetMaximumDepthOfBinaryTreeData))]
        public void MaximumDepthOfBinaryTree(TreeNode root, int expected)
        {
            int result = 0;

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetMaximumDepthOfBinaryTreeData()
        {
            return new[]
            {
                // Example:
                // Given binary tree [3,9,20,null,null,15,7],
                //    3
                //   / \
                //  9  20
                //    /  \
                //   15   7
                //return its depth = 3.
                new object[] { new TreeNode(3) { left = new TreeNode(9), right = new TreeNode(20) { left = new TreeNode(15), right = new TreeNode(7) } }, 3 }
            };
        }



        // 226. Invert Binary Tree https://leetcode.com/problems/invert-binary-tree/
        // Invert a binary tree.
        [Theory]
        [MemberData(nameof(GetInvertBinaryTreeData))]
        public void InvertBinaryTree(TreeNode root, TreeNode expected)
        {
            TreeNode result = null;

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetInvertBinaryTreeData()
        {
            // Example:
            // Input:
            //            4
            //          /   \
            //         2     7
            //        / \   / \
            //       1   3 6   9
            //Output:

            //           4
            //         /   \
            //        7     2
            //       / \   / \
            //      9   6 3   1
            //Trivia:
            //  This problem was inspired by this original tweet by Max Howell:  Google: 90 % of our engineers use the software you wrote(Homebrew), but you can’t invert a binary tree on a whiteboard so f***off.
            var root = new TreeNode(4) { left = new TreeNode(2) { left = new TreeNode(1), right = new TreeNode(3) }, right = new TreeNode(7) { left = new TreeNode(6), right = new TreeNode(9) } };
            var expected = new TreeNode(4) { left = new TreeNode(7) { left = new TreeNode(9), right = new TreeNode(6) }, right = new TreeNode(2) { left = new TreeNode(3), right = new TreeNode(1) } };
            return new[]
            {
                new object[] { root,  expected }
            };
        }

        // 101. Symmetric Tree https://leetcode.com/problems/symmetric-tree
        // Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).
        // Note: Bonus points if you could solve it both recursively and iteratively.
        [Theory]
        [MemberData(nameof(GetSymmetricTreeData))]
        public void SymmetricTree(TreeNode root, bool expected)
        {
            bool result = false;

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetSymmetricTreeData()
        {
            return new[]
            {
                new object[] { new TreeNode(1) { left = new TreeNode(2) { left = new TreeNode(3), right = new TreeNode(4) }, right = new TreeNode(2) { left = new TreeNode(4), right = new TreeNode(3) } }, true },
                new object[] { new TreeNode(1) { left = new TreeNode(2) { right = new TreeNode(3) }, right = new TreeNode(2) { right = new TreeNode(3) } }, false }
            };
        }

        // 543. Diameter of Binary Tree https://leetcode.com/problems/diameter-of-binary-tree/
        // Given a binary tree, you need to compute the length of the diameter of the tree. 
        // The diameter of a binary tree is the length of the *longest* path between any two nodes in a tree. This path may or may not pass through the root.
        // Note: The length of path between two nodes is represented by the number of edges between them.
        [Theory]
        [MemberData(nameof(GetDiameterOfBinaryTreeData))]
        public void DiameterOfBinaryTree(TreeNode root, int expected)
        {
            int result = 0;

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetDiameterOfBinaryTreeData()
        {
            return new[]
            {
                //Example:
                //Given a binary tree
                //          1
                //         / \
                //        2   3
                //       / \     
                //      4   5
                //Return 3, which is the length of the path [4,2,1,3] or [5,2,1,3].
                new object[] { new TreeNode(1) { left = new TreeNode(2) { left = new TreeNode(4), right = new TreeNode(5)}, right = new TreeNode(3) }, 3 }
            };
        }

        // 236. Lowest Common Ancestor of a Binary Tree https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
        /// <summary>
        /// Given a binary tree, find the lowest common ancestor (LCA) of two given nodes in the tree.
        /// According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes p and q as the lowest node in T that has both p and q as descendants(where we allow a node to be a descendant of itself).”
        /// </summary>
        [Theory]
        [MemberData(nameof(GetLowestCommonAncestorOfABinaryTreeData))]
        public void LowestCommonAncestorOfABinaryTree(TreeNode root, TreeNode p, TreeNode q, TreeNode expected)
        {
            TreeNode result = null;

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetLowestCommonAncestorOfABinaryTreeData()
        {
            var p1 = new TreeNode(5) { left = new TreeNode(6) , right = new TreeNode(2) { left = new TreeNode(7), right = new TreeNode(4)} };
            var q1 = new TreeNode(1) { left = new TreeNode(0), right = new TreeNode(8) };

            var root1 = new TreeNode(3) { left = p1, right = q1 };
            var expected1 = root1;

            var q2 = new TreeNode(4);
            var p2 = new TreeNode(5) { left = new TreeNode(6), right = new TreeNode(2) { left = new TreeNode(7), right = q2 } };
            
            var root2 = new TreeNode(3) { left = p2, right = new TreeNode(1) { left = new TreeNode(0), right = new TreeNode(8) } };
            var expected2 = root1;

            return new[]
            {
                new object[] { root1, p1, q1, expected1 },
                new object[] { root2, p2, q2, expected2 }
            };
        }

        // 114. Flatten Binary Tree to Linked List https://leetcode.com/problems/flatten-binary-tree-to-linked-list/
        // Given a binary tree, flatten it to a linked list in-place.
        [Theory]
        [MemberData(nameof(GetFlattenBinaryTreeToLinkedListData))]
        public void FlattenBinaryTreeToLinkedList(TreeNode root, TreeNode expected)
        {
            TreeNode result = null;

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetFlattenBinaryTreeToLinkedListData()
        {
            // For example, given the following tree:
            //    1
            //   / \
            //  2   5
            // / \   \
            //3   4   6
            //The flattened tree should look like:
            //1
            // \
            //  2
            //   \
            //    3
            //     \
            //      4
            //       \
            //        5
            //         \
            //          6
            var root = new TreeNode(1) { left = new TreeNode(2) { left = new TreeNode(1), right = new TreeNode(3) }, right = new TreeNode(5) { right = new TreeNode(6) } };
            var expected = new TreeNode(1) { right = new TreeNode(2) { right = new TreeNode(3) { right = new TreeNode(4) { right = new TreeNode(5) { right = new TreeNode(6) } } } } };
            return new[]
            {
                new object[] { root,  expected }
            };
        }

        // 437. Path Sum III https://leetcode.com/problems/path-sum-iii/
        /// <summary>
        /// You are given a binary tree in which each node contains an integer value.
        /// Find the number of paths that sum to a given value.
        /// The path does not need to start or end at the root or a leaf, but it must go downwards(traveling only from parent nodes to child nodes).
        /// The tree has no more than 1,000 nodes and the values are in the range -1,000,000 to 1,000,000.
        /// </summary>
        [Theory]
        [MemberData(nameof(GetPathSumIIIData))]
        public void PathSumIII(TreeNode root, int sum, int expected)
        {
            int result = 0;

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetPathSumIIIData()
        {
            // root = [10, 5, -3, 3, 2, null, 11, 3, -2, null, 1], sum = 8
            //       10
            //      /  \
            //     5 - 3
            //    / \    \
            //   3   2   11
            //  / \   \
            // 3 - 2   1
            // Return 3.The paths that sum to 8 are:
            // 1.  5-> 3
            // 2.  5-> 2-> 1
            // 3. - 3-> 11
            return new[]
            {
                new object[] { new TreeNode(10) { left = new TreeNode(5) { left = new TreeNode(3) { left = new TreeNode(3), right = new TreeNode(-2)}, right = new TreeNode(2) { right = new TreeNode(1)} }, right = new TreeNode(-3) { right = new TreeNode(11) } }, 8, 3 }
            };
        }

        // 337. House Robber III https://leetcode.com/problems/house-robber-iii/
        /// <summary>
        /// The thief has found himself a new place for his thievery again. 
        /// There is only one entrance to this area, called the "root." Besides the root, each house has one and only one parent house. 
        /// After a tour, the smart thief realized that "all houses in this place forms a binary tree". 
        /// It will automatically contact the police if two directly-linked houses were broken into on the same night.
        /// Determine the maximum amount of money the thief can rob tonight without alerting the police.
        /// </summary>
        [Theory]
        [MemberData(nameof(GetHouseRobberIIIData))]
        public void HouseRobberIII(TreeNode root, int expected)
        {
            int result = 0;

            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetHouseRobberIIIData()
        {
            // Example 1:

            // Input: [3, 2, 3, null, 3, null, 1]

            //     3
            //    / \
            //   2   3
            //    \   \ 
            //     3   1

            // Output: 7
            // Explanation: Maximum amount of money the thief can rob = 3 + 3 + 1 = 7.
            // Example 2:

            // Input: [3, 4, 5, 1, 3, null, 1]

            //     3
            //    / \
            //   4   5
            //  / \   \ 
            // 1   3   1

            //Output: 9
            //Explanation: Maximum amount of money the thief can rob = 4 + 5 = 9.
            return new[]
            {
                new object[] { new TreeNode(3) { left = new TreeNode(2) { right = new TreeNode(3) }, right = new TreeNode(3) { right = new TreeNode(1) } }, 7 }, // Explanation: Maximum amount of money the thief can rob = 3 + 3 + 1 = 7.
                new object[] { new TreeNode(3) { left = new TreeNode(4) { left = new TreeNode(1), right = new TreeNode(3) }, right = new TreeNode(5) { right = new TreeNode(1) } }, 9 } // Explanation: Maximum amount of money the thief can rob = 4 + 5 = 9.
            };
        }
    }
}
