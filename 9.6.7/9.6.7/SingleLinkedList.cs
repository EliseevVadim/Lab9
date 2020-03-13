using System;
using System.Collections.Generic;
using System.Text;

namespace _9._6._7
{
    class ListNode
    {
        public int data;
        public ListNode next;
        public ListNode prev;
    }
    public class DoubleLinkedList
    {
        ListNode head = null;
        ListNode tail = null;
        public void AddElement(int element)
        {
            ListNode node = new ListNode();
            node.data = element;
            node.next = null;
            node.prev = null;
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.next = node;
                node.prev = tail;
            }
            tail = node;
        }
        public void PrintList()
        {
            ListNode node = head;
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
        }        
        public int Length()
        {
            int length = 0;
            for (ListNode node = head; node != null; node = node.next, length++) ;
            return length;
        }
        public int [] ElementsFromEndToArray()
        {
            ListNode node = tail;
            int[] arr = new int[Length()];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = node.data;
                node = node.prev;
            }
            return arr;
        }
    }    
}
