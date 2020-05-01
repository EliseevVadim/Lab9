using System;
using System.Text;

namespace MatrixInLinkedList
{
    public class LinkedListNode<T>
    {
        public T data;
        public LinkedListNode<T> next;
        public LinkedListNode<T> prev;
    }
    public class LinkedList<T>
    {
        LinkedListNode<T> head = null;
        LinkedListNode<T> tail = null;
        public void AddElement(T element)
        {
            LinkedListNode<T> node = new LinkedListNode<T>();
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
        public void Print()
        {
            LinkedListNode<T> node = head;
            while (node != null)
            {
                Console.Write(node.data+ " ");
                node = node.next;
            }
        }
        public LinkedListNode<T> Prepare(int N)
        {
            LinkedListNode<T> node = head;
            for (int i = 0; i < N; i++)
            {
                node = node.next;
            }
            return node;
        }
        public T GetNum(int K)
        {
            LinkedListNode<T> node = head;
            for (int i=0; i<K; i++)
            {
                node = node.next;
            }
            return node.data;
        }
    }
}
