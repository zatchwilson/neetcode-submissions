/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        return SumNum(l1, l2, 0);
    }

    private ListNode SumNum(ListNode l1, ListNode l2, int carry)
    {
        int currSum = 0;
        if (l1 == null && l2 == null)
        {
        if (carry == 0)
            return null;
        else
            return new ListNode(carry, null);
        }
        else if (l1 == null)
        {
            currSum = l2.val + carry;
            l1 = new ListNode(0, null);
        }
        else if (l2 == null)
        {
            currSum = l1.val + carry;
            l2 = new ListNode(0, null);
        }
        else
            currSum = l1.val + l2.val + carry;
        
        carry = 0;

        if (currSum / 10 == 1)
        {
            carry = 1;
            currSum = currSum % 10;
        } 

        return new ListNode(currSum, SumNum(l1.next, l2.next, carry));
    }
}
