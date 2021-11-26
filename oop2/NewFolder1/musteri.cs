using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2.NewFolder1
{
    class musteri
    {
        public int musteriId { get; set; }
        public string musteriAdi { get; set; }
        public string musteriSoyadi { get; set; }
        public DateTime dogumTarihi { get; set; }

        public cinsiyetler cinsiyeti { get; set; }


        #region

        public bool musterininDogumGunu()
        {
            bool kontrol = false;
            kontrol = (dogumTarihi.Day == DateTime.Now.Day && dogumTarihi.Month == DateTime.Now.Month) ? true : false;
            return kontrol;
        }

        public void musteriBilgileriYazdir()
        {
            Console.WriteLine($"Müşteri No: {musteriId}.{musteriAdi} {musteriSoyadi}");
        }















        #endregion
    }
}
