// See https://leetcode.com/problems/merge-two-sorted-lists/ for more information
Console.WriteLine("Hello, World!");


//Definition for singly-linked list.
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        var mergedList = new ListNode(0); //Build our list on this
        var head = mergedList; //This will point to the head of the list that we are building

        //compare heads of the two lists that we are given
        while (list1 != null && list2 != null) //while we have two lists to compare
        {
            if (list1.val < list2.val)
            {
                mergedList.next = list1; //since list1.val is smaller, we add it to the mergedList list we are building
                list1 = list1.next; //We move this forward since we've handled that value
            }
            else
            {
                mergedList.next = list2; //since list2.val is smaller, we add it to the mergedList list we are building
                list2 = list2.next;  //We move this forward since we've handled that value
            }

            //now that we've handled adding the first item to the new mergedList list, we have to move it forward
            //so that we don't just overwrite it
            mergedList = mergedList.next;

        }

        //the loop is over, but what if one list was longer than the other?
        //since both lists are already sorted, when can just append any "leftovers" to the end of our merged list.
        if (list1 != null)
        {
            mergedList.next = list1;
        }

        if (list2 != null)
        {
            mergedList.next = list2;
        }

        return head.next;
    }
}