using System;
using System.Collections.Generic;

namespace tpmodul4_1302204106
{
    // Kelas untuk mendapatkan kode pos berdasarkan nama kelurahan
    class KodePos
    {
        private static Dictionary<string, string> _kodePosTable = new Dictionary<string, string>
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
            return _kodePosTable.ContainsKey(kelurahan) ? _kodePosTable[kelurahan] : "Kode Pos tidak ditemukan";
        }
    }

    // Kelas untuk pintu otomatis (DoorMachine) dengan state "Terkunci" dan "Terbuka"
    class DoorMachine
    {
        private enum State { Terkunci, Terbuka }
        private State _currentState;

        public DoorMachine()
        {
            _currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void KunciPintu()
        {
            if (_currentState == State.Terbuka)
            {
                _currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
        }

        public void BukaPintu()
        {
            if (_currentState == State.Terkunci)
            {
                _currentState = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka");
            }
        }
    }

    // Program utama
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan nama kelurahan: ");
            string kelurahan = Console.ReadLine();
            string kodePos = KodePos.GetKodePos(kelurahan);
            Console.WriteLine($"Kode pos {kelurahan}: {kodePos}");

            // Inisialisasi dan pengoperasian pintu otomatis
            DoorMachine pintu = new DoorMachine();
            pintu.BukaPintu();
            pintu.KunciPintu();
        }
    }
}