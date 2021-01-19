using System;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int stok = 20;      // Stokta en başta 20 adet ürün alındığını varsayalım.
            int adet;           // Üründen ne kadar sipariş verildiğini adet değişkeninde tutuyor.


            // Stokda ne kadar ürün olduğunu ekrana yazan komut satırı
            Console.WriteLine("Urunumuzden şu an stokta " + stok + " urun kalmıştır.");


            // *******************************************************************************************************************
            // Müşteri üründen sipariş verdiğinde yapılacak işlemi gösterir metoda gider.
            // ref ve out kullanıldığı metotda değişen değerler geriye değer döndürmese bile daha sonra kullanılabilirler.
            // İkiai de aynı amaçla kullanılır. Fakat kullanım şekilleri farklıdır.
            
            // out : referans olarak gönderilecek olan değişkenin tanımlanırken değer almasına gerek yoktur. 
            // Çünkü değer alsa bile metot içinde elde edilen deüğer kullanılır. 

            // ref:  refrerans olarak gönderilecek olan değişkenin tanımlanırken değer verilmesi zorunludur.

            // *************************************************************************************************************************************
                      
            StokAzalt(out adet,ref stok);


            // adet out olarak gönderildiğinden dönüş olmadığı ve baştan tanımlanmadığı halde metot yolu ile kullanıcıdan alınan değer console yazdırıldı.
            // stok ref olarak gönderildiğinden dönüş olmadığı halde metor yolu ile hesaplanan stok ekrana yazdırıldı.
            Console.WriteLine(adet+" adet ürün alındı... ");
            Console.WriteLine("Urunumuzden şu an stokta " + stok + " urun kalmıştır.");

        }

            // StokAzalt metodu ile out ve ref olarak gönderilen parametreler ile işlem yapılıyor.
            // Kullanıcıdan adet bilgisi alınıyor ve stok azaltma işlemi yapılıyor.
       
        static void StokAzalt(out int adet,ref int stok) 
        {
            Console.Write("Kaç adet ürün alacaksınız : ");
            adet = Convert.ToInt32(Console.ReadLine());
            stok = stok - adet;
        }


    }
}
