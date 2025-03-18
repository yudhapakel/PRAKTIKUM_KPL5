using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterNGeneric
{
     class PemrosesanData
    {
        public static void DapatkanNilaiTerbesar<T>(T Data1, T Data2, T Data3) where T : IComparable
        {
            dynamic Max = Data1;
            dynamic angka2 = (dynamic)Data2;
            dynamic angka3 = (dynamic)Data3;

            if (Max < angka2)
            {
                Max = Data2;
            }

            if (Max < angka3)
            {
                Max = Data3;
            }

            

            Console.WriteLine($"Nilai Terbesar Adalah: " + Max);
        }
    }

    class Program
    {
        static void Main()
        {
            int nim1 = 10;
            int nim2 = 30;
            int nim3 = 22;

            PemrosesanData.DapatkanNilaiTerbesar( nim1, nim2, nim3 );
        }
    }
}
