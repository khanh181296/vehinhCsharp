using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehinhtron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ban kinh hinh tron r = ");
            if (!int.TryParse(Console.ReadLine(), out int r) || r <= 0)
            {
                Console.WriteLine("Ban kinh nhap vao khong hop le");
                return;
            }
            Console.Clear();
            double rin = r - 0.5;
            double rout = r + 0.5;
            for (int i = -r; i <= r; i++)
            {
                for (double j = -r; j <= r; j += 0.5)
                {
                    double f = i * i + j * j;
                    if (f >= rin * rin && f <= rout * rout)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
