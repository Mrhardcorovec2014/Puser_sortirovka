using System;

namespace Sortirovka
{
    class Program
    {
        static int[] Sorting(int[] mas)
        {
            bool isSorted = true;
            int replacement;
            for (int l = 0; l < mas.Length; l++)
            {
                if (l != mas.Length - 1 && mas[l] > mas[l + 1])
                {
                    isSorted = false;
                    replacement = mas[l];
                    mas[l] = mas[l + 1];
                    mas[l + 1] = replacement;
                }
            }
            /*Console.WriteLine(" ");
            Console.Write("Отсортированный массив");
            Console.WriteLine(" ");
            for (int o = 0; o < mas.Length; o++)
            {
                Console.Write(mas[o] + " ");
            }*/
            return isSorted ? mas:Sorting(mas);
        }

        static void Exit(int[] mas)
        {
            Console.WriteLine(" ");
            Console.Write("Отсортированный массив");
            Console.WriteLine(" ");
            for (int o = 0; o < mas.Length; o++)
            {
                Console.Write(mas[o] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Привествую! Выберите метод ввода элементов сортировки:" + "\r\n" + "1. Вводить самому элементы массива" + "\r\n" + "2.Включить рандомайзер для элементов" + "\r\n" +
                                "Примечание: в случае выбора рандомайзера, элементы массива будут валироваться от 0 до 100");
            int input_setting;
            while (!int.TryParse(Console.ReadLine(), out input_setting))
            {
                Console.WriteLine("Ошибка ввода! Введите 1 или 2");
            }
            if (input_setting == 1)
            {
                Choise1();
            }
            else if (input_setting == 2)
            {
                Choise2();
            }
        }

        private static void Choise2()
        {
            Console.WriteLine("Введите кол-во элементов массива:");
            int quantity;
            while (!int.TryParse(Console.ReadLine(), out quantity))
            {
                Console.WriteLine("Ошибка ввода! Введите цифровое значение");
            }
            int[] massive = new int[quantity];
            Console.WriteLine("Ваш массив");
            for (int i = 0; i < quantity; i++)
            {
                Random rnd = new Random();
                int alement = rnd.Next(0, 100);
                massive[i] = alement;
                Console.Write(massive[i] + " ");
            }
            Sorting(massive);
            Exit(massive);
        }

        private static void Choise1()
        {
            Console.WriteLine("Введите кол-во элементов массива, которые вы будете вводить:");
            int quantity;
            while (!int.TryParse(Console.ReadLine(), out quantity))
            {
                Console.WriteLine("Ошибка ввода! Введите цифровое значение");
            }
            int[] massive = new int[quantity];
            Console.WriteLine("Вводите элементы для массива:");
            for (int i = 0; i < quantity; i++)
            {
                massive[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sorting(massive);
            Exit(massive);
        }
    }
}
