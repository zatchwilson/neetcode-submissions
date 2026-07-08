class Solution:
    def findKthLargest(self, nums: List[int], k: int) -> int:
        heap = nums
        # for num in heap:
        #     num = num * -1
        
        heapq.heapify(heap)
        k = len(nums) - k + 1
        i = 0

        while i < (k-1):
            heapq.heappop(heap)
            i += 1

        return heapq.heappop(heap)