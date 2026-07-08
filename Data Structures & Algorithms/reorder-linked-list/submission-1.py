class Solution:
    def reorderList(self, head: Optional[ListNode]) -> None:
        if head is None:
            return None

        nodeIndex = {}

        fast, slow = head, head

        count = 1

        nodeIndex[count] = head

        while fast.next is not None:
            fast = fast.next
            count += 1
            nodeIndex[count] = fast

        length = count
        nodesAdded = 0
        l, r = 1, count

        while nodesAdded < length - 1:
            nodeIndex[l].next = nodeIndex[r]
            nodesAdded += 1
            if nodesAdded == length - 1:
                break
            nodeIndex[r].next = nodeIndex[l + 1]
            nodesAdded += 1

            l += 1
            r -= 1
        
        nodeIndex[r if nodesAdded % 2 == 1 else l].next = None