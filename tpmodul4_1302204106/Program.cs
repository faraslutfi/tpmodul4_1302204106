﻿using System;
using System.Collections.Generic;

namespace tpmodul4_1302204106
{
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

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan nama kelurahan: ");
            string kelurahan = Console.ReadLine();
            string kodePos = KodePos.GetKodePos(kelurahan);
            Console.WriteLine($"Kode pos {kelurahan}: {kodePos}");
        }
    }
}
