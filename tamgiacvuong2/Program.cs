using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamgiacvuong2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, hangtg;
            Console.Write("Nhap hang: ");
            hangtg = Convert.ToInt32(Console.ReadLine());
            for (i = hangtg -1; i >= 0; i--)
            {
                for (j = hangtg; j >= hangtg - i; j--)
                    Console.Write("*");
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
