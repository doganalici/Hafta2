using System;

namespace SayisalTurler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte deger1 = 24;
            //Ctrl+D : seçili alanı kopyalar
            //Ctrl+K+D : kodu hizalar
            //F5 : kodu tekrar derleyerek çalıştırır
            //Ctrl + F5 : kodu debug etmeden çalıştırır
            Console.WriteLine("byte minimum değer = " + byte.MinValue);
            Console.WriteLine("byte minimum değer = " + byte.MaxValue);
            Console.WriteLine("------------------------------------");

            Console.WriteLine("byte minimum değer = " + short.MinValue);
            Console.WriteLine("byte minimum değer = " + short.MaxValue);
            Console.WriteLine("------------------------------------");

            Console.WriteLine("byte minimum değer = " + int.MinValue);
            Console.WriteLine("byte minimum değer = " + int.MaxValue);
            Console.WriteLine("------------------------------------");

            Console.WriteLine("byte minimum değer = " + long.MinValue);
            Console.WriteLine("byte minimum değer = " + long.MaxValue);
            Console.WriteLine("------------------------------------");

            Console.WriteLine("byte minimum değer = " + float.MinValue);
            Console.WriteLine("byte minimum değer = " + float.MaxValue);
            Console.WriteLine("------------------------------------");
            
            Console.WriteLine("byte minimum değer = " + double.MinValue);
            Console.WriteLine("byte minimum değer = " + double.MaxValue);
            Console.WriteLine("------------------------------------");







            Console.ReadKey(); //bir tuşa basılana kadar bekler
        }
    }
}





