class Solution:
    def maxArea(self, heights: List[int]) -> int:
        currMax = 0
        p1 = 0
        p2 = len(heights) - 1

        while p1 < p2:
            area = min(heights[p1], heights[p2]) * (p2 - p1)

            currMax = max(area, currMax)

            if heights[p1] < heights[p2]:
                p1 += 1
            else:
                p2 -= 1
        
        return currMax