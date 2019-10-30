using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamgiacdeu
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, A, hangtg, b;
            Console.Write("Nhap hang: ");
            hangtg = Convert.ToInt32(Console.ReadLine());
            A = hangtg + 4 - 1;
            for (i = 1; i <= hangtg; i++)
            {
                for (b = A; b >= 1; b--)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.Write("\n");
                A--;
            }

            Console.ReadKey();
        }
    }
}
