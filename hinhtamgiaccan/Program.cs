using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hinhtamgiacvuong
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, hangtg;         
            Console.Write("Nhap hang: ");
            hangtg = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= hangtg; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            Console.ReadKey();

        }

    }
}
