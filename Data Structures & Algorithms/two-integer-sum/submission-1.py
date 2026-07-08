class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:

        ints = {}

        for i, num in enumerate(nums):
            diff = target - num

            if diff in ints:
                return [ints[diff], i]

            ints[nums[i]] = i

        return []


        