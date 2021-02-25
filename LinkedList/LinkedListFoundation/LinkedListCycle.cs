using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListFoundation
{
    public class LinkedListCycle
    {
      
        //Floyd's Cycle Finding Algorithm
        public bool HasCycle(ListNode head)
        {
            if (head == null)
                return false;

            ListNode slow = head;
            ListNode fast = head.next;

            while (slow != fast)
            {
                if (fast == null || fast.next == null)
                    return false;

                slow = slow.next;
                fast = fast.next.next;
            }

            return true;
        }

        public bool HasCycle_HashSet(ListNode head)
        {
            HashSet<ListNode> hs = new HashSet<ListNode>();

            while (head != null)
            {

                if (hs.Contains(head))
                {
                    return true;
                }

                hs.Add(head);

                head = head.next;
            }

            return false;
        }

    }
}
