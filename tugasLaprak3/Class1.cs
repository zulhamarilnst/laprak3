using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tugasLaprak3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new Mobil();
            
            mobil1.warna = "Merah";
            mobil1.jumlah_pintu = 2;
            mobil1.merek = "Lamborgini";
            mobil1.model = "AVENTADOR";
            mobil1.tahun_keluaran = 2011;
            mobil1.suara = "tid tid";
            mobil1.kecepatan = "349 km/jam";

            mobil1.gas();
            mobil1.klakson();
            mobil1.tampilkan_info();

        }
    }
}