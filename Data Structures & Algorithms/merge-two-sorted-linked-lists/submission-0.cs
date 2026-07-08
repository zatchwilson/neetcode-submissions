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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        return MergeLists(list1, list2);
    }

    private ListNode MergeLists(ListNode l1, ListNode l2)
    {
        if (l1 == null && l2 == null)
            return null;
        
        if (l1 == null)
            return l2;
        
        if (l2 == null)
            return l1;

        if (l1.val <= l2.val)
        {
            l1.next = MergeLists(l1.next, l2);
            return l1;
        }
        else
        {
            l2.next = MergeLists(l1, l2.next);
            return l2;
        }
    }
}