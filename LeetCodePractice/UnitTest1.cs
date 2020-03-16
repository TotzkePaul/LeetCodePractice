using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodePractice
{
    public class UnitTest1
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
            Assert.Equal( expected,ans);
        }

        // 10. Regular Expression Matching https://leetcode.com/problems/regular-expression-matching/
        [Theory]
        [InlineData("aa", "a", false)]
        [InlineData("aa", "a*", true)]
        [InlineData("ab", ".*", true)]
        [InlineData("aab", "c*a*b", true)]
        [InlineData("mississippi", "mis*is*p*.", false)]
        public void RegularExpressionMatching(string s, string p, bool expected)
        {
            bool ans = false;

            Assert.Equal(expected, ans);
        }


        // 32. Longest Valid Parentheses https://leetcode.com/problems/longest-valid-parentheses/
        [Theory]
        [InlineData("(()", 2)] // Explanation: The longest valid parentheses substring is "()"
        [InlineData(")()())", 4)] // Explanation: The longest valid parentheses substring is "()()"
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
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)] // The median is (2 + 3)/2 = 2.5
        public void MedianOfTwoSortedArrays(int[] nums1, int[] nums2, double expected)
        {
            double ans = 0.0;

            Assert.Equal(expected, ans);
        }


        // 5. Longest Palindromic Substring https://leetcode.com/problems/longest-palindromic-substring/
        // Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.
        [Theory]
        [InlineData("babad", "bab")] // Note: "aba" is also a valid answer.
        [InlineData("cbbd", "bb")]
        public void LongestPalindromicSubstring(string s, string expected)
        {
            string ans = "";

            Assert.Equal(expected, ans);
        }

        // 3. Longest Substring Without Repeating Characters https://leetcode.com/problems/longest-substring-without-repeating-characters/
        // Given a string, find the length of the longest substring without repeating characters.
        [Theory]
        [InlineData("abcabcbb", 3)] // Explanation: The answer is "abc", with the length of 3. 
        [InlineData("bbbbb", 1)] // Explanation: The answer is "b", with the length of 1.
        [InlineData("pwwkew", 3)] // Explanation: The answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
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
        [InlineData(new int[] { 3, 4, -1, 1 }, 2)]
        [InlineData(new int[] { 7, 8, 9, 11, 12 }, 1)]
        public void FirstMissingPositive(int[] nums, int expected)
        {
            int ans = 0;

            Assert.Equal(expected, ans);
        }

        // 152. Maximum Product Subarray https://leetcode.com/problems/maximum-product-subarray/
        // Given an integer array nums, find the contiguous subarray within an array (containing at least one number) which has the largest product.
        [Theory]
        [InlineData(new int[] { 2, 3, -2, 4 }, 6)] // Explanation: [2,3] has the largest product 6.
        [InlineData(new int[] { -2, 0, -1 }, 0)] // Explanation: The result cannot be 2, because [-2,-1] is not a subarray.
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
        [InlineData(new int[] { 3, 2, 1, 0, 4 }, false)] // Explanation: You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.
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
        [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)] 
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
        [InlineData(new int[] { 2 }, 3, -1)]
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
                new object[] { board, "SEE", true },
                new object[] { board, "ABCB", false }
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
        [InlineData(new int[] { 5, 7, 7, 8, 8, 10 }, 6, new int[] { -1, -1 })]
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
            var input1 = new int[][] { new [] { 1, 3 }, new [] { 2, 6 }, new [] { 8, 10 }, new [] { 15, 18 } };
            var output1 = new int[][] { new [] { 1, 6 }, new int[] { 8, 10 }, new [] { 15, 18 } };
            var input2 = new int[][] { new [] { 1, 4 }, new [] { 4, 5 } };
            var output2 = new int[][] { new int[] { 1, 5 } };

            return new[]
            {
                new object[] { input1, output1 }, // Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into [1,6].
                new object[] { input2, output2 }  // Explanation: Intervals [1,4] and [4,5] are considered overlapping.
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
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("([)]", false)]
        [InlineData("{[]}", true)]
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
    }
}
