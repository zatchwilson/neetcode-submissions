class Solution:
    def maxArea(self, heights: List[int]) -> int:

        l, r = 0, len(heights)-1

        if len(heights) == 0:
            return 0

        currMax = 0

        while l < r:
            lS = heights[l]
            rS = heights[r]

            length = r-l
            area = min(lS, rS) * length

            currMax = max(currMax, area)

            if lS < rS:
                l += 1
            else:
                r -= 1

        return currMax
            
