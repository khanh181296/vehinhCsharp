using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hinhvuong
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 5;
            int B = 10;

            char kitu1 = '*';
            char kitu2 = '.';
            //char kitu3 = '?';
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                {
                  
                    if (i % (A - 1) == 0 || ((i % (A - 1) != 0) && (j % (B - 1) == 0)))
                    {
                        Console.Write(kitu1);
                    }
                    
                    else
                    {
                        Console.Write(kitu2);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
