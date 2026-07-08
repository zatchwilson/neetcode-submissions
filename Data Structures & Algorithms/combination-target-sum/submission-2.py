class Solution:
    global retList

    def combinationSum(self, nums: List[int], target: int) -> List[List[int]]:
        sumList, self.retList = [], []
        self.sumNum(0, target, nums, sumList)
        return self.retList
    
    def sumNum(self, index: int, target: int, nums: List[int], currList: List[int]):
        if index < len(nums):
            curr = nums[index]
            if target == curr:
                copy = currList.copy()
                currList.append(curr)
                self.retList.append(currList)
                self.sumNum(index + 1, target, nums, copy)
            else:
                if curr < target:
                    copy = currList.copy()
                    copy.append(curr)
                    newTarget = target - curr
                    self.sumNum(index, newTarget, nums, copy)
                    self.sumNum(index + 1, target, nums, currList)
                else:
                    self.sumNum(index + 1, target, nums, currList)