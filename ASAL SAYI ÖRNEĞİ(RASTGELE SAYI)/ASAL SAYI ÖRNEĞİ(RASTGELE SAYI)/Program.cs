using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASAL_SAYI_ÖRNEĞİ_RASTGELE_SAYI_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İLK 50 ASAL SAYI");
            Console.WriteLine("*******************");
            Console.WriteLine();
            int son = 0;
            int sayi = 0;
            int kontrol = 0;
            int sütun = 0;
            while (true)
            {
                if (son == 50)
                {
                    break;
                }
                kontrol = 0;
                for (int j = 2; j < sayi; j++)
                {
                    if (sayi % j == 0)
                    {
                        kontrol++;
                    }
                }
                if (kontrol == 0)
                {
                    sütun++;
                    Console.Write(sayi + " ");
                    if(sütun%10==0)
                    {
                        Console.WriteLine();
                    }
                    son++;
                }
                sayi++;
            }
            
            Console.ReadLine();
            
        }
    }
}
