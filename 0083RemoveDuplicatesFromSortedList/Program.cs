// See https://leetcode.com/problems/remove-duplicates-from-sorted-list for more information
Console.WriteLine("Hello, World!");



//*Definition for singly - linked list.

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
    public ListNode DeleteDuplicates(ListNode head)
    {

        if (head == null) return null;

        var p = head;
        while (p.next != null)
        {
            if (p.val == p.next.val)
                p.next = p.next.next;
            else
                p = p.next;
        }

        return head;
    }
}