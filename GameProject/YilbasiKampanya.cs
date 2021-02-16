using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class YilbasiKampanya : IKampanyaManager
    {
        public void Kampanya()
        {
            Console.WriteLine("Yılbaşı kampanyası uygulanmıştır.");
        }

        public void KampanyaGuncelle()
        {
            Console.WriteLine("Yılbaşı kampanyası güncellenmiştir.");
        }

        public void KampanyaSil()
        {
            Console.WriteLine("Yılbaşı kampanyası silinmiştir.");
        }
    }

}
