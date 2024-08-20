using System;
namespace camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = " Kategori";
            int ogrenciSayisi =32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("arttı");
            }
            else if (dolarBugun < dolarDun)
            {
                Console.WriteLine("düştü");

            }
            else
            {
                Console.WriteLine("sabit");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine(" Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }




            Console.WriteLine(KategoriEtiketi);
          


        }
    }
}