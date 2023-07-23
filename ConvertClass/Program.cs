using System;

namespace ConvertClass
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Read()
            //stream : akışkan veri 
            //input stream : giriş verisi
            //kolsolda ekrandan veri okumak için iki metot kullanılır
            //Console.Read() : satırdan tek bir karakter okur ve geriye int karakter kodunu verir
            //int okuma = Console.Read();
            //Console.WriteLine(okuma);
            //Console.WriteLine((char)okuma);


            //Console.ReadLine(): satırın tamamını okur
            //geriye bir string döndürür
            //o zaman okunan değer STRING olduğundan matematiksel ve
            //mantıksal işlemler YAPILAMAZ!!
            //Tür dönüşümü yapmak zorundayız
            #endregion

            #region Write WriteLine
            //string okunan;
            //okunan = Console.ReadLine();
            //Console.WriteLine(okunan);

            ////Console.Write(): stream satıya yazar ve imleç satır sonunda bekler
            ////sonra gelen stream aynı satırdan devam eder
            //Console.Write(okunan);
            //Console.Write(" Alıcı");
            ////Consone.WriteLine(): satıra yazar ve sonra imleç bir alt satıra iner
            ////Console.WriteLine(): eğer parantez içerisine bir şey yazılmazsa boş bir satır ekler
            //Console.WriteLine();
            //Console.WriteLine("\n");
            //Console.WriteLine(okunan); 
            #endregion

            //Convert bütün türler arasında dönüşüm yapabilir
            //metotlar To önekiyle başlar

            int sayi1,sayi2,toplam;
            //Console.WriteLine("Birinci sayıyı giriniz : ");
            Console.Write("Birinci sayıyı giriniz : ");
            string str = Console.ReadLine();
            sayi1 = Convert.ToInt32(str);
            //Console.WriteLine(sayi1);
            
            Console.Write("\nİkinci sayıyı giriniz : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(sayi2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("\n"+sayi1+" + "+sayi2+" = "+toplam);

            //sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

        }
    }
}
