class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        
        ln = len(nums)

        if ln < 3:
            return []
        
        nums.sort()

        output = []

        # -4, -1, -1, 0, 1, 2

        # -k = target = i + j
        # if i + j < target, increment i
        # if i + j > target, decrement j
        i = 0

        while i < (ln-2):
            if i > 0 and nums[i] == nums[i-1]:
                i += 1
                continue

            target = nums[i] * -1
            
            j = i + 1
            k = ln-1

            while j < k:
                cur = nums[j] + nums[k]
                if cur == target:
                    output.append([nums[i], nums[j], nums[k]])
                    j += 1
                    k -= 1
                    while j < k and nums[j] == nums[j-1]:
                        j += 1
                    
                elif cur < target:
                    j += 1
                else:
                    k-=1
            
            i += 1

        return output