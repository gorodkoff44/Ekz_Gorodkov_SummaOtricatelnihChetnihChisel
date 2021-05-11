using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekz_Gorodkov_SummaOtricatelnihChetnihChisel
{
    class Program
    {
        /// <summary>
        /// Контрольная работа
        /// Задача №3: Найти сумму четных отрицательных элементов массива
        /// Автор: Городков Артём
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Задание: Найти сумму четных отрицательных элементов массива");
            Random rnd = new Random(); //Случайные числа
            Console.WriteLine("Введите длину массива");
            int n = int.Parse(Console.ReadLine());
            if (n < 1) //Проверка введенных данных
            {
                Console.WriteLine("Длина массива должна быть больше нуля!");
                return;
            }
            int[] mass = new int[n]; //основной массив
            int[] otr = new int[n]; //дополнительный массив для отрицательных чисел
            int[] chetn = new int[n]; //и для отрицательный четных
            int sum = 0; //сумма отрицательных четных чисел
            int c = rnd.Next(-100, 100); //первое случайное число диапазона -100 до 100
            //и два счетчика
            int z = 0;
            int k = 0;
            Console.WriteLine("Исходный массив:");
            Console.WriteLine();
            //заполнение и вывод в консоль основного массива
            for (int i = 0; i < n; i++)
            {
                mass[i] = c;
                c = rnd.Next(-10, 10);
                Console.Write($"{mass[i]} ");
            }
            //перебор основного массива и если число отрицательное то ввод в доп. массив
            for (int i = 0; i < n; i++)
            {
                if (mass[i] < 0)
                {
                    otr[z] = mass[i];
                    z++; //Счетчик кол-ва элементов массива otr
                }
            }
            Console.WriteLine();
            Console.WriteLine("Отрицательные числа массива:");
            Console.WriteLine();
            for (int i = 0; i < z; i++) //вывод массива отрицательных чисел
            {
                Console.Write($"{otr[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Отрицательные четные числа массива:");
            Console.WriteLine();
            for (int i = 0; i < z; i++) //перебор доп массива отриц. чисел и заполнение 3-го массива четными отриц. числами
            {
                if ((otr[i] % 2) == 0)
                {
                    chetn[k] = otr[i];
                    k++; //Счетчик кол-ва элементов массива chetn
                }
            }

            for (int i = 0; i < k; i++) //вывод массива с четными отрицательными числами
            {
                Console.Write($"{chetn[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < k; i++) //перебор массива четных отрицательных чисел
            {
                sum = sum + chetn[i]; //сумма элементов массива
            }
            Console.WriteLine($"Сумма четных отрицательных чисел равна {sum}");
            Console.ReadKey();
        }
    }
}
