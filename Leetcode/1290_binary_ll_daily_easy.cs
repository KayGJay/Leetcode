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

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
       this.val = val;
       this.next = next;
    }
}
public class Solution
{
    public int GetDecimalValue(ListNode head)
    {
        int result = 0;
        while (head != null)
        {
            result *= 2;
            result += head.val;
            head = head.next;
        }
        return result;
    }
}