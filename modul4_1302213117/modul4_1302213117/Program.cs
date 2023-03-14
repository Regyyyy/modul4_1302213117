using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302213117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //commit kedua
            KodeBuah Buah = new KodeBuah();
            Console.WriteLine("Buah Kurma");
            Console.WriteLine("Kode Buah: " + Buah.getKodeBuah(KodeBuah.buah.Kurma));
        }
    }

    public class KodeBuah
    {
        public enum buah { Apel, Aprikot, Alpukat, Pisang, Paprika, 
            Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, 
            Semangka }

        public String getKodeBuah(buah Buah)
        {
            String[] kodeBuah = {"A00", "B00", "C00", "D00", "E00",
            "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00",
            "O00"};
            return kodeBuah[(int)Buah];
        }
    }
}
