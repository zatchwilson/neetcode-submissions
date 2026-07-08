class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        topNums = {}
        l = len(nums) + 1

        freqs = [[] for i in range(len(nums) + 1)]

        for num in nums:
            topNums[num] = topNums.get(num, 0) + 1
        for num, count in topNums.items():
            freqs[count].append(num)

        res = []

        for i in range(len(freqs) - 1, 0, -1):
            for num in freqs[i]:
                res.append(num)
                if len(res) == k:
                    return res


        