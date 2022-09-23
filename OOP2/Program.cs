using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "24689";
            musteri1.Id = 1;
            musteri1.Adi = "engin";
            musteri1.Soyadi = "demiroğ";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "13578";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1234648564";

            Musteri musteri3 = new GercekMusteri();// MUSTERİ CLASSI HEM GERCEKMUSTERİNİN HEM DE TÜZELMUSTERİNİN REFERANS NUMARASINI  TUTABİLİYOR.
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            
        }
    }
}
