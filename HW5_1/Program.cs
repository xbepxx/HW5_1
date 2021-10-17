using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольные 7 чисел");
            float S = 0;
            int[] t = new int[7];
            for (int i = 0; i < 7; i++)
            {
                t[i]=Convert.ToInt32(Console.ReadLine());
                S += t[i];
            }
            Console.WriteLine(S);
            Console.WriteLine("Среднее арифметическое введённых Вами значений равно {0}", S / 7);
            Console.ReadKey();
        }
    }
}
