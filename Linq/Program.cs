using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linq");


            Task1();


            Task2();


            Task3();


            Task4();

            Console.Read();
        }

        static void Task1()
        {
            Console.WriteLine("Первое задание");
            
            int randNumber = new Random().Next(300000, 500000);
            string numbersStr = randNumber.ToString();

            var editedList = from elem in numbersStr
                             select elem;
            editedList = editedList.Reverse();
            Console.Write(randNumber + $"=>[{string.Join(", ", editedList)}]\n");
        }

        static void Task2()
        {
            Console.WriteLine("Второе задание");

            int[] numbers = { 1, 2, 3, 4, 5, -10, -9, -8, -7, -6 };

            var positiveNumbersList = from elem in numbers
                                      where elem > 0
                                      select elem;

            var negativeNumbersList = from elem in numbers
                                      where elem < 0
                                      select elem;

            int[] results = { positiveNumbersList.Count(), negativeNumbersList.Sum() };

            Console.WriteLine($"[{string.Join(", ", numbers)}]=>[{string.Join(", ", results)}]");
        }

        static void Task3()
        {
            Console.WriteLine("Третье задание");

            string[] objects = { "Faridun", "Komron", "Rajab", "Ahlidin" };
            var editedList = from elem in objects
                             orderby elem.Length
                             select elem;

            Console.WriteLine($"[{string.Join(", ", objects)}]=>[{string.Join(", ", editedList)}]");
        }

        static void Task4()
        {
            Console.WriteLine("Четвертое задание");

            int[] numbers = { 3, 3, 3, 3, 3, 5 };

            var primaryNumber = numbers.GroupBy(x => x).Where(x => x.ToList().Count == 1).Select(x => x.Key);

            Console.WriteLine($"[{string.Join(", ", numbers)}]=>[{primaryNumber.ToArray()[0]}]");
        }
    }
}