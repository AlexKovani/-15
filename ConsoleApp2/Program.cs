using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите начальное значение: ");
                int firstnum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите разность прогрессии: ");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите длину прогрессии: ");
                int num = Convert.ToInt32(Console.ReadLine());
                ArithProgression A_progress = new ArithProgression(firstnum, d, num);
                //progress.setStart(firstnum);
                A_progress.getNext();
                Console.WriteLine();
                A_progress.reset();
                Console.WriteLine();
                Geomrogression G_progress = new Geomrogression(firstnum, d, num);
                //progress.setStart(firstnum);
                G_progress.getNext();
                Console.WriteLine();
                G_progress.reset();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
