new Solution().RotateRight(new ListNode(0, new ListNode(1, new ListNode(2, new ListNode(3)))), 2);

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) 
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode RotateRight(ListNode head, int k)
    {
        ListNode tempNode = head;
        ListNode prevNode = head;
        int numNodes = 1;
        while (tempNode.next != null)
        {
            prevNode = tempNode;
            tempNode = tempNode.next;
            numNodes++;
        }
        k = numNodes % k;
        Console.WriteLine(numNodes);
        return head;
    }
}