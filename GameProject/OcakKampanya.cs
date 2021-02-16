using System;

namespace GameProject
{
    class OcakKampanya : IKampanyaManager
    {
        public void Kampanya()
        {
            Console.WriteLine("Ocak kampanyası uygulanmıştır.");
        }

        public void KampanyaGuncelle()
        {
            Console.WriteLine("Ocak kampanyası güncellenmiştir.");
        }

        public void KampanyaSil()
        {
            Console.WriteLine("Ocak kampanyası silinmiştir.");
        }
    }

}
