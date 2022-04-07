using System;

namespace microtasks2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            Console.WriteLine("Кол-во сек: ");
            int time = int.Parse(Console.ReadLine());
            int kol_vo;

            if (time == 12)
            {
                kol_vo = time * 25;
            }
            else if (time == 7)
            {
                kol_vo = time * 35;
            }
            else
            {
                kol_vo = time * 12;
            }
            Console.WriteLine("Кол-во колебаний: ");
            Console.WriteLine(kol_vo);

            //Задача 2 

            Console.WriteLine("До сортировки");

            int[] mass = {7, 5, 2, 3, 9, 6 };
            
            for(int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }

            BubbleSort(mass);
            
            Console.WriteLine("После сортировки");
            
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }


        }
        static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
    }
}
