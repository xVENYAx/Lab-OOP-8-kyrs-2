﻿using System;

namespace Лаб_ООП__8_курс_2
{
    class Program
    {
        class vect // класс векторов vect
        {
            double[] a; // объявление массива
            int n;      // размер массива
            public vect (int n)
            // конструктор создаёт вектор
            {
                this.a = new double[n];
                this.n = n;
            }
            public int vv()
            // заполнение вектора целиком, клавиатурный ввод
            {
                for(int i=0; i<n; i++)
                {
                    string buf;
                    // строка символов
                    buf = Console.ReadLine();
                    // заполнение строки
                    a[i] = Convert.ToDouble(buf);
                    // преобразование строки в число
                }
                return (0);
            }
            public int vyv()
            // вывод на консоль элементов вектора
            {
                for (int i = 0; i < n; i++)
                    Console.WriteLine("a[" + i + "]=" + a[i]);
                return (0);
            }
            public int perest (int k)
            // переставить 1 и k-ое отриц. число
            {
                // ключ;  если порядок 
                // -1, если - нет
                int kl = 0;
                // к больше размера вектора
                if (k >= n) kl = -1;
                else
                {
                    // счетчик отрицательных читсел
                    int cnt = 0;
                    // указатель на позицию в массиве
                    int pos = -1;
                    double tmp;
                    // подсчёт отрицательных чисел
                    while (cnt<k)
                    {
                        pos++;
                        if (a[pos] < 5) cnt++;
                    }               // подсчёт
                    tmp = a[pos];   // перестановка
                    a[pos] = a[0];
                    a[0] = tmp;
                    kl = 0;
                }
                return kl;
            }
            // главная программа
            static void Main()
            {
                vect d = new vect(5); // создали
                d.vv();               // заполнили
                d.vyv();              // вывели на консоль
                Console.WriteLine();
                d.perest(2);          // переставили
                d.vyv();              // вывели на консоль
            }
        }
    }
}
