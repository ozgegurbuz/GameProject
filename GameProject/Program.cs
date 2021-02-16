using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            OyuncuManager oyuncu1 = new OyuncuManager();
            oyuncu1.Id = 1;
            oyuncu1.TcNo = "12345678912";
            oyuncu1.Adi = "Özge";
            oyuncu1.Soyadi = "Gürbüz";
            oyuncu1.DogumYili = "1999";

            oyuncu1.Add(oyuncu1);
            oyuncu1.Update(oyuncu1);
            oyuncu1.Delete(oyuncu1);

            IDogrulamaManager eDevletDogrulama = new EDevletDogrulama();
            List<IDogrulamaManager> dogrulamalar = new List<IDogrulamaManager> { eDevletDogrulama };

            IKampanyaManager yilbasiKampanyasi = new YilbasiKampanya();
            IKampanyaManager ocakKampanyasi = new OcakKampanya();
            List<IKampanyaManager> kampanyalar = new List<IKampanyaManager> { yilbasiKampanyasi, ocakKampanyasi };

            OyunManager ucakSimulasyonu = new UcakSimulasyon();
            List<OyunManager> oyunlar = new List<OyunManager> { ucakSimulasyonu };



            SatisManager satisManager = new SatisManager();
            satisManager.SatisYap(kampanyalar, oyuncu1, oyunlar);
            satisManager.DogrulamaYap(dogrulamalar);




        }
    }
}
