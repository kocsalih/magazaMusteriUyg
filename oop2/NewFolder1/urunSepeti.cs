using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2.NewFolder1
{
    class urunSepeti
    {
        public int sepetID { get; set; }
        public string urunAdi { get; set; }
        public int musteriID { get; set; }

        public List<urun> urunlerListesi { get; set; } = new List<urun>();

        public void dogumGunuHediyesiEkle()
        {
            urun hediye = new urun()
            {
                urunAdi = "gofret";
            urunID = 300;
            urunKatagori = urunKatagori.gıda
            };
        }

    }
}
