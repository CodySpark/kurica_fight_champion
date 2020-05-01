using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;

namespace Beregovoi
{
    class Task
    {
        static void Main(string[] args)
        {
            #region
            /* // откуда
             int coLumn = Convert.ToInt32(Console.ReadLine());  // столбец
             int roW = Convert.ToInt32(Console.ReadLine());     // ряд
             //куда
             int coLumn1 = Convert.ToInt32(Console.ReadLine());  // столбец
             int roW1 = Convert.ToInt32(Console.ReadLine());     // ряд

             if (((coLumn == coLumn1) || (roW == roW1))  ||  ((coLumn == ro) || ()))
             {
                 int x = (coLumn - coLumn1);
                 Console.WriteLine(x);
                 int y = (roW - roW1);
                 Console.WriteLine(y);
             }
             else
             {
                 Console.WriteLine("no");
             }
             */

            #endregion

            #region
            //Task1();

            //Task2();

            // Task3();

            //Task4();

            //Task5();

            //Task6();

            //Task7();

            //Task8();


            //Task9();

            //Task10();

            //Task11();

            Task12();

            #endregion

          
        }


        /// <summary>
        /// Посчитать сумму элементов массива
        /// </summary>
        public static void Task3()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = a[i] + sum;

            }
            Console.WriteLine(sum);
        }

        /// <summary>
        /// Заполнить массив по возрастанию от 1 до 100
        /// </summary>
        public static void Task4()
        {
            int[] arr = new int[100];
            for (int i = 1; i <= arr.Length; i++)
            {
                arr[i - 1] = i;
            }
            Console.WriteLine($"\n{arr.Length}");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        /// <summary>
        /// Двумерный массив скопировать в одномерный
        /// </summary>
        public static void Task11()
        {
            int[,] m = new int[,] 
            { 
                { 11, 22, 31 }, 
                { 4, 53, 6 }, 
                { 7, 81, 90 } 
            };

            int[] arr =  new int [m.Length];
            int k = 0;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++) 
                {
                    arr[k] = m[i, j];
                    k++;
                    
                }
                Console.WriteLine(" ");
            }
        }

        /// <summary>
        /// Найти минимальный элемент массива
        /// </summary>
        public static void Task1()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int min = a[0];

            for (int i = 0; i < a.Length; i++) 
            {
                if (min > a[i])
                {
                    min = a[i];   
                } 
            }
            Console.WriteLine(min);
        }

        /// <summary>
        /// Найти два наибольших элемента массива
        /// </summary>
        public static void Task2()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int max1 = a[0];
            int max2 = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (max1 < a[i])
                {
                    max1 = a[i];
                }
            }
           
            for (int i = 0; i < a.Length; i++)
            {
                if (max1 == a[i])
                    continue;
                else if (max2 < a[i])
                {
                    max2 = a[i];    
                }
            }

            Console.WriteLine(max1);
            Console.WriteLine(max2);
        }

        /// <summary>
        /// Создать и заполнить массив случайными целыми числами
        /// </summary>
        public static void Task5()
        {
            //пример вызова генератора случайных чисел, он понадобится в данной задаче
            Random rnd = new Random();

            int[] arr = new int[34];
           
            for (int i = 0; i < 34; i++)
            {
                int r = rnd.Next(1, 10);//случайное число от 1 до 10
                arr[i] = r;
                Console.WriteLine(arr[i]);
            }

        }

        /// <summary>
        /// Проверить, что в массиве нет одинаковых чисел
        /// </summary>
        public static void Task6()
        {
            int[] a = new int[] { 54, 12, 13, 2, 1, 9, 15, 5, 6 };
            bool yn = false;
            

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        yn = true;
                        break;
                    }
                }
                if (yn)
                {
                    break;
                }
            }
            Console.WriteLine(yn);
        }

        /// <summary>
        /// Переставить элементы массива в обратном порядке используя вспомогательный массив
        /// </summary>
        public static void Task7()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[b.Length - i - 1] = a[i];
                
            }
        }

        /// <summary>
        /// Переставить элементы массива в обратном порядке НЕ используя вспомогательный массив
        /// </summary>
        public static void Task8()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };

            for (int i = 0; i < a.Length; i++)
            {
                a[a.Length -i ] = a[i];
            }
            foreach (int i in a) 
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Подсчитать сумму чисел в двухмерном массиве
        /// </summary>
        public static void Task9()
        {
            int[,] m = new int[,] 
            {
                { 11, 22, 31, 123, 234, 56 },
                { 4,  53,  6 , 345, 67, 78 },
                { 7,  81,  90 ,123, 56, 78 } 
            };
            int sum = 0;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(  m[i, j] + "+");
                    sum += m[i, j];
                    
                }
               
            }
            Console.WriteLine("=" + sum);
                
               
            
        }

        /// <summary>
        /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 9 и вывести на экран консоли
        /// </summary>
        public static void Task10()
        {
            
            Random rnd = new Random();
            int size = 10;

            int[,] m = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int r = rnd.Next(1,10);

                    m[i, j] = r;
                    Console.Write(m[i,j] + "  ");
                }
                Console.WriteLine();
            }
            
        }

        /// <summary>
        /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 99 и определить количество четных чисел в массиве
        /// </summary>
        public static void Task12()
        {
            //подсказка: для определения остатка от деления используется оператор %
            int[,] arr = new int [10,10]; 

           
            int ch = 0;
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int r = rnd.Next(1,99);

                    arr[i, j] = r;
                    Console.Write(arr[i,j] + " ");
                    if (arr[i,j] % 2 == 0)
                    {
                        ch++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Кол-во чётных чисел " + ch);
            
        }
    }
}