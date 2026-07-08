class Solution:
    def trap(self, height: List[int]) -> int:
        
        length = len(height)

        prefix = [0] * length
        suffix = [0] * length
        #Find prefix and suffix array (max height found thusfar)
        maxH = 0
        for i in range(length):
            prefix[i] = maxH
            maxH = max(maxH, height[i])
        
        maxH = 0
        for i in range(length-1, -1, -1):
            suffix[i] = maxH
            maxH = max(maxH, height[i])

        area = 0

        for i, depth in enumerate(height):
            a = min(prefix[i], suffix[i]) - depth
            if a > 0:
                area += a

        return area

        