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
        return Reverse(null, head);
    }

    private ListNode Reverse(ListNode prev, ListNode curr){
        if (curr == null)
        {
            return prev;
        }

        ListNode copy = curr.next;
        curr.next = prev;

        return Reverse(curr, copy);
    }
}
