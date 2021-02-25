using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListFoundation
{
    public partial class LinkedList
    {

        
        public ListNode head = null;
        public int count = 0;
        public void Prepend(int val)
        {
            ListNode newNode = new ListNode(val);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                
            }
            count++;

        }

        public void Append(int val)
        {
            ListNode newNode = new ListNode(val);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var curr = head;
                while (curr.next != null)
                {
                    curr = curr.next;
                }

                curr.next = newNode;

            }

            count++;
        }

        public void Print()
        {
            var curr = head;
            while (curr != null)
            {
                Console.Write(curr.val + " -> ");
                curr = curr.next;

            }
        }

        public void InsertAt(int val, int index)
        {
            ListNode newNode = new ListNode(val);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                if (index == 0)
                {
                    newNode.next = head;
                    
                }
                else if (index == count)
                {
                    var curr = head;
                    while (curr.next != null)
                    {
                        curr = curr.next;
                    }

                    curr.next = newNode;
                }
                else if (index > 0 && index < count)
                {
                    var current = head;

                    for (int i = 1; i < index; i++)
                    {
                        current = current.next;
                    }

                    newNode.next = current.next;
                    current.next = newNode;
                    
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }


            count++;


        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();


            if (index == 0)
            {
                head = head.next;
            }
            else if (index == count - 1)
            {
                var current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = null;

            }
            else
            {
                var current = head;
                for (int i = 1; i < index; i++)
                {
                    current = current.next;
                }

                current.next = current.next.next;

            }
            count--;


        }

        public int GetAt(int index)
        {
            if (index == 0)
                return head.val;
            
            else if (index > 0 && index < count)
            {
                var current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.next;
                }

                return current.val;
            }
            else
                throw new IndexOutOfRangeException();
        }

        public int Search(int val)
        {
            var curr = head;
            int i =0;
            while (curr.next != null)
            {
                
                if (curr.val == val)
                {
                    break;
                }
                i++;
            }

            return i;
        }
    }
}
