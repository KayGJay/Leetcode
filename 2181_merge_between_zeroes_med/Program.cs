public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MergeNodes(ListNode head)
    {
        ListNode currNode = head;
        ListNode currNew = head;
        while (currNode != null)
        {
            if (currNode.val == 0 && currNode != head)
            {
                if (currNode.next != null)
                {
                    currNew.next = currNode;
                    currNew = currNode;
                }
                else
                {
                    currNew.next = null;
                }
            }
            else
            {
                currNew.val += currNode.val;
            }
            currNode = currNode.next;
        }
        return head;
    }
}