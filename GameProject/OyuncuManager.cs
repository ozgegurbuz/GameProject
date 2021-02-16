using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OyuncuManager : Oyuncu
    {
        public void Add(Oyuncu oyuncu)
        {

        }

        public void Delete(Oyuncu oyuncu)
        {
            GC.SuppressFinalize(oyuncu);
        }

        public void Update(Oyuncu oyuncu)
        {

        }
    }
}
