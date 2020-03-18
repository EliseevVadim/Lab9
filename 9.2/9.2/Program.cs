using System;
using System.Collections.Generic;
namespace _9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            Console.WriteLine("Введите выражение");
            string s = Console.ReadLine();
            try
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(')
                    {
                        stack.Push(s[i]);
                    }
                    if (s[i] == ')')
                    {
                        stack.Pop();
                    }
                }
                if (stack.Count == 0)
                {
                    Console.WriteLine("Выражение корректно");
                }
                else
                {
                    Console.WriteLine("Выражение некорректно");
                }
            }
            catch
            {
                Console.WriteLine("Выражение некорректно");
            }
        }
    }
}
