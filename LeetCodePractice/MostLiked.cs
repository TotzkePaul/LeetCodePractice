using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodePractice
{
    public class MostLiked
    {
        // 15. 3Sum https://leetcode.com/problems/3sum/
        [Fact]
        public void ThreeSum()
        {
            int[] nums = new[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> ans = new List<IList<int>>();

            Dictionary<int, HashSet<int>> trie = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int current = 0 - nums[i];
                HashSet<int> s = new HashSet<int>();
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (s.Contains(current - nums[j]))
                    {
                        List<int> trips = new List<int> { nums[i], nums[j], current - nums[j] };
                        trips.Sort();

                        if (trie.ContainsKey(trips[0]) && trie[trips[0]].Contains(trips[2]))
                        {

                        }
                        else if (trie.ContainsKey(trips[0]))
                        {
                            trie[trips[0]].Add(trips[2]);
                            ans.Add(trips);

                        }
                        else
                        {
                            trie[trips[0]] = new HashSet<int>();
                            trie[trips[0]].Add(trips[2]);
                            ans.Add(trips);
                        }


                    }
                    s.Add(nums[j]);
                }
            }

            List<List<int>> expected = new List<List<int>>
            {
                new List<int> {-1, 0, 1},
                new List<int> { -1, -1, 2 }
            };
            Assert.Equal(expected, ans);
        }

        // 10. Regular Expression Matching https://leetcode.com/problems/regular-expression-matching/
        [Theory]
        [InlineData("aa", "a", false)]
        //[InlineData("aa", "a*", true)]
        //[InlineData("ab", ".*", true)]
        //[InlineData("aab", "c*a*b", true)]
        //[InlineData("mississippi", "mis*is*p*.", false)]
        public void RegularExpressionMatching(string s, string p, bool expected)
        {
            bool ans = false;

            Assert.Equal(expected, ans);
        }


        // 32. Longest Valid Parentheses https://leetcode.com/problems/longest-valid-parentheses/
        [Theory]
        [InlineData("(()", 2)] // Explanation: The longest valid parentheses substring is "()"
        //[InlineData(")()())", 4)] // Explanation: The longest valid parentheses substring is "()()"
        public void LongestValidParentheses(string s, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 4. Median of Two Sorted Arrays https://leetcode.com/problems/median-of-two-sorted-arrays/
        /// <summary>
        /// There are two sorted arrays nums1 and nums2 of size m and n respectively.
        /// Find the median of the two sorted arrays.The overall run time complexity should be O(log (m+n)).
        /// You may assume nums1 and nums2 cannot be both empty.
        /// </summary>
        [Theory]
        [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2.0)] // The median is 2.0
        //[InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)] // The median is (2 + 3)/2 = 2.5
        public void MedianOfTwoSortedArrays(int[] nums1, int[] nums2, double expected)
        {
            double ans = 0.0;

            Assert.Equal(expected, ans);
        }


        // 5. Longest Palindromic Substring https://leetcode.com/problems/longest-palindromic-substring/
        // Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.
        [Theory]
        [InlineData("babad", "bab")] // Note: "aba" is also a valid answer.
        //[InlineData("cbbd", "bb")]
        public void LongestPalindromicSubstring(string s, string expected)
        {
            string ans = "";

            Assert.Equal(expected, ans);
        }

        // 3. Longest Substring Without Repeating Characters https://leetcode.com/problems/longest-substring-without-repeating-characters/
        // Given a string, find the length of the longest substring without repeating characters.
        [Theory]
        [InlineData("abcabcbb", 3)] // Explanation: The answer is "abc", with the length of 3. 
        //[InlineData("bbbbb", 1)] // Explanation: The answer is "b", with the length of 1.
        //[InlineData("pwwkew", 3)] // Explanation: The answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
        public void LongestSubstringWithoutRepeatingCharacters(string s, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 45. Jump Game II https://leetcode.com/problems/jump-game-ii/
        /// <summary>
        /// Given an array of non-negative integers, you are initially positioned at the first index of the array.
        /// Each element in the array represents your maximum jump length at that position.
        /// Your goal is to reach the last index in the minimum number of jumps.
        /// Note: You can assume that you can always reach the last index.
        /// </summary>
        [Theory]
        [InlineData(new int[] { 2, 3, 1, 1, 4 }, 2)] // Explanation: The minimum number of jumps to reach the last index is 2. Jump 1 step from index 0 to 1, then 3 steps to the last index.
        public void JumpGameII(int[] nums, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 581. Shortest Unsorted Continuous Subarray https://leetcode.com/problems/shortest-unsorted-continuous-subarray/
        /// <summary>
        /// Given an integer array, you need to find one continuous subarray that if you only sort this subarray in ascending order, then the whole array will be sorted in ascending order, too.
        /// You need to find the shortest such subarray and output its length.
        /// Note:
        ///     Then length of the input array is in range[1, 10, 000].
        ///     The input array may contain duplicates, so ascending order here means <=.
        /// </summary>
        [Theory]
        [InlineData(new int[] { 2, 6, 4, 8, 10, 9, 15 }, 5)]
        public void ShortestUnsortedContinuousSubarray(int[] nums, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 41. First Missing Positive https://leetcode.com/problems/first-missing-positive/
        // Given an unsorted integer array, find the smallest missing positive integer.
        // Note: Your algorithm should run in O(n) time and uses constant extra space.
        [Theory]
        [InlineData(new int[] { 1, 2, 0 }, 3)]
        //[InlineData(new int[] { 3, 4, -1, 1 }, 2)]
        //[InlineData(new int[] { 7, 8, 9, 11, 12 }, 1)]
        public void FirstMissingPositive(int[] nums, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 152. Maximum Product Subarray https://leetcode.com/problems/maximum-product-subarray/
        // Given an integer array nums, find the contiguous subarray within an array (containing at least one number) which has the largest product.
        [Theory]
        [InlineData(new int[] { 2, 3, -2, 4 }, 6)] // Explanation: [2,3] has the largest product 6.
        //[InlineData(new int[] { -2, 0, -1 }, 0)] // Explanation: The result cannot be 2, because [-2,-1] is not a subarray.
        public void MaximumProductSubarray(int[] nums, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 55. Jump Game https://leetcode.com/problems/jump-game/
        /// <summary>
        /// Given an array of non-negative integers, you are initially positioned at the first index of the array.
        /// Each element in the array represents your maximum jump length at that position.
        /// Determine if you are able to reach the last index.
        /// </summary>
        [Theory]
        [InlineData(new int[] { 2, 3, 1, 1, 4 }, true)] // Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
        //[InlineData(new int[] { 3, 2, 1, 0, 4 }, false)] // Explanation: You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.
        public void JumpGameI(int[] nums, bool expected)
        {
            bool ans = false;

            Assert.Equal(expected, ans);
        }

        // 76. Minimum Window Substring https://leetcode.com/problems/minimum-window-substring/
        // Given a string S and a string T, find the minimum window in S which will contain all the characters in T in complexity O(n).
        // Note:
        // If there is no such window in S that covers all characters in T, return the empty string "".
        // If there is such window, you are guaranteed that there will always be only one unique minimum window in S.
        [Theory]
        [InlineData("ADOBECODEBANC", "ABC", "BANC")]
        public void MinimumWindowSubstring(string s, string t, string expected)
        {
            string ans = "";

            Assert.Equal(expected, ans);
        }

        // 84. Largest Rectangle in Histogram https://leetcode.com/problems/largest-rectangle-in-histogram/
        [Theory]
        [InlineData(new int[] { 2, 1, 5, 6, 2, 3 }, 10)] // Explanation: The third and forth have a min height of 5. 5x2=10
        public void LargestRectangleInHistogram(int[] heights, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 33. Search in Rotated Sorted Array https://leetcode.com/problems/search-in-rotated-sorted-array/
        /// <summary>
        /// Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
        /// (i.e., [0, 1, 2, 4, 5, 6, 7] might become[4, 5, 6, 7, 0, 1, 2]).
        /// You are given a target value to search.If found in the array return its index, otherwise return -1.
        /// You may assume no duplicate exists in the array.
        /// Your algorithm's runtime complexity must be in the order of O(log n).
        /// </summary>
        [Theory]
        [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
        //[InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
        public void SearchInRotatedSortedArray(int[] nums, int target, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 322. Coin Change https://leetcode.com/problems/coin-change/
        // You are given coins of different denominations and a total amount of money amount. 
        // Write a function to compute the fewest number of coins that you need to make up that amount. 
        // If that amount of money cannot be made up by any combination of the coins, return -1.
        [Theory]
        [InlineData(new int[] { 1, 2, 5 }, 11, 3)]
        //[InlineData(new int[] { 2 }, 3, -1)]
        public void CoinChange(int[] coins, int amount, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }


        // 79. Word Search https://leetcode.com/problems/word-search/
        /// <summary>
        /// Given a 2D board and a word, find if the word exists in the grid.
        /// The word can be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring.The same letter cell may not be used more than once.
        /// Constraints:
        ///     board and word consists only of lowercase and uppercase English letters.
        ///     1 <= board.length <= 200
        ///     1 <= board[i].length <= 200
        ///     1 <= word.length <= 10^3
        /// </summary>
        [Theory]
        [MemberData(nameof(GetWordSearchData))]
        public void WordSearch(char[][] board, string word, bool expected)
        {
            bool ans = false;

            Assert.Equal(expected, ans);
        }

        public static IEnumerable<object[]> GetWordSearchData()
        {
            var board = new char[][] {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' }
            };

            return new[]
            {
                new object[] { board, "ABCCED", true },
                //new object[] { board, "SEE", true },
                //new object[] { board, "ABCB", false }
            };
        }

        // 34. Find First and Last Position of Element in Sorted Array https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
        /// <summary>
        /// Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.
        /// Your algorithm's runtime complexity must be in the order of O(log n).
        /// If the target is not found in the array, return [-1, -1].
        /// </summary>
        [Theory]
        [InlineData(new int[] { 5, 7, 7, 8, 8, 10 }, 8, new int[] { 3, 4 })]
        //[InlineData(new int[] { 5, 7, 7, 8, 8, 10 }, 6, new int[] { -1, -1 })]
        public void FindFirstAndLastPositionOfElementInSortedArray(int[] nums, int target, int[] expected)
        {
            int[] ans = null;

            Assert.Equal(expected, ans);
        }

        // 221. Maximal Square https://leetcode.com/problems/maximal-square/
        // Given a 2D binary matrix filled with 0's and 1's, find the largest square containing only 1's and return its area.
        [Theory]
        [MemberData(nameof(GetMaximalSquareData))]
        public void MaximalSquare(char[][] matrix, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        public static IEnumerable<object[]> GetMaximalSquareData()
        {
            var matrix = new char[][] {
                new char[] { '1', '0', '1', '0', '0' },
                new char[] { '1', '0', '1', '1', '1' },
                new char[] { '1', '1', '1', '1', '1' },
                new char[] { '1', '0', '0', '1', '0' }
            };

            return new[]
            {
                new object[] { matrix, 4 }
            };
        }

        // 85. Maximal Rectangle https://leetcode.com/problems/maximal-rectangle/
        // Given a 2D binary matrix filled with 0's and 1's, find the largest rectangle containing only 1's and return its area.
        [Theory]
        [MemberData(nameof(GetMaximalSquareData))]
        public void MaximalRectangle(char[][] matrix, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        public static IEnumerable<object[]> GetMaximalRectangleData()
        {
            var matrix = new char[][] {
                new char[] { '1', '0', '1', '0', '0' },
                new char[] { '1', '0', '1', '1', '1' },
                new char[] { '1', '1', '1', '1', '1' },
                new char[] { '1', '0', '0', '1', '0' }
            };

            return new[]
            {
                new object[] { matrix, 6 }
            };
        }

        // 56. Merge Intervals https://leetcode.com/problems/merge-intervals/
        // Given a collection of intervals, merge all overlapping intervals.
        // NOTE: input types have been changed on April 15, 2019. Please reset to default code definition to get new method signature.
        [Theory]
        [MemberData(nameof(GetMergeIntervalsData))]
        public void MergeIntervals(int[][] matrix, int[][] expected)
        {
            int[][] ans = null;

            CompareArrays(expected, ans);
        }

        public static IEnumerable<object[]> GetMergeIntervalsData()
        {
            var input1 = new int[][] { new[] { 1, 3 }, new[] { 2, 6 }, new[] { 8, 10 }, new[] { 15, 18 } };
            var output1 = new int[][] { new[] { 1, 6 }, new int[] { 8, 10 }, new[] { 15, 18 } };
            var input2 = new int[][] { new[] { 1, 4 }, new[] { 4, 5 } };
            var output2 = new int[][] { new int[] { 1, 5 } };

            return new[]
            {
                new object[] { input1, output1 }, // Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into [1,6].
                //new object[] { input2, output2 }  // Explanation: Intervals [1,4] and [4,5] are considered overlapping.
            };
        }

        private static void CompareArrays<T>(T[][] expected, T[][] actual)
        {
            Assert.Equal(expected == null, actual == null);
            if (expected == null || actual == null)
                return;

            Assert.Equal(expected.Length, actual.Length);

            if (expected.Length != actual.Length)
                return;

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        // 20. Valid Parentheses https://leetcode.com/problems/valid-parentheses/
        /// <summary>
        /// Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        /// An input string is valid if:
        ///     1. Open brackets must be closed by the same type of brackets.
        ///     2. Open brackets must be closed in the correct order.
        /// Note that an empty string is also considered valid.
        /// </summary>
        [Theory]
        [InlineData("()", true)]
        //[InlineData("()[]{}", true)]
        //[InlineData("(]", false)]
        //[InlineData("([)]", false)]
        //[InlineData("{[]}", true)]
        public void ValidParentheses(string s, bool expected)
        {
            bool ans = false;

            Assert.Equal(expected, ans);
        }


        // 139. Word Break https://leetcode.com/problems/word-break/
        /// <summary>
        /// Given a non-empty string s and a dictionary wordDict containing a list of non-empty words, determine if s can be segmented into a space-separated sequence of one or more dictionary words.
        /// Note:
        ///     The same word in the dictionary may be reused multiple times in the segmentation.
        ///     You may assume the dictionary does not contain duplicate words.
        /// </summary>
        [Theory]
        [MemberData(nameof(GetWordBreakData))]
        public void WordBreak(string s, IList<string> wordDict, bool expected)
        {
            bool ans = false;

            Assert.Equal(expected, ans);
        }

        public static IEnumerable<object[]> GetWordBreakData()
        {
            return new[]
            {
                new object[] { "leetcode", new List<string> { "leet", "code" }, true }, // Explanation: Return true because "leetcode" can be segmented as "leet code".
                new object[] { "applepenapple", new List<string> { "apple", "pen" }, true },
                new object[] { "catsandog", new List<string> { "cats", "dog", "sand", "and", "cat" }, false },
            };
        }

        // 438. Find All Anagrams in a String https://leetcode.com/problems/find-all-anagrams-in-a-string/
        [Theory]
        [MemberData(nameof(GetFindAllAnagramsInAStringData))]
        public void FindAllAnagramsInAString(string s, string p, IList<int> expected)
        {
            IList<int> ans = new List<int>();

            Assert.Equal(expected, ans);
        }

        public static IEnumerable<object[]> GetFindAllAnagramsInAStringData()
        {
            return new[]
            {
                // Explanation:
                //  The substring with start index = 0 is "cba", which is an anagram of "abc".
                //  The substring with start index = 6 is "bac", which is an anagram of "abc".
                new object[] { "cbaebabacd", "abc", new List<int> { 0, 6 } },
                //Explanation:
                //  The substring with start index = 0 is "ab", which is an anagram of "ab".
                //  The substring with start index = 1 is "ba", which is an anagram of "ab".
                //  The substring with start index = 2 is "ab", which is an anagram of "ab".
                new object[] { "abab", "ab", new List<int> { 0, 1, 2 } }
            };
        }

        // 239. Sliding Window Maximum https://leetcode.com/problems/sliding-window-maximum/
        /*
         * Given an array nums, there is a sliding window of size k which is moving from the very left of the array to the very right. 
         * You can only see the k numbers in the window. Each time the sliding window moves right by one position. Return the max sliding window.
         * Note:
         *      You may assume k is always valid, 1 ? k ? input array's size for non-empty array.
         * Follow up:
         *      Could you solve it in linear time?
         */
        [Theory]
        [InlineData(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3, new[] { 3, 3, 5, 5, 6, 7 })]
        public void SlidingWindowMaximum(int[] nums, int k, int[] expected)
        {
            int[] ans = null;

            Assert.Equal(expected, ans);
        }

        // 207. Course Schedule https://leetcode.com/problems/course-schedule/
        /// <summary>
        /// There are a total of numCourses courses you have to take, labeled from 0 to numCourses-1.
        /// Some courses may have prerequisites, for example to take course 0 you have to first take course 1, which is expressed as a pair: [0,1]
        /// Given the total number of courses and a list of prerequisite pairs, is it possible for you to finish all courses?
        /// Constraints:
        ///     The input prerequisites is a graph represented by a list of edges, not adjacency matrices.Read more about how a graph is represented.
        ///     You may assume that there are no duplicate edges in the input prerequisites.
        ///     1 <= numCourses <= 10^5
        /// </summary>
        [Theory]
        [MemberData(nameof(GetCourseScheduleData))]
        public void CourseSchedule(int numCourses, int[][] prerequisites, bool expected)
        {
            bool ans = false;

            Assert.Equal(expected, ans);
        }

        public static IEnumerable<object[]> GetCourseScheduleData()
        {
            return new[]
            {
                new object[] { 2, new int[][] { new[] { 1, 0} }, true }, // Explanation: There are a total of 2 courses to take. To take course 1 you should have finished course 0. So it is possible.
                //new object[] { 2, new int[][] { new[] { 1, 0}, new[] { 0, 1} }, false } // Explanation: There are a total of 2 courses to take. To take course 1 you should have finished course 0, and to take course 0 you should also have finished course 1. So it is impossible.
            };
        }

        // 72. Edit Distance https://leetcode.com/problems/edit-distance/
        /// <summary>
        /// Given two words word1 and word2, find the minimum number of operations required to convert word1 to word2.
        /// You have the following 3 operations permitted on a word:
        ///     Insert a character
        ///     Delete a character
        ///     Replace a character
        /// </summary>
        [Theory]
        [InlineData("horse", "ros", 3)] // Explanation: horse -> rorse(replace 'h' with 'r') -> rose(remove 'r') -> ros(remove 'e')
        //[InlineData("intention", "execution", 5)] // Explanation: intention -> inention(remove 't') -> enention(replace 'i' with 'e')  -> exention(replace 'n' with 'x') -> exection(replace 'n' with 'c')  -> execution(insert 'u')
        public void EditDistance(string s, string p, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 198. House Robber https://leetcode.com/problems/house-robber/
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }, 4)] // Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3). Total amount you can rob = 1 + 3 = 4.
        //[InlineData(new int[] { 2, 7, 9, 3, 1 }, 12)] // Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1). Total amount you can rob = 2 + 9 + 1 = 12.
        public void HouseRobber(int[] nums, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 301. Remove Invalid Parentheses https://leetcode.com/problems/remove-invalid-parentheses/
        // Remove the minimum number of invalid parentheses in order to make the input string valid. Return all possible results.
        // Note: The input string may contain letters other than the parentheses(and ).
        [Theory]
        [MemberData(nameof(GetRemoveInvalidParenthesesData))]
        public void RemoveInvalidParentheses(string s, IList<string> expected)
        {
            IList<string> ans = null;

            Assert.Equal(expected, ans);
        }

        public static IEnumerable<object[]> GetRemoveInvalidParenthesesData()
        {
            return new[]
            {
                new object[] { "()())()", new List<string> { "()()()", "(())()" } },
                new object[] { "(a)())()", new List<string> { "(a)()()", "(a())()" } },
                new object[] { ")(", new List<string> { "" } }
            };
        }

        // 300. Longest Increasing Subsequence https://leetcode.com/problems/longest-increasing-subsequence/
        // Given an unsorted array of integers, find the length of longest increasing subsequence.
        // Note:
        //      There may be more than one LIS combination, it is only necessary for you to return the length.
        //      Your algorithm should run in O(n^2) complexity.
        // Follow up: Could you improve it to O(n log n) time complexity?
        [Theory]
        [InlineData(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 }, 4)] // Explanation: The longest increasing subsequence is [2,3,7,101], therefore the length is 4. 
        public void LongestIncreasingSubsequence(int[] heights, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 416. Partition Equal Subset Sum https://leetcode.com/problems/partition-equal-subset-sum/
        // Given a non-empty array containing only positive integers, find if the array can be partitioned into two subsets such that the sum of elements in both subsets is equal.
        // Note:
        //      Each of the array element will not exceed 100.
        //      The array size will not exceed 200.
        [Theory]
        [InlineData(new int[] { 1, 5, 11, 5 }, true)] // Explanation: The array can be partitioned as [1, 5, 5] and [11].
        //[InlineData(new int[] { 1, 2, 3, 5 }, false)] // Explanation: The array cannot be partitioned into equal sum subsets.
        public void PartitionEqualSubsetSum(int[] nums, bool expected)
        {
            bool ans = false;

            Assert.Equal(expected, ans);
        }


        // 240. Search a 2D Matrix II https://leetcode.com/problems/search-a-2d-matrix-ii/
        // Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:
        // Integers in each row are sorted in ascending from left to right.
        // Integers in each column are sorted in ascending from top to bottom.
        [Theory]
        [MemberData(nameof(GetSearchA2DMatrixIIData))]
        public void SearchA2DMatrixII(int[,] matrix, int target, bool expected)
        {
            bool ans = false;

            Assert.Equal(expected, ans);
        }

        public static IEnumerable<object[]> GetSearchA2DMatrixIIData()
        {
            int[,] matrix = new int[,]
            {
                  {1,   4,  7,  11, 15},
                  {2,   5,  8,  12, 19},
                  {3,   6,  9,  16, 22},
                  {10,  13, 14, 17, 24},
                  {18,  21, 23, 26, 30}
            };
            return new[]
            {
                new object[] { matrix, 5, true},
                //new object[] { matrix, 20, false},
            };
        }


        // 560. Subarray Sum Equals K https://leetcode.com/problems/subarray-sum-equals-k/
        // Given an array of integers and an integer k, you need to find the total number of continuous subarrays whose sum equals to k.
        // Note:
        //      The length of the array is in range[1, 20, 000].
        //      The range of numbers in the array is [-1000, 1000] and the range of the integer k is [-1e7, 1e7].
        [Theory]
        [InlineData(new int[] { 1, 1, 1 }, 2, 2)]
        public void SubarraySumEqualsK(int[] nums, int k, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 128. Longest Consecutive Sequence https://leetcode.com/problems/longest-consecutive-sequence/
        // Given an unsorted array of integers, find the length of the longest consecutive elements sequence.
        // Your algorithm should run in O(n) complexity.
        [Theory]
        [InlineData(new int[] { 100, 4, 200, 1, 3, 2 }, 4)] // Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
        public void LongestConsecutiveSequence(int[] heights, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 279. Perfect Squares https://leetcode.com/problems/perfect-squares/
        // Given a positive integer n, find the least number of perfect square numbers (for example, 1, 4, 9, 16, ...) which sum to n.
        [Theory]
        [InlineData(12, 3)] // Explanation: 12 = 4 + 4 + 4.
        //[InlineData(13, 2)] // Explanation: 13 = 4 + 9.
        public void PerfectSquares(int n, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 75. Sort Colors https://leetcode.com/problems/sort-colors/
        /// <summary>
        /// Given an array with n objects colored red, white or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white and blue.
        /// Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.
        /// Note: You are not suppose to use the library's sort function for this problem.
        /// Follow up:
        ///     A rather straight forward solution is a two-pass algorithm using counting sort.
        ///     First, iterate the array counting number of 0's, 1's, and 2's, then overwrite array with total number of 0's, then 1's and followed by 2's.
        ///     Could you come up with a one-pass algorithm using only constant space?
        /// </summary>
        [Theory]
        [InlineData(new[] { 2, 0, 2, 1, 1, 0 }, new[] { 0, 0, 1, 1, 2, 2 })]
        public void SortColors(int[] nums, int[] expected)
        {
            int[] ans = nums;

            Assert.Equal(expected, ans);
        }

        // 200. Number of Islands https://leetcode.com/problems/number-of-islands/
        /// <summary>
        /// Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. 
        /// An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. 
        /// You may assume all four edges of the grid are all surrounded by water.
        /// </summary>
        [Theory]
        [MemberData(nameof(GetNumberOfIslandsData))]
        public void NumberOfIslands(char[][] grid, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        public static IEnumerable<object[]> GetNumberOfIslandsData()
        {
            var grid1 = new char[][] {
                new char[] { '1', '1', '1', '1', '0' },
                new char[] { '1', '1', '0', '1', '0' },
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '0', '0', '0' }
            };

            var grid2 = new char[][] {
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '1', '0', '0' },
                new char[] { '0', '0', '0', '1', '1' }
            };

            return new[]
            {
                new object[] { grid1, 1 },
                //new object[] { grid2, 3 }
            };
        }

        // 338. Counting Bits https://leetcode.com/problems/counting-bits/
        /// <summary>
        /// Given a non negative integer number num. For every numbers i in the range 0 ? i ? num calculate the number of 1's in their binary representation and return them as an array.
        /// Follow up:
        ///     It is very easy to come up with a solution with run time O(n*sizeof(integer)). But can you do it in linear time O(n) /possibly in a single pass?
        ///     Space complexity should be O(n).
        ///     Can you do it like a boss? Do it without using any builtin function like __builtin_popcount in c++ or in any other language.
        /// </summary>
        [Theory]
        [InlineData(2, new[] { 0, 1, 1 })]
        //[InlineData(5, new [] { 0, 1, 1, 2, 1, 2 })]
        public void CountingBits(int num, int[] expected)
        {
            int[] ans = null;

            Assert.Equal(expected, ans);
        }

        // 136. Single Number https://leetcode.com/problems/single-number/
        // Given a non-empty array of integers, every element appears twice except for one. Find that single one.
        //Note:
        //      Your algorithm should have a linear runtime complexity.Could you implement it without using extra memory?
        [Theory]
        [InlineData(new[] { 2, 2, 1 }, 1)]
        //[InlineData(new[] { 4, 1, 2, 1, 2 }, 4)]
        public void SingleNumber(int[] nums, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 739. Daily Temperatures https://leetcode.com/problems/daily-temperatures/
        /// <summary>
        /// Given a list of daily temperatures T, return a list such that, for each day in the input, tells you how many days you would have to wait until a warmer temperature. 
        /// If there is no future day for which this is possible, put 0 instead.
        /// For example, given the list of temperatures T = [73, 74, 75, 71, 69, 72, 76, 73], your output should be[1, 1, 4, 2, 1, 1, 0, 0].
        /// Note: The length of temperatures will be in the range[1, 30000]. Each temperature will be an integer in the range[30, 100].
        /// </summary>
        [Theory]
        [InlineData(new[] { 73, 74, 75, 71, 69, 72, 76, 73 }, new[] { 1, 1, 4, 2, 1, 1, 0, 0 })]
        public void DailyTemperatures(int[] T, int[] expected)
        {
            int[] ans = T;

            Assert.Equal(expected, ans);
        }


        // 647. Palindromic Substrings https://leetcode.com/problems/palindromic-substrings/
        // Given a string, your task is to count how many palindromic substrings in this string.
        // The substrings with different start indexes or end indexes are counted as different substrings even they consist of same characters.
        // Note: The input string length won't exceed 1000.
        [Theory]
        [InlineData("abc", 3)] // Explanation: Three palindromic strings: "a", "b", "c".
        //[InlineData("aaa", 6)] // Explanation: Six palindromic strings: "a", "a", "a", "aa", "aa", "aaa".
        public void PalindromicSubstrings(string s, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 238. Product of Array Except Self https://leetcode.com/problems/product-of-array-except-self/
        /// <summary>
        /// Given an array nums of n integers where n > 1,  return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].
        /// Constraint: It's guaranteed that the product of the elements of any prefix or suffix of the array (including the whole array) fits in a 32 bit integer.
        /// Note: Please solve it *without division* and in O(n).
        /// Follow up:
        /// Could you solve it with constant space complexity? (The output array does not count as extra space for the purpose of space complexity analysis.)
        /// </summary>
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
        public void ProductOfArrayExceptSelf(int[] nums, int[] expected)
        {
            int[] ans = null;

            Assert.Equal(expected, ans);
        }

        // 283. Move Zeroes https://leetcode.com/problems/move-zeroes/
        // Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        // Note:
        //      You must do this in-place without making a copy of the array.
        //      Minimize the total number of operations.
        [Theory]
        [InlineData(new[] { 0, 1, 0, 3, 12 }, new[] { 241, 3, 12, 0, 0 })]
        public void MoveZeroes(int[] nums, int[] expected)
        {
            int[] ans = null;

            Assert.Equal(expected, ans);
        }


        // 169. Majority Element https://leetcode.com/problems/majority-element/
        // Given an array of size n, find the majority element. The majority element is the element that appears more than ? n/2 ? times.
        // You may assume that the array is non-empty and the majority element always exist in the array.
        [Theory]
        [InlineData(new[] { 3, 2, 3 }, 3)]
        //[InlineData(new[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
        public void MajorityElement(int[] nums, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 62. Unique Paths https://leetcode.com/problems/unique-paths/
        // A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).
        // The robot can only move either down or right at any point in time.The robot is trying to reach the bottom-right corner of the grid(marked 'Finish' in the diagram below).
        // How many possible unique paths are there?
        // Constraints:
        //      1 <= m, n <= 100
        //      It's guaranteed that the answer will be less than or equal to 2 * 10 ^ 9.
        [Theory]
        [InlineData(3, 2, 3)]
        //[InlineData(7, 3, 28)]
        public void UniquePaths(int m, int n, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }


        // 312. Burst Balloons https://leetcode.com/problems/burst-balloons/
        /// <summary>
        /// Given n balloons, indexed from 0 to n-1. Each balloon is painted with a number on it represented by array nums. You are asked to burst all the balloons. 
        /// If the you burst balloon i you will get nums[left] * nums[i] * nums[right] coins. Here left and right are adjacent indices of i. After the burst, the left and right then becomes adjacent.
        /// Find the maximum coins you can collect by bursting the balloons wisely.
        /// Note:
        ///     You may imagine nums[-1] = nums[n] = 1.They are not real therefore you can not burst them.
        ///     0 ? n ? 500, 0 ? nums[i] ? 100
        /// </summary>
        [Theory]
        [InlineData(new[] { 3, 1, 5, 8 }, 167)] // Explanation: nums = [3,1,5,8] --> [3,5,8] -->   [3,8]   -->  [8]  --> [] // coins =  3*1*5      +  3*5*8    +  1*3*8      + 1*8*1   = 167
        public void BurstBalloons(int[] nums, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 96. Unique Binary Search Trees https://leetcode.com/problems/unique-binary-search-trees/
        // Given n, how many structurally unique BST's (binary search trees) that store values 1 ... n?
        // Given n = 3, there are a total of 5 unique BST's:
        //    1         3     3      2      1
        //     \       /     /      / \      \
        //      3     2     1      1   3      2
        //     /     /       \                 \
        //    2     1         2                 3
        [Theory]
        [InlineData(3, 5)]
        public void UniqueBinarySearchTrees(int n, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }


        // 121. Best Time to Buy and Sell Stock https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
        /// <summary>
        /// Say you have an array for which the i^th element is the price of a given stock on day i.
        /// If you were only permitted to complete at most one transaction(i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.
        /// Note that you cannot sell a stock before you buy one.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 5)] // Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5. Not 7-1 = 6, as selling price needs to be larger than buying price.
        //[InlineData(new[] { 7, 6, 4, 3, 1 }, 0)] // Explanation: In this case, no transaction is done, i.e. max profit = 0.
        public void BestTimeToBuyAndSellStock(int[] nums, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 394. Decode String https://leetcode.com/problems/decode-string/
        /// <summary>
        /// Given an encoded string, return its decoded string.
        /// The encoding rule is: k[encoded_string], where the encoded_string inside the square brackets is being repeated exactly k times.Note that k is guaranteed to be a positive integer.
        /// You may assume that the input string is always valid; No extra white spaces, square brackets are well-formed, etc.
        /// Furthermore, you may assume that the original data does not contain any digits and that digits are only for those repeat numbers, k.For example, there won't be input like 3a or 2[4].
        /// </summary>
        [Theory]
        [InlineData("3[a]2[bc]", "aaabcbc")]
        //[InlineData("3[a2[c]]", "accaccacc")]
        //[InlineData("2[abc]3[cd]ef", "abcabccdcdcdef")]
        public void DecodeString(string s, string expected)
        {
            string ans = null;

            Assert.Equal(expected, ans);
        }

        // 621. Task Scheduler https://leetcode.com/problems/task-scheduler/
        /// <summary>
        /// Given a char array representing tasks CPU need to do. It contains capital letters A to Z where different letters represent different tasks. 
        /// Tasks could be done without original order. Each task could be done in one interval. For each interval, CPU could finish one task or just be idle.
        /// However, there is a non-negative cooling interval n that means between two same tasks, there must be at least n intervals that CPU are doing different tasks or just be idle.
        /// You need to return the least number of intervals the CPU will take to finish all the given tasks.
        /// </summary>
        [Theory]
        [InlineData(new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 2, 8)] // Explanation: A -> B -> idle -> A -> B -> idle -> A -> B.
        public void TaskScheduler(char[] tasks, int n, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }


        // 42. Trapping Rain Water https://leetcode.com/problems/trapping-rain-water/
        // Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.
        [Theory]
        [InlineData(new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
        public void TrappingRainWater(int[] height, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }


        // 11. Container With Most Water https://leetcode.com/problems/container-with-most-water/
        /// <summary>
        /// Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai). 
        /// n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). Find two lines, which together with x-axis forms a container, such that the container contains the most water.
        /// Note: You may not slant the container and n is at least 2.
        /// </summary>
        [Theory]
        [InlineData(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        public void ContainerWithMostWater(int[] height, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }


        // 287. Find the Duplicate Number
        /// <summary>
        /// Given an array nums containing n + 1 integers where each integer is between 1 and n (inclusive), prove that at least one duplicate number must exist. Assume that there is only one duplicate number, find the duplicate one.
        /// Note:
        ///     You must not modify the array(assume the array is read only).
        ///     You must use only constant, O(1) extra space.
        ///     Your runtime complexity should be less than O(n^2).
        ///     There is only one duplicate number in the array, but it could be repeated more than once.
        /// </summary>
        [Theory]
        [InlineData(new[] { 1, 3, 4, 2, 2 }, 2)]
        //[InlineData(new[] { 3, 1, 3, 4, 2 }, 3)]
        public void FindTheDuplicateNumber(int[] nums, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }


        // 494. Target Sum https://leetcode.com/problems/target-sum/
        /// <summary>
        /// You are given a list of non-negative integers, a1, a2, ..., an, and a target, S. Now you have 2 symbols + and -. For each integer, you should choose one from + and - as its new symbol.
        /// Find out how many ways to assign symbols to make sum of integers equal to target S.
        /// Note:
        ///     The length of the given array is positive and will not exceed 20.
        ///     The sum of elements in the given array will not exceed 1000.
        ///     Your output answer is guaranteed to be fitted in a 32-bit integer.
        /// </summary>
        [Theory]
        [InlineData(new[] { 1, 1, 1, 1, 1 }, 3, 5)]
        public void TargetSum(int[] nums, int s, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }


        // 70. Climbing Stairs https://leetcode.com/problems/climbing-stairs/
        // You are climbing a stair case. It takes n steps to reach to the top.
        // Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
        // Note: Given n will be a positive integer.
        [Theory]
        [InlineData(2, 2)] // Explanation: There are two ways to climb to the top. 1. 1 step + 1 step 2. 2 steps
        //[InlineData(3, 3)] // Explanation: There are three ways to climb to the top. 1. 1 step + 1 step + 1 step 2. 1 step + 2 steps 3. 2 steps + 1 step
        public void ClimbingStairs(int n, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }


        // 53. Maximum Subarray https://leetcode.com/problems/maximum-subarray/
        // Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
        // Follow up: If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
        [Theory]
        [InlineData(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)] // Explanation: [4,-1,2,1] has the largest sum = 6.
        public void MaximumSubarray(int[] nums, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }


        //309. Best Time to Buy and Sell Stock with Cooldown https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown/
        /// <summary>
        /// Say you have an array for which the ith element is the price of a given stock on day i.
        /// Design an algorithm to find the maximum profit.You may complete as many transactions as you like (ie, buy one and sell one share of the stock multiple times) with the following restrictions:
        /// You may not engage in multiple transactions at the same time(ie, you must sell the stock before you buy again).
        /// 
        /// After you sell your stock, you cannot buy stock on next day. (ie, cooldown 1 day)
        /// </summary>
        [Theory]
        [InlineData(new[] { 1, 2, 3, 0, 2 }, 3)] // Explanation: transactions = [buy, sell, cooldown, buy, sell]
        public void BestTimeToBuyAndSellStockWithCooldown(int[] prices, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }


        // 1. Two Sum https://leetcode.com/problems/two-sum/
        // Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        // You may assume that each input would have exactly one solution, and you may not use the same element twice.
        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })] // Explanation: Because nums[0] + nums[1] = 2 + 7 = 9,
        public void TwoSum(int[] nums, int target, int[] expected)
        {
            int[] ans = null;

            Assert.Equal(expected, ans);
        }

        // 215. Kth Largest Element in an Array https://leetcode.com/problems/kth-largest-element-in-an-array/
        // Find the kth largest element in an unsorted array. Note that it is the kth largest element in the sorted order, not the kth distinct element.
        // Note: You may assume k is always valid, 1 <= k <= array's length.
        [Theory]
        [InlineData(new[] { 3, 2, 1, 5, 6, 4 }, 2, 5)]
        //[InlineData(new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4, 4)]
        public void KthLargestElement(int[] nums, int k, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

    }
}
