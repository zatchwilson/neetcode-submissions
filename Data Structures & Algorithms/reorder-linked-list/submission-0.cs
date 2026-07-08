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
    public void ReorderList(ListNode head) {
if (head.next == null)
            return;

        ListNode slow = head;
        ListNode fast = head.next;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode second = slow.next;

        slow.next = null;
        ListNode secondSec = second.next;

        second.next = null;

        ListNode end = ReverseList(second, secondSec);

        MergeLists(head, end);

    }

    private ListNode ReverseList(ListNode prev, ListNode curr)
    {
        if (curr == null)
            return prev;

        ListNode copy = curr.next;
        curr.next = prev;

        return ReverseList(curr, copy);
    }

    private ListNode MergeLists(ListNode l1, ListNode l2)
    {
        if (l1 == null && l2 == null)
            return null;

        if (l1 == null)
            return l2;
        
        if (l2 == null)
            return l1;

        ListNode temp1 = l1.next;
        ListNode temp2 = l2.next;

        l1.next = l2;
        l2.next = MergeLists(temp1, temp2);

        return l1;
        
        

    }
}
