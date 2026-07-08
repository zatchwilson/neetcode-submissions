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
    public ListNode ReverseList(ListNode head) {
        return ReverseNode(head, null);
    }

    private ListNode ReverseNode(ListNode curr, ListNode prev)
    {
        if (curr == null)
        {
            return prev;
        }
        else
        {
            ListNode next = curr.next;
            curr.next = prev;

            return ReverseNode(next, curr);
        }
    }
}
