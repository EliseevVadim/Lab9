using System;
using System.Collections.Generic;
namespace _9._6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDecision();
            LinkedListDecision();
        }
        static void ListDecision()
        {
            Random rand = new Random();
            List<int> firstlist = new List<int>();
            List<int> secondlist = new List<int>();
            int position = rand.Next(5, 15);
            for (int i = 0; i < position; i++)
            {
                firstlist.Add(rand.Next(0, 50));
                secondlist.Add(rand.Next(0, 50));
            }
            Console.WriteLine("List1: ");
            for (int i = 0; i < firstlist.Count; i++)
            {
                Console.Write(firstlist[i] + " ");
            }
            Console.WriteLine("\nList2: ");
            for (int i = 0; i < secondlist.Count; i++)
            {
                Console.Write(secondlist[i] + " ");
            }
            for (int i=secondlist.Count-1; i>=0; i--)
            {
                firstlist.Add(secondlist[i]);
            }
            Console.WriteLine("\nModified List1: ");
            for (int i=0;i<firstlist.Count; i++)
            {
                Console.Write(firstlist[i]+" ");
            }            
        }
        static void LinkedListDecision()
        {
            DoubleLinkedList list1 = new DoubleLinkedList();
            DoubleLinkedList list2 = new DoubleLinkedList();
            Random random = new Random();
            int pos = random.Next(5, 15);
            for (int i=0; i<pos; i++)
            {
                list1.AddElement(random.Next(0, 50));
                list2.AddElement(random.Next(0, 50));
            }
            Console.WriteLine("\nLinkedList1: ");
            list1.PrintList();
            Console.WriteLine("\nLinkedList2: ");
            list2.PrintList();
            Console.WriteLine("\nModified LinkedList1: ");
            int[] array = list2.ElementsFromEndToArray();
            for (int i=0; i<array.Length; i++)
            {
                list1.AddElement(array[i]);
            }
            list1.PrintList();
        }
    }
}
