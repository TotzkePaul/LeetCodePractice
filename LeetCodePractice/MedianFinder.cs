using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCodePractice
{
    public class MedianFinderUnitTests
    {
        // 295. Find Median from Data Stream https://leetcode.com/problems/find-median-from-data-stream/
        /// <summary>
        /// Median is the middle value in an ordered integer list. If the size of the list is even, there is no middle value. So the median is the mean of the two middle value.
        /// For example,
        ///     [2, 3, 4], the median is 3
        ///     [2,3], the median is (2 + 3) / 2 = 2.5
        /// Design a data structure that supports the following two operations:
        ///     void addNum(int num) - Add a integer number from the data stream to the data structure.
        ///     double findMedian() - Return the median of all elements so far.
        /// Follow up:
        ///     If all integer numbers from the stream are between 0 and 100, how would you optimize it?
        ///     If 99% of all integer numbers from the stream are between 0 and 100, how would you optimize it?
        /// </summary>
        [Fact]
        public void MedianFinder()
        {
            MedianFinder obj = new MedianFinder();
            obj.AddNum(1);
            obj.AddNum(2);
            Assert.Equal(1.5, obj.FindMedian()); //-> 1.5
            obj.AddNum(3);
            Assert.Equal(2, obj.FindMedian()); //-> 2
        }
    }

    public class MedianFinder
    {

        /** initialize your data structure here. */
        public MedianFinder()
        {

        }

        public void AddNum(int num)
        {

        }

        public double FindMedian()
        {
            return 0.0;
        }
    }
}
