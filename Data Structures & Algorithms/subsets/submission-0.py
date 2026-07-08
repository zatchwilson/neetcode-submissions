class Solution:
    retArr = [[]]
    def subsets(self, nums: List[int]) -> List[List[int]]:
        self.retArr = []
        arr = []
        self.recur(nums, arr, 0)
        return self.retArr

    def recur(self, nums: List[int], currL: List[int], index: int) -> List[int]:
        if index < len(nums):
            self.recur(nums, currL, index + 1)
            copy = currL.copy()
            copy.append(nums[index])
            self.recur(nums, copy, index + 1)
        else:
            self.retArr.append(currL)