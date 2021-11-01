using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaleev.laba7
{
    class Sort
    { 
        /// <summary>
        /// Сравнение скорости сортировок
        /// </summary>
        /// <param name="t2"></param>
        /// <param name="t1"></param>
        internal static void Vs(double t1, double t2 ,ref string time)
        {
            if (t1 < t2)
            {
                time = ("Гном быстрее чем сортировка перемешиванием.");
            }
            else
            {
                if (t1 == t2)
                    time = ("Равное время сортировки.");
                else
                    time = ("сортировка перемешиванием быстрее чем Гном .");
            }
        }
        /// <summary>
        /// Сортировка перемешиванием
        /// </summary>
        /// <param name="mas"></param>
        /// <param name="t2"></param>
        /// <param name="n"></param>
        /// <param name="masout"></param>
        internal static void Mixing(int[] mas, ref double t2, int n, int[] masout)
        { 
            {
                DateTime StartTime2;
                StartTime2 = DateTime.Now;
                Console.WriteLine("  Сортировка перемешиванием : ");
                ShakerSort(mas, masout, n); 
                DateTime EndTime = DateTime.Now;
                Console.WriteLine();
                t2 = (EndTime - StartTime2).TotalMilliseconds;
            }
        }
        /// <summary>
        /// Сортировка гномиком
        /// </summary>
        /// <param name="mas"></param>
        /// <param name="t1"></param>
        /// <param name="n"></param>
        /// <param name="masout"></param>
        internal static void Gnom(int[] mas, ref double t1, int n, int[] masout)
        { 
            {
                DateTime StartTime1;
                StartTime1 = DateTime.Now; 
                Gnome_sort(mas, masout, n); 
                DateTime EndTime = DateTime.Now;
                Console.WriteLine();
                t1 = (EndTime - StartTime1).TotalMilliseconds;
            }
        }
        /// <summary>
        /// Создание случайного массива
        /// </summary>
        /// <param name="mas"></param>
        /// <param name="ran"></param>
        internal static void WriteMassRand(int[] mas, Random ran)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = ran.Next(0, 11); 
            }
        }
        /// <summary>
        /// Меняем элементы местами
        /// </summary>
        /// <param name="masout"></param>
        /// <param name="i"></param>
        internal static void Swap(int[] masout, int i)
        {
            int temp;
            temp = masout[i];
            masout[i] = masout[i - 1];
            masout[i - 1] = temp;
        }
        /// <summary>
        /// Сортировка перемешиванием
        /// </summary>
        /// <param name="mas"></param>
        /// <param name="masout"></param>
        /// <param name="n"></param>
        internal static void ShakerSort(int[] mas, int[] masout, int n)
        {
            Array.Copy(mas, 0, masout, 0, n);
            int Start = 1;
            int Left, Right, i;
            Left = Start;
            Right = n - 1;
            while (Left <= Right)
            {
                for (i = Right; i >= Left; i--)
                    if (masout[i - 1] > masout[i]) Swap(masout, i);
                Left++;
                for (i = Left; i <= Right; i++)
                    if (masout[i - 1] > masout[i]) Swap(masout, i);
                Right--;
            }
        }
        /// <summary>
        /// Соритровка гномиком
        /// </summary>
        /// <param name="mas"></param>
        /// <param name="masout"></param>
        /// <param name="n"></param>
        internal static void Gnome_sort(int[] mas, int[] masout, int n)
        {
            Array.Copy(mas, 0, masout, 0, n);
            int i = 1, j = 1;
            while (i < n)
            {
                if (masout[i - 1] <= masout[i])
                { i = j; j++; }
                else
                {
                    int t = masout[i];
                    masout[i] = masout[i - 1]; masout[i - 1] = t;
                    i--;
                    if (i == 0) { i = j; j++; }
                }
            }
        }
        
    }
}
