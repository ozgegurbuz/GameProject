using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SatisManager
    {
        public void SatisYap(List<IKampanyaManager> kampanyaManagers, Oyuncu oyuncu, List<OyunManager> oyunManagers)
        {
            foreach (var KampanyaAd in kampanyaManagers)
            {
                KampanyaAd.Kampanya();
            }

            foreach (var oyun in oyunManagers)
            {
                oyun.Oyun();
            }

        }
        public void DogrulamaYap(List<IDogrulamaManager> dogrulamalar)
        {
            foreach (var dogrulamaAd in dogrulamalar)
            {
                dogrulamaAd.Dogrula();
            }
        }

    }
}
