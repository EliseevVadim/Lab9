using System;
namespace MatrixInLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матирцы NxN");
            int N = int.Parse(Console.ReadLine());
            Console.Clear();
            LinkedList<LinkedList<int>> linkedList1 = InitLinkedList(N);
            LinkedList<LinkedList<int>> linkedList2 = InitLinkedList(N);
            Console.WriteLine("First matrix");
            PrintMatrix(linkedList1, N);
            Console.WriteLine("Second matrix");
            PrintMatrix(linkedList2, N);
            Console.WriteLine("Matrix sum");
            LinkedList<LinkedList<int>> sum = GetSum(linkedList1, linkedList2, N);
            PrintMatrix(sum, N);
            Console.WriteLine("Product matrix");
            LinkedList<LinkedList<int>> multi = Multiply(linkedList1, linkedList2, N);            
            PrintMatrix(multi, N);
            LinkedList<LinkedList<int>> transposematrix1 = Transpose(linkedList1, N);
            Console.WriteLine("First matrix transposed");
            PrintMatrix(transposematrix1, N);
            LinkedList<LinkedList<int>> transposematrix2 = Transpose(linkedList2, N);
            Console.WriteLine("Second matrix transposed");
            PrintMatrix(transposematrix2, N);
        }
        static LinkedList<LinkedList<int>> Transpose (LinkedList<LinkedList<int>> linkedList, int N)
        {
            LinkedList<LinkedList<int>> transposed = new LinkedList<LinkedList<int>>();
            for (int i=0; i<N; i++)
            {
                LinkedList<int> temp = new LinkedList<int>();
                for (int j=0; j<N; j++)
                {
                    temp.AddElement(linkedList.Prepare(j).data.GetNum(i));
                }
                transposed.AddElement(temp);
            }
            return transposed;
        }
        static LinkedList<LinkedList<int>> Multiply(LinkedList<LinkedList<int>> linkedList1, LinkedList<LinkedList<int>> linkedList2, int N)
        {
            LinkedList<LinkedList<int>> multi = new LinkedList<LinkedList<int>>();
            int element = 0;
            for (int i = 0; i < N; i++)
            {
                LinkedList<int> temp = new LinkedList<int>();
                for (int j = 0; j < N; j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        element += linkedList1.Prepare(i).data.GetNum(k) * linkedList2.Prepare(k).data.GetNum(j);
                    }
                    temp.AddElement(element);
                    element = 0;
                }
                multi.AddElement(temp);
            }
            return multi;
        }
        static LinkedList<LinkedList<int>> GetSum(LinkedList<LinkedList<int>> linkedList1, LinkedList<LinkedList<int>> linkedList2, int N)
        {
            LinkedList<LinkedList<int>> sum = new LinkedList<LinkedList<int>>();
            for (int i = 0; i < N; i++)
            {
                LinkedList<int> t1 = linkedList1.Prepare(i).data;
                LinkedList<int> t2 = linkedList2.Prepare(i).data;
                LinkedList<int> tempnew = new LinkedList<int>();
                for (int j = 0; j < N; j++)
                {
                    tempnew.AddElement(t1.GetNum(j) + t2.GetNum(j));
                }
                sum.AddElement(tempnew);
            }
            return sum;
        }
        static LinkedList<LinkedList<int>> InitLinkedList(int N)
        {
            Random random = new Random();
            LinkedList<LinkedList<int>> linkedList = new LinkedList<LinkedList<int>>();
            for (int i = 0; i < N; i++)
            {
                LinkedList<int> temp = new LinkedList<int>();
                for (int j = 0; j < N; j++)
                {
                    temp.AddElement(random.Next(0, 2));
                }
                linkedList.AddElement(temp);
            }
            return linkedList;
        }
        static void PrintMatrix(LinkedList<LinkedList<int>> linkedList, int N)
        {
            for (int i = 0; i < N; i++)
            {
                LinkedList<int> temp = linkedList.Prepare(i).data;
                temp.Print();
                Console.WriteLine();
            }
        }
    }
}
