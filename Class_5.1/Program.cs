using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            float [] array = new float[n];
            float sum = 0;
            float s = 0;
            Console.WriteLine("Введите семь любых чисел: ");
            for (int i = 0; i < n; i++)
            {
                /// Вводим 7 любых чисел
                array[i]= int.Parse (Console.ReadLine());
                sum += array[i]; ///накапливаем сумму
                s = sum / n;
            }
            Console.WriteLine();
            Console.Write("Среднее арифметическое элементов = {0:0.000} ", s);     
            Console.ReadKey();
        }
    }
}