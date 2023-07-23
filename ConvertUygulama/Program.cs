using System;

namespace ConvertUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            //değişkenleri tanımlama
            string adSoyad,meslek;
            byte yas;
            double maas;
            bool medeniDurum;
            char cinsiyet;

            //değişkenlere değer atama
            Console.Write("Adınızı ve Soyadınızı Giriniz : ");
            adSoyad = Console.ReadLine();

            Console.Write("Mesleğinizi Giriniz : ");
            meslek = Console.ReadLine();


            Console.Write("Yaşınızı Giriniz : ");
            yas = Convert.ToByte(Console.ReadLine());

            Console.Write("Maaşınızı Giriniz : ");
            maas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Medeni Durumunuz (true ya da false) : ");
            medeniDurum = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Cinsiyetiniz (E ya da K) : ");
            cinsiyet = Convert.ToChar(Console.Read());

            //Console.ForegroundColor : yazı rengi değiştirmek için kullanılır
            //Console.BackgroundColor : konsol arka plan rengi değiştirmek için kullanılır

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n------KİŞİ BİLGİLERİ------\n");
            Console.WriteLine("Adı Soyadı : "+adSoyad+
                              "\nMesleği : "+meslek+
                              "\nYaşı : "+yas+
                              "\nMaaşı : "+maas+
                              "\nMedeni Durumu : "+medeniDurum+
                              "\nCinsiyeti : "+cinsiyet);


            Console.ReadKey();
        }
    }
}
