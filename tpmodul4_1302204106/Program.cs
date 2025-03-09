using System;
using System.Collections.Generic;

namespace tpmodul4_1302204106
{
    // Nomor 3
    class KodePos
    {
        private static Dictionary<string, string> kodePosTable = new Dictionary<string, string>
        {
            { "Batununggal", "40266" },
            { "Kujangsari", "40287" },
            { "Mengger", "40267" },
            { "Wates", "40256" },
            { "Cijaura", "40287" },
            { "Jatisari", "40286" },
            { "Margasari", "40286" },
            { "Sekejati", "40286" },
            { "Kebonwaru", "40272" },
            { "Maleer", "40274" },
            { "Samoja", "40273" }
        };

        public static string GetKodePos(string kelurahan)
        {
            return kodePosTable.ContainsKey(kelurahan) ? kodePosTable[kelurahan] : "Kode Pos tidak ditemukan";
        }
    }

    // Nomor 5
    class DoorMachine
    {
        private enum State { Terkunci, Terbuka }
        private State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void KunciPintu()
        {
            if (currentState == State.Terbuka)
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
        }

        public void BukaPintu()
        {
            if (currentState == State.Terkunci)
            {
                currentState = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Nomor 3
            Console.WriteLine("Masukkan nama kelurahan: ");
            string kelurahan = Console.ReadLine();
            string kodePos = KodePos.GetKodePos(kelurahan);
            Console.WriteLine($"Kode pos {kelurahan}: {kodePos}");

            // Nomor 5
            DoorMachine pintu = new DoorMachine();
            pintu.BukaPintu();
            pintu.KunciPintu();
        }
    }
}
