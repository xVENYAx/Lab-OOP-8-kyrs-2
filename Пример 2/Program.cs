using System;
// моё пространство имён
namespace Пример_2
{
    class myprog
    {
        static void Main()
        {
            // объявление матриц
            double[,] d = new double[3, 3];
            double[,] dt = new double[3, 3];
            double[,] ddt = new double[3, 3];
            // заполнение d с клавиатуры
            int i; int j; // строки, колонки
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                    d[i, j] = Convert.ToDouble(Console.ReadLine());
            }
            // траспонирование матрицы
            Transp(d, 3, dt);
            // умножение транпонированной матрицы dt на исходную d
            Mt_q_mult(dt, d, ddt, 3);
        }
        // транаонирование
        static void Transp(double[,] mtr, int p, double[,] mtrt)
        // double[,] mtr - так определяют матрицу в формальных параметрах
        {
            int i; int j;
            for(i=0; i < p; i++)
            {
                for (j = 0; j < p; j++)
                    mtrt[j, i] = mtr[i, j];
            }
        }
        // умножение квадратных матриц
        static void Mt_q_mult(double[,] m_a, double[,] m_b, double[,] m_r, int p)
        // m_r=m_a * m_b, int p размер матриц
        {
            int i; int j; int k; double mel;
            for(i=0;i<p;i++) // строки m_a
            {
                // столбцы m_b
                for(j=0;j<p;j++)
                {
                    mel = 0;
                    // столбцы m_a и строки m_b
                    for (k = 0; k < p; k++)
                        mel = m_a[i, k] * m_b[k, j];
                    m_r[i, j] = mel;
                }
            }
        }
    }
}
