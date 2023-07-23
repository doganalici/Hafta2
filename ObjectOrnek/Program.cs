using System;

namespace ObjectOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 1;
            byte b = 2;
            int c = a + b;

            //değişken float ise sonuna büyük yada küçük harf ile f yazılması gerekmektedir. yoksa hata verir.
            float x = 2.3f;
            float y = 33.44f;
            float z = x + y;

            #region boxing: kutulama
            /*
            //boxing yapıldı (kutulama yapıldı)
            //bir türü object olan büyük bir tür içine atılıyorsa boxing kutulama işlemi denir
            object obj1 = 12;
            object obj2 = 2.34;
            object obj3 = "Adem";
            object obj4 = false;
            object obj5 = 'A';

            object deger1 = 12;
            object deger2 = 23;
            object sonuc = (int)deger1 + (int)deger2; // önce int dönüşümü yaprak unboxing yapıyoruz ve topluyoruz. sonuç int oluyor  
                                                      // ve bunu boxing yapıyoruz yani object yapıyoruz
            int sonuc3 = (int)deger1 + (int)deger2;   // sadece int dönüşümü yaparak unboxing işlemi yaptık
            //() casting işlemi : (int), (string)
            // object sonuc2 = deger1 + deger2;

            string adi = "Adem";
            string soyadi = " AKKUŞ";
            // + operatötü : iki stringi birleştirir. Buna concatanation denir
            object adsoyad = adi + soyadi;  //boxing işlemi var
            Console.WriteLine(adsoyad);

            object fakulte = " Mühendislik";
            object bolum = "Bilgisayar";
            string meslek = (string)bolum + (string)fakulte; //unboxing  = onbecti alıp stringe dönüştürdük
            Console.WriteLine(meslek);
            */
            #endregion

            object obj = 12;
            Console.WriteLine("obj tipi : "+obj.GetType());  //sistem kütüphanesini verdi
            Console.WriteLine("obj tipi : "+obj.GetType().Name);
            Console.WriteLine("obj tipi : "+obj.GetType().BaseType);
            Console.WriteLine("obj tipi : "+obj.GetType().Assembly);
            Console.WriteLine("obj tipi : "+obj.GetType().Attributes);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            
            object obj1 = "Adem";
            Console.WriteLine("obj1 tipi : "+obj1.GetType());  //sistem kütüphanesini verdi
            Console.WriteLine("obj1 tipi : "+obj1.GetType().Name);
            Console.WriteLine("obj1 tipi : "+obj1.GetType().BaseType);
            Console.WriteLine("obj1 tipi : "+obj1.GetType().Assembly);
            Console.WriteLine("obj1 tipi : "+obj1.GetType().Attributes);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");

            object obj2 = 3.4f;
            Console.WriteLine("obj2 tipi : "+obj2.GetType());  //sistem kütüphanesini verdi
            Console.WriteLine("obj2 tipi : "+obj2.GetType().Name);
            Console.WriteLine("obj2 tipi : "+obj2.GetType().BaseType);
            Console.WriteLine("obj2 tipi : "+obj2.GetType().Assembly);
            Console.WriteLine("obj2 tipi : "+obj2.GetType().Attributes);
            
            Console.ReadKey();
        }
    }
}
