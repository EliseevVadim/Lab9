using System;
using System.Collections.Generic;
namespace _9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            for (int i=1; i<=100000; i++)
            {
                pairs.Add(i, GetCounter(i));
            }
            List<int> outlist = InitOutList(pairs);
            for (int i=0; i<outlist.Count; i++)
            {
                Console.Write(outlist[i]+" ");
            }
        }
        static int GetCounter(int N)
        {
            int limit = (int)Math.Pow(N, 1.0 / 3);
            int counter = 0;
            for (int i=1; i<limit; i++)
            {
                for (int j=1; j<limit; j++)
                {
                    for (int k=1; k<limit; k++)
                    {
                        if (Math.Pow(i, 3) + Math.Pow(j, 3) + Math.Pow(k, 3) == N)
                        {
                            counter++;
                        }
                    }
                }
            }
            return counter;
        }
        static List<int> InitOutList (Dictionary<int, int> d)
        {
            List<int> outlist = new List<int>();
            foreach (var pair in d)
            {
                if (pair.Value > 2)
                {
                    outlist.Add(pair.Key);
                }
            }
            return outlist;
        }
    }
}
