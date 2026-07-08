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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode nHead = head;

        ListNode dummy = new ListNode(0, head);

        ListNode traversal = head;

        while (n > 0)
        {
            traversal = traversal.next;
            n--;
        }
        
        ListNode follower = dummy;

        // if (currIterations == n + 1)
        //     follower = follower.next;



        while (traversal != null)
        {
            traversal = traversal.next;
            follower = follower.next;
        }

        // ListNode remove = follower.next;
        follower.next = follower.next.next;
        

        return dummy.next;
    }
}
