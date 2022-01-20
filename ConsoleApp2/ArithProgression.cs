using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ArithProgression
    {
        int firstnum; // 1-й член прогрессии
        int d;  // разность прогрессии
        int num;
        int max; //длина прогрессии
        int a;

        public int Firstnum { get { return firstnum; } set { firstnum = value; } }
        public int D { get { return d; } set { d = value; } }
        public int Num { get { return num; } set { num = value; } }

        public ArithProgression(int firstnum, int d, int num)
        {
            Firstnum = firstnum;
            D = d;
            max = num;
            Num = 1; //начало отсчета
            a = firstnum;
        }

        public void setStart(int firstnum)
        {
            Firstnum = firstnum;
            Console.WriteLine();

        }
        public int getNext() // a(n) = a1 + (n-1)*d
        {
            Console.Write("Арифметическая прогрессия -: {0},", firstnum);
            for (int i = num; i < max; i++)
            {
                a += d;
                if (i == max - 1)
                {
                    Console.Write("{0}", a);
                }
                else
                {
                    Console.Write("{0},", a);

                }
            }
            return 0;
        }
        public void reset()
        {
            Console.WriteLine("Сброс прогрессии.");

        }
    }

    class Geomrogression
    {
        int firstnum; // 1-й член прогрессии
        int q;  // знаменатель прогрессии
        int num;
        int max; //длина прогрессии
        int a;

        public int Firstnum { get { return firstnum; } set { firstnum = value; } }
        public int Q { get { return q; } set { q = value; } }
        public int Num { get { return num; } set { num = value; } }

        public Geomrogression(int firstnum, int q, int num)
        {
            Firstnum = firstnum;
            Q = q;
            max = num;
            Num = 1; //начало отсчета
            a = firstnum;
        }

        public void setStart(int firstnum)
        {
            Firstnum = firstnum;
            Console.WriteLine();

        }
        public int getNext() // a(n) = a1 + (n-1)*d
        {
            Console.Write("Геометрическая прогрессия -: {0},", firstnum);
            for (int i = num; i < max; i++)
            {
                a *= q;
                if (i == max - 1)
                {
                    Console.Write("{0}", a);
                }
                else
                {
                    Console.Write("{0},", a);
                }
            }
            return 0;
        }
        public void reset()
        {
            Console.WriteLine("Сброс прогрессии.");

        }
    }
    interface ISeries
    {
        void setStart(int x);     // устанавливает начальное значение
        int getNext();           // возвращает следующее число ряда
        void reset();           //  выполняет сброс к начальному значению
    }
}

