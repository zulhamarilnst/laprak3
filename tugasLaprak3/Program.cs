using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugasLaprak3
{
    public class Mobil
    {
        public string warna { get; set; }
        public int jumlah_pintu { get; set; }
        public string merek { get; set; }
        public string model { get; set; }
        public int tahun_keluaran { get; set; }
        public string kecepatan { get; set; }
        public string suara { get; set; }
        
        public void gas()
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("Mobil " + model + " berjalan dengan kecepatan " + kecepatan);
        }

        public void klakson()
        {
            Console.WriteLine("suara kelakson : " + suara);
        }

        public void tampilkan_info()
        {

            Console.WriteLine("\"Mobil saya berwarna " + warna + ", merek " + merek + " model " + model + " keluaran tahun " + tahun_keluaran + " dengan jumlah pintu sebanyak " + jumlah_pintu + "\"");
            Console.WriteLine("==========================================================");
        }

    }
}
