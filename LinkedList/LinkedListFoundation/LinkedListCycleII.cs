using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListFoundation
{
    public class LinkedListCycleII
    {
        //Given a linked list, return the node where the cycle begins.If there is no cycle, return null.

        public ListNode DetectCycle(ListNode head)
        {
            if (head == null)
                return null;
                             
            // If there is a cycle, the fast/slow pointers will intersect at some
            // node. Otherwise, there is no cycle, so we cannot find an entrance to
            // a cycle.
            ListNode intersect = getIntersection(head);
            if (intersect == null)
                return null;

            ListNode ptr1 = head;
            ListNode ptr2 = intersect;

            // To find the entrance to the cycle, we have two pointers traverse at
            // the same speed -- one from the front of the list, and the other from
            // the point of intersection.
            while (ptr1 != ptr2)
            {
                ptr1 = ptr1.next;
                ptr2 = ptr2.next;
            }

            return ptr1;
        }
        private ListNode getIntersection(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            // A fast pointer will either loop around a cycle and meet the slow
            // pointer or reach the `null` at the end of a non-cyclic list.
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    return slow;
                }
            }

            return null;
        }


        public ListNode DetectCycle_HashSet(ListNode head)
        {
            HashSet<ListNode> visited = new HashSet<ListNode>();

            ListNode node = head;
            while (node != null)
            {
                if (visited.Contains(node))
                {
                    return node;
                }
                visited.Add(node);
                node = node.next;
            }
            return null;
        }
    }
}
