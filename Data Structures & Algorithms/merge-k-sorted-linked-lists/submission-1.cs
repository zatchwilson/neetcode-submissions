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
    public ListNode MergeKLists(ListNode[] lists) {
        PriorityQueue<ListNode, int> pq = new();

        if (lists.Length == 0)
            return null;

        foreach (ListNode node in lists)
        {
            ListNode copy = node;
            while (copy != null)
            {
                pq.Enqueue(copy, copy.val);
                copy = copy.next;
            }
        } 

        if (pq.Count == 0)
            return null;

        ListNode head = pq.Dequeue();
        ListNode curr = head;

        while (pq.Count > 0)
        {
            curr.next = pq.Dequeue();
            curr = curr.next;
        }

        curr.next = null;

        return head;
    }
}
