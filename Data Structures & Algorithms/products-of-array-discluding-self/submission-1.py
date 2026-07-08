class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        prefix = [1] * len(nums)
        suffix = [1] * len(nums)

        product = 1

        for i in range(len(nums)):
            prefix[i] = product
            product = product * nums[i]
        
        product = 1

        for i in range(len(nums) - 1, -1, -1):
            suffix[i] = product
            product = product * nums[i]

        result = []

        for i in range(len(nums)):
            result.append(prefix[i] * suffix[i])
        
        return result
            
        