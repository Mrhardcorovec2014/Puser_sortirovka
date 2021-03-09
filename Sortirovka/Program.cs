using System;

namespace Sortirovka
{
    class Program
    {
        static int[] Sorting(int[] mas)
        {
            int replacement;
            for (int j = 0; j < mas.Length; j++)
            {
                for (int l = j + 1; l < mas.Length; l++)
                {
                    if (mas[j] > mas[l])
                    {
                        replacement = mas[j];
                        mas[j] = mas[l];
                        mas[l] = replacement;
                    }
                }
            }
            Console.WriteLine(" ");
            Console.Write("Отсортированный массив");
            Console.WriteLine(" ");
            for (int o = 0; o < mas.Length; o++)
            {
                Console.Write(mas[o] + " ");
            }
            return mas;
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
                int[] massive = Choise2();
                Sorting(massive);
            }
        }

        private static int[] Choise2()
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

            return massive;
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
                while (!int.TryParse(Console.ReadLine(), out massive[i]))
                {
                    Console.WriteLine("Ошибка ввода! Введите цифровое значение");
                }
            }
            Sorting(massive);
        }
    }
}
