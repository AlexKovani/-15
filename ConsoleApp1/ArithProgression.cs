using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
            Num = 1;
            a = firstnum + (max - 1) * d;
        }

        //public void setStart(int firstnum)
        // {
        //     Firstnum = firstnum;
        //     Console.WriteLine();

        // }
        public int getNext() // a(n) = a1 + (n-1)*d
        {
            Console.Write("Арифметическая прогрессия -: ");
            for (int i = firstnum; i <= a; i += d)
            {
                if (i == a)
                {
                    Console.Write("{0}", i);
                }
                else
                {
                    Console.Write("{0},", i);
                }

            }
            return 0;
        }
        public void reset()
        {
            Console.Write("Сброс. Начальное значение = ");
            Console.Write(firstnum);

        }

    }
    class Geomrogression
    {
        int firstnum; // 1-й член прогрессии
        int d;  // разность прогрессии
        int num;
        int max; //длина прогрессии
        double a;

        public int Firstnum { get { return firstnum; } set { firstnum = value; } }
        public int D { get { return d; } set { d = value; } }
        public int Num { get { return num; } set { num = value; } }

        public Geomrogression(int firstnum, int d, int num)
        {
            Firstnum = firstnum;
            D = d;
            max = num;
            Num = 1;
            a = firstnum * Math.Pow(d,(num-1));
        }

        //public void setStart(int firstnum)
        // {
        //     Firstnum = firstnum;
        //     Console.WriteLine();

        // }
        public int getNext() // a(n) = a1 + (n-1)*d
        {
            Console.Write("Геометрическая прогрессия -: ");
            for (int i = firstnum; i <= a; i *= d)
            {
                if (i == a)
                {
                    Console.Write("{0}", i);
                }
                else
                {
                    Console.Write("{0},", i);
                }

            }
            return 0;
        }
        public void reset()
        {
            Console.Write("Сброс. Начальное значение = ");
            Console.Write(firstnum);

        }
    }
    interface ISeries
    {
        //void setStart(int x);   // устанавливает начальное значение
        int getNext();           // возвращает следующее число ряда
        void reset();           //  выполняет сброс к начальному значению
    }
}
