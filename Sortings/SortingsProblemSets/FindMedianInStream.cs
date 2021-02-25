using System;
using System.Collections.Generic;
using System.Text;

namespace SortingsProblemSets
{
    class FindMedianInStream
    {
        /*
         *
         import heapq


class MedianFinder(object):

    def __init__(self):
        """
        initialize your data structure here.
        """
        self.minHeap = []
        self.maxHeap = []
        heapq.heapify(self.minHeap)
        heapq.heapify(self.maxHeap)
        self.median = 0.0

    def addNum(self, num):
        """
        :type num: int
        :rtype: None
        """
        if num <= self.median:
            heapq.heappush(self.maxHeap, -num)
            if len(self.maxHeap) - len(self.minHeap) == 2:
                heapq.heappush(self.minHeap, -heapq.heappop(self.maxHeap))
        else:
            heapq.heappush(self.minHeap, num)
            if len(self.minHeap) - len(self.maxHeap) == 2:
                heapq.heappush(self.maxHeap, -heapq.heappop(self.minHeap))

        self.findMedian()

    def findMedian(self):
        """
        :rtype: float
        """
        if len(self.maxHeap) > len(self.minHeap):
            self.median = -self.maxHeap[0]
            return self.median
        elif len(self.maxHeap) < len(self.minHeap):
            self.median = self.minHeap[0]
            return self.median
        else:
            self.median = (-self.maxHeap[0] + self.minHeap[0]) / 2.0
            return self.median


# Your MedianFinder object will be instantiated and called as such:
# obj = MedianFinder()
# obj.addNum(num)
# param_2 = obj.findMedian()
         */

    }
}
