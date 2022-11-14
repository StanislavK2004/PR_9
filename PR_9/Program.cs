using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №9";
            Console.WriteLine("Здравствуйте!");

            const int m = 15; // задание размерности массива
            int[] A = new int[m]; // объявление одномерного массива
            int i = 0;
            bool err; // err - флаг обнаружения ошибки при вводе элементов массива

            while (i < m)
            {
                err = false;
                Console.WriteLine("Введите" + i + "элемент массива");
                try
                {
                    A[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e) // обработка исключения связанного с фоматом
                {
                    err = true;
                    Console.WriteLine("Возникла ошибка:" + e.Message);
                }
                if (!err) i++;
            }
            for(i=0;i<m; i++)
            {
               R
            }
                
    }
}
