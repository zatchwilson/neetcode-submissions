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
        int size = 1;

        ListNode length = head;

        while (length != null)
        {
            length = length.next;
            size++;
        }

        int delete = size - n;

        int curr = 1;

        ListNode prev = null;
        ListNode findDelete = head;

        while (curr < delete)
        {
            prev = findDelete;
            findDelete = findDelete.next;
            curr++;
        }
        
        if (prev == null)
        {
            head = findDelete.next;
        }
        else
        {
            prev.next = findDelete.next;
        }

        return head;
    }
}
