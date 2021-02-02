using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    class BenimListe<Type>
    {
        // Type[] eleman=new Type[] { };
        Type[] oyunAdi;
        public BenimListe()
        {
            oyunAdi = new Type[0];
        }
        public void Add(Type type)
        {
            Type[] geciciDizi = oyunAdi;
            oyunAdi = new Type[oyunAdi.Length+1];
            for (int i = 0; i < geciciDizi.Length; i++)
            {
                oyunAdi[i] = geciciDizi[i];
            }
            oyunAdi[oyunAdi.Length - 1] = type;
        }
    }
}
