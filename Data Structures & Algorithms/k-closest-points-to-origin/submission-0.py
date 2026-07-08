class Solution:
    def kClosest(self, points: List[List[int]], k: int) -> List[List[int]]:
        heap = []

        for point in points:
            num = point[0] ** 2
            num += point[1] ** 2
            num = math.sqrt(num)
            heapq.heappush(heap, (num, point))

        retList = []

        for i in range(k):
            retList.append(heapq.heappop(heap)[1])

        return retList