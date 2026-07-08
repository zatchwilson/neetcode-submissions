# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
        count = 0

        counter = head
        while counter:
            count += 1
            counter = counter.next

        prev = None
        remover = head

        while remover:
            if n == count:
                if prev is None:
                    if remover.next is None:
                        return None
                    return remover.next
                
                prev.next = remover.next
                return head

            count -= 1
            prev = remover
            remover = remover.next
