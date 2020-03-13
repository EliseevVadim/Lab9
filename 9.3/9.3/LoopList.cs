using System;
using System.Collections.Generic;
using System.Text;

namespace _9._3
{
    class ListNode
    {
        public string data;
        public ListNode next;
    }
    public class LoopList
    {
        ListNode head = null;
        ListNode tail = null;
        public void Add(string name)
        {
            ListNode node = new ListNode();
            node.data = name;
            node.next = null;
            if (head == null)
            {
                head = node;
                tail = node;
                tail.next = head;
            }
            else
            {
                node.next = head;
                tail.next = node;
                tail = node;
            }
        }
        public void Print()
        {
            ListNode node = head;
            while (node != tail)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
            Console.WriteLine(tail.data);
        }
        public void Counting (string s, int num)
        {
            ListNode node = new ListNode();
            node = head;
            ListNode start;
            while (node != tail)
            {
                if (node.data == s)
                {
                    start = node;
                    goto linker1;                    
                }
                else
                {
                    node = node.next;
                }
            }
            if (tail.data == s)
            {
                start = tail;
            }
            else
            {
                Console.WriteLine("Проверьте входные данные");
                return;
            }
            linker1:
            for (int i=1; i<num; i++)
            {
                start = start.next;
                if (i == num-1)
                {
                    Console.WriteLine(start.data);
                }
            }
        }
        
    }
}
