using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace L9NewTask
{
    public class PopularWords
    {
        public void GetAnswer(SortedDictionary<string, int> dict)
        {
            int dc = dict.Count;
            if (dict.Count >= 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    KeyValuePair<string, int> temp = new KeyValuePair<string, int>();
                    int max = 0;
                    foreach (var item in dict)
                    {

                        if (item.Value > max)
                        {
                            max = item.Value;
                            temp = item;
                        }
                    }
                    Console.WriteLine(temp.Key);
                    dict.Remove(temp.Key);
                }
            }
            else
            {
                for (int i = 0; i < dc; i++)
                {
                    KeyValuePair<string, int> temp = new KeyValuePair<string, int>();
                    int max = 0;
                    foreach (var item in dict)
                    {

                        if (item.Value > max)
                        {
                            max = item.Value;
                            temp = item;
                        }
                    }
                    Console.WriteLine(temp.Key);
                    dict.Remove(temp.Key);
                }
            }
        }
        public SortedDictionary<string, int> InitDictionary()
        {
            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();
            string[] array = GetMas();
            for (int i = 0; i < array.Length; i++)
            {
                string temp = array[i];
                int counter = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                }
                try
                {
                    dict.Add(array[i], counter);
                }
                catch
                {

                }
            }
            return dict;
        }
        public string[] GetMas()
        {
            StreamReader reader = new StreamReader(@"d:/L9/L9NewTask/input.txt");
            string s = reader.ReadToEnd();
            string[] mas = s.Split(new char[] { '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i].Contains(",") || mas[i].Contains("."))
                {
                    int N = mas[i].IndexOfAny(new char[] { '.', ',' });
                    mas[i] = mas[i].Remove(N);
                }
            }
            return mas;
        }
    }
}
