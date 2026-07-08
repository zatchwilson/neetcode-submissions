class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        listLen = len(nums)
        prefix = [1] * listLen
        suffix = [1] * listLen
        output = [1] * listLen

        if len(nums) == 0:
            return 0


        for i in range(0, len(nums), 1):
            if i == 0:
                prefix[i] = 1
            else:
                prefix[i] = prefix[i-1] * nums[i-1]
        
        for i in range(listLen-1, -1, -1):
            if i == listLen-1:
                pass
            else:
                suffix[i] = suffix[i+1] * nums[i+1]

        for i in range(0, len(output), 1):
            output[i] = suffix[i] * prefix[i]

        return output

