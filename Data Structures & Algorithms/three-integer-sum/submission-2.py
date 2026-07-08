class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:

        if len(nums) < 3:
            return []

        res = []
        nums.sort()


        for i, a in enumerate(nums):

            if a > 0:
                break
            
            if i > 0 and a == nums[i-1]:
                continue

            l, r = i + 1, len(nums)-1

            while l < r:
                tSum = a + nums[l] + nums[r]

                if tSum > 0:
                    r -= 1
                elif tSum < 0:
                    l += 1
                else:
                    res.append([a, nums[l], nums[r]])
                    l += 1
                    r -= 1
                    while nums[l] == nums[l-1] and l < r:
                        l+=1

        return res

        
        # ln = len(nums)

        # if ln < 3:
        #     return []
        
        # nums.sort()

        # output = []

        # # -4, -1, -1, 0, 1, 2

        # # -k = target = i + j
        # # if i + j < target, increment i
        # # if i + j > target, decrement j
        # i = 0

        # while i < (ln-2):
        #     if i > 0 and nums[i] == nums[i-1]:
        #         i += 1
        #         continue

        #     target = nums[i] * -1
            
        #     j = i + 1
        #     k = ln-1

        #     while j < k:
        #         cur = nums[j] + nums[k]
        #         if cur == target:
        #             output.append([nums[i], nums[j], nums[k]])
        #             j += 1
        #             k -= 1
        #             while j < k and nums[j] == nums[j-1]:
        #                 j += 1
                    
        #         elif cur < target:
        #             j += 1
        #         else:
        #             k-=1
            
        #     i += 1

        # return output