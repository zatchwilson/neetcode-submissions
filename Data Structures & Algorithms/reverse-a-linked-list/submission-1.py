# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        
        prev = None

        while head is not None:
            temp = head.next
            head.next = prev
            prev = head
            head = temp

        return prev
        # if head is None:
        #     return None

        # return self.recursiveRev(None, head)

        
    # def recursiveRev(prev: Optional[ListNode], curr: Optional[ListNode]) -> Optional[ListNode]:
    #     if curr is None:
    #         return prev

    #     nxt = curr.next

    #     curr.next = prev

    #     return recursiveRev(curr, nxt)