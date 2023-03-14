using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Regy Renanda Rahman 1302213117 SE-45-03

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
            //commit terakhir
            Console.WriteLine("===============================");
            PosisiKarakterGame game = new PosisiKarakterGame();
            game.Bermain();
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

    public class PosisiKarakterGame
    {
        enum State
        {
            Berdiri,
            Terbang,
            Jongkok,
            Tengkurap
        }
        public void Bermain()
        {
            Console.WriteLine("Input: TombolS | TombolW | TombolX");
            State state = State.Berdiri;
            string[] kondisi = { "Berdiri", "Terbang", "Jongkok", "Tengkurap" };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Status karakter : " + kondisi[(int)state]);
                Console.Write("Tekan : ");
                string tombol = Console.ReadLine();
                if (tombol == "TombolS")
                {
                    Console.WriteLine("Tombol arah bawah ditekan");
                    if (state == State.Berdiri)
                    {
                        state = State.Jongkok;
                    } else if (state == State.Terbang)
                    {
                        state = State.Berdiri;
                    } else if (state == State.Jongkok)
                    {
                        state = State.Tengkurap;
                    }
                } else if (tombol == "TombolW")
                {
                    Console.WriteLine("Tombol arah atas ditekan");
                    if (state == State.Berdiri)
                    {
                        state = State.Terbang;
                    } else if (state == State.Jongkok)
                    {
                        state = State.Berdiri;
                    } else if (state == State.Tengkurap)
                    {
                        state = State.Jongkok;
                    }
                } else if (tombol == "TombolX" && state == State.Terbang)
                {
                    state = State.Jongkok;
                }
            }
            Console.WriteLine("Status karakter : " + kondisi[(int)state]);
        }
    }
}
