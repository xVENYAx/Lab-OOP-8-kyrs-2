using System;

namespace завдання__7
{
    class Program
    {
        class vect // класс векторов vect
        {
            int[] a; // объявление массива
            int n;      // размер массива
            Random rnd = new Random();
            public vect(int n)
            // конструктор создаёт вектор
            {
                this.a = new int[n];
                this.n = n;
            }
            public int vv()
            // заполнение вектора целиком, клавиатурный ввод
            {
                for (int i = 0; i < n; i++)
                {
                    int nt = rnd.Next(-30, 30);
                    // заполнение строки
                    a[i] = Convert.ToInt32(nt);
                    // преобразование строки в число
                }
                return (0);
            }
            public int vyv()
            // вывод на консоль элементов вектора
            {
                for (int i = 0; i < n; i++)
                    Console.WriteLine("a[" + i + "]=" + a[i]);
                Console.WriteLine("-----------------------");
                return (0);
            }

            public int vkv()
            {
                int m = 0;
                int k = 0;
                int j;
                for (int i = 0; i < n; i++)
                {
                    if (a[i] < m)
                    {
                        k++;
                        if (k == 2)
                        {
                            j = a[i];
                            a[i] = a[0];
                            a[0] = j;
                        }
                    }
                }
                return (0);
            }
            // главная программа
            static void Main()
            {
                vect d = new vect(6); // создали
                d.vv();               // заполнили
                d.vyv();              // вывели на консоль
                Console.WriteLine();
                d.vkv();          // переставили
                d.vyv();              // вывели на консоль
                Console.WriteLine();
                
                vect d1 = new vect(10); // создали
                d1.vv();               // заполнили
                d1.vyv();              // вывели на консоль
                Console.WriteLine();
                d1.vkv();          // переставили
                d1.vyv();              // вывели на консоль
            }
        }
    }
}
