using System;
using System.IO;
namespace _9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите считалочку: ");
            string input = Console.ReadLine();
            Console.WriteLine("Введите имя человека с которого начнем: ");
            string name = Console.ReadLine();
            string[] countingarr = GetCountingArray(input);            
            string[] names = InitNamesArray();
            LoopList list = LoopListInit(names);            
            Console.WriteLine("Выходит");
            list.Counting(name, countingarr.Length);
        }
        static string [] InitNamesArray()
        {
            StreamReader reader = File.OpenText(@"d:\L9\9.3\names.txt");
            string[] names = new string[10];
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = reader.ReadLine();
            }
            reader.Close();
            return names;            
        }
        static string [] GetCountingArray(string s)
        {
            string [] arr=s.Split(new char[] {' ' });
            return arr;
        }
        static LoopList LoopListInit(string [] arr)
        {
            LoopList list = new LoopList();
            for (int i = 0; i < arr.Length; i++)
            {
                list.Add(arr[i]);
            }
            return list; 
        }
    }
}
