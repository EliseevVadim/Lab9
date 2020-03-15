using System;
using System.Collections.Generic;
namespace _9._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> dateTimes = new List<DateTime>();
            List<string> explainer = new List<string>();
            DoubleLinkedList agros = new DoubleLinkedList();
            agros.Add("Соя", Type.B, 13000, 45);
            agros.Add("Чумиза", Type.C, 8000, 17);
            agros.Add("Рис", Type.C, 25650, 24);
            bool flag = true;
            
            while (flag)
            {
                Console.WriteLine("1)Просмотр таблицы\n2)Добавить запись\n3)Удалить запись\n4)Обновить запись\n5)Поиск записей\n6)Просмотреть лог\n7)Выход");
                string inputanswer = Console.ReadLine();
                switch (inputanswer)
                {
                    case "1":
                        CC();
                        agros.PrintList();
                        CR();
                        CC();
                        break;
                    case "2":
                        CC();
                        Console.WriteLine("Введите имя");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Введите тип");
                        Type value = (Type)Enum.Parse(typeof(Type), Console.ReadLine());
                        Console.WriteLine("Введите площадь");
                        int Sqare = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите урожайность");
                        byte Productivity = byte.Parse(Console.ReadLine());
                        DateTime dt = DateTime.Now;
                        dateTimes.Add(dt);
                        string addrec = Name;
                        agros.Add(Name, value, Sqare, Productivity);
                        explainer.Add($"добавлена запись \"{addrec}\"");
                        CC();
                        break;
                    case "3":
                        CC();
                        Console.WriteLine("Введите номер удаляемой записи");
                        int remnum = int.Parse(Console.ReadLine());
                        string remrec = agros.GetNamePerIndex(remnum);
                        explainer.Add($"удалена запись \"{remrec}\"");
                        DateTime datetime = DateTime.Now;
                        dateTimes.Add(datetime);
                        agros.Remove(remnum);
                        CC();
                        break;
                    case "4":
                        CC();
                        Console.WriteLine("Введите номер редактируемой записи");
                        int number = int.Parse(Console.ReadLine());
                        string upderec = agros.GetNamePerIndex(number);
                        Console.WriteLine("Введите новое имя");
                        string newname = Console.ReadLine();
                        Console.WriteLine("Введите новый тип");
                        Type newtype = (Type)Enum.Parse(typeof(Type), Console.ReadLine());
                        Console.WriteLine("Введите новую площадь");
                        int newsqare = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите новую урожайность");
                        byte newproductivity = byte.Parse(Console.ReadLine());
                        DateTime DT = DateTime.Now;
                        agros.RewriteDataPerIndex(number, newname, newtype, newsqare, newproductivity);
                        explainer.Add($"обновлена запись \"{upderec}\"");
                        dateTimes.Add(DT);
                        CC();
                        break;
                    case "5":
                        CC();
                        Console.WriteLine("Введите минимальную площадь");
                        int minsqare = int.Parse(Console.ReadLine());
                        CC();
                        agros.Finder(minsqare);
                        CR();
                        CC();
                        break;
                    case "6":
                        CC();
                        if (dateTimes.Count < 2)
                        {
                            Console.WriteLine("Недостаточно действий");
                            for (int i = 0; i < dateTimes.Count; i++)
                            {
                                Console.WriteLine($"{dateTimes[i].Hour}:{dateTimes[i].Minute}:{dateTimes[i].Second} - {explainer[i]} ");
                            }
                            CR();
                            CC();
                        }
                        else
                        {
                            TimeSpan longestinaction = dateTimes[1].Subtract(dateTimes[0]);
                            for (int i = 0; i < dateTimes.Count; i++)
                            {
                                Console.WriteLine($"{dateTimes[i].Hour}:{dateTimes[i].Minute}:{dateTimes[i].Second} - {explainer[i]} ");
                            }
                            for (int i = 1; i < dateTimes.Count; i++)
                            {
                                if (dateTimes[i].Subtract(dateTimes[i - 1]) > longestinaction)
                                {
                                    longestinaction = dateTimes[i].Subtract(dateTimes[i - 1]);
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine($"{longestinaction.Hours}:{longestinaction.Minutes}:{longestinaction.Seconds} - Самый долгий период бездействия пользователя");
                            CR();
                            CC();
                        }
                        break;
                    case "7":
                        flag = false;
                        break;
                    default:
                        CC();
                        break;
                }
            }
        }
        static void CC()
        {
            Console.Clear();
        }
        static void CR()
        {
            Console.ReadKey();
        }
    }
}
