using System;
using System.Collections.Generic;
using System.Text;

namespace _9._1._1
{ 
    public enum Type : byte
    {
        B,
        C,
    }
    struct Agro
    {
        public string name;
        public int sqare;
        public Type type;
        public byte productivity;
    }
    class ListNode
    {
        public Agro data;
        public ListNode next;
        public ListNode prev;
    }
    public class DoubleLinkedList
    {
        ListNode head = null;
        ListNode tail = null;
        public void Add(string s, Type t, int N, byte b )
        {
            ListNode node = new ListNode();
            node.data = new Agro() { name = s, type=t, sqare = N, productivity=b };
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
                Console.WriteLine($"{node.data.name, -20}|{node.data.type.ToString()}|{node.data.sqare, -10}|{node.data.productivity, -5}");
                node = node.next;
            }
        }
        public string GetNamePerIndex(int index)
        {
            ListNode node = head;
            for (int i=0; i<=index; i++)
            {
                string s = node.data.name;
                if (i == index)
                {
                    return s;
                }
                node = node.next;
            }
            return "Not";
        }
        public void RewriteDataPerIndex(int index, string n, Type T, int s, byte p)
        {
            ListNode node = head;
            for(int i=0; i<=index; i++)
            {
                if (i == index)
                {
                    goto Linker;
                }
                node = node.next;
            }
        Linker:
            node.data.name = n;
            node.data.type = T;
            node.data.sqare = s;
            node.data.productivity = p;
            return;
        }
        public void Finder(int minsqare)
        {
            for (ListNode node=head; node!=null; node = node.next)
            {
                if (node.data.sqare > minsqare)
                {
                    Console.WriteLine($"{node.data.name, -20}|{node.data.type.ToString()}|{node.data.sqare, -10}|{node.data.productivity, -5}");
                }
            }
        }
        public void Remove(int index)
        {
            ListNode node = head;
            for (int i = 0; i <= index; i++)
            {
                if (i == index)
                {
                    goto Linker;
                }
                node = node.next;
            }
        Linker:
            if (node.next != null)
            {
                node.next.prev = node.prev;
            }
            else
            {
                tail = node.prev;
            }
            if (node.prev != null)
            {
                node.prev.next = node.next;
            }
            else
            {
                head = node.next;
            }
        }
    }
}
