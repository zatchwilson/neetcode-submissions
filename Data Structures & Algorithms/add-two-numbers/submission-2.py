# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        return self.sumNodes(l1, l2, 0)

    def sumNodes(self, n1: Optional[ListNode], n2: Optional[ListNode], carry: int) -> Optional[ListNode]:
        val = carry
        newCarry = 0
        
        if n1 is None and n2 is None:
            if carry > 0:
                return ListNode(1, None)
            return None

        if n1 is None:
            val += n2.val
            n1 = ListNode(0, None)
        elif n2 is None:
            val += n1.val
            n2 = ListNode(0, None)
        else:
            val = val + n1.val + n2.val
        
        if val >= 10:
            val = val % 10
            newCarry = 1

        return ListNode(val, self.sumNodes(n1.next, n2.next, newCarry))
