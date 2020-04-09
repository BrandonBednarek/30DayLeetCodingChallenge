using System;

/*
 * Given a non-empty, singly linked list with head node head, return a middle node of linked list.
 * If there are two middle nodes, return the second middle node.
 * 
 * 
 * Note:
 * The number of nodes in the given list will be between 1 and 100.
 * 
 * 
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

namespace MiddleOfTheLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the link list.
            LinkedList node = new LinkedList();
            for (int i = 1; i <= 6; i++)
            {
                node.InsertLast(node, i);
            }

            ListNode pointer = MiddleNode(node.head);
            while (pointer != null)
            {
                Console.Write(pointer.val + " ");
                pointer = pointer.next;
            }
        }

        public static ListNode MiddleNode(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;

            while (fast?.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public class LinkedList
        {
            public ListNode head;

            public void InsertLast(LinkedList list, int new_data)
            {
                ListNode new_node = new ListNode(new_data);
                if (list.head == null)
                {
                    list.head = new_node;
                    return;
                }
                ListNode lastNode = GetLastNode(list);
                lastNode.next = new_node;
            }

            internal ListNode GetLastNode(LinkedList singlyList)
            {
                ListNode temp = singlyList.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                return temp;
            }
        }
    }
}
