class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        minPrice = prices[0]
        maxProfit = 0
        for i in range(len(prices)):
            if prices[i] > minPrice:
                maxProfit = max(prices[i] - minPrice, maxProfit)
            else:
                minPrice = min(minPrice, prices[i])
        return maxProfit