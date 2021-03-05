using System;

namespace Sortirovka
{
    class Program
    {
        static int[] sortirovka(int[] mas)
        {
            int zamena;
            for (int j = 0; j < mas.Length; j++)
            {
                for (int l = j + 1; l < mas.Length; l++)
                {
                    if (mas[j] > mas[l])
                    {
                        zamena = mas[j];
                        mas[j] = mas[l];
                        mas[l] = zamena;
                    }
                }
            }
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
            int nastroika_vvoda = Convert.ToInt32(Console.ReadLine());
            if (nastroika_vvoda == 1)
            {
                Console.WriteLine("Введите кол-во элементов массива, которые вы будете вводить:");
                int kolichestvo = Convert.ToInt32(Console.ReadLine());
                int[] massive = new int[kolichestvo];
                Console.WriteLine("Вводите элементы для массива:");
                for (int i = 0; i < kolichestvo; i++)
                {
                    massive[i] = Convert.ToInt32(Console.ReadLine());
                }
                sortirovka(massive);
                /*for (int o = 0; o < kolichestvo; o++)
                {
                    Console.Write(massive[o] + " ");
                }*/
            }
            else if (nastroika_vvoda == 2)
            {
                Console.WriteLine("Введите кол-во элементов массива:");
                int kolichestvo = Convert.ToInt32(Console.ReadLine());
                int[] massive = new int[kolichestvo];
                Console.WriteLine("Ваш массив");
                for (int i = 0; i < kolichestvo; i++)
                {
                    Random rnd = new Random();
                    int alement = rnd.Next(0, 100);
                    massive[i] = alement;
                    Console.Write(massive[i] + " ");
                }
                Console.WriteLine(" ");
                Console.Write("Отсортированный массив");
                Console.WriteLine(" ");
                sortirovka(massive);
                /*for (int o = 0; o < kolichestvo; o++)
                {
                    Console.Write(massive[o] + " ");
                }*/
            }
        }
    }
}
