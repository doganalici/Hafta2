using System;

namespace ConvertClass_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int intdeger = Convert.ToInt32(12.34);
            int intdeger2 = Convert.ToInt32(true);
            int intdeger3 = Convert.ToInt32(null);
            //int onaltılık = Convert.ToInt32("255",16);
            double ondalik1 = Convert.ToDouble("12,34");
            double ondalik2 = Convert.ToDouble("3,14");
            int pi = Convert.ToInt32(ondalik2);
            double deger = 97.8;
            char karakter1 = Convert.ToChar(65);
            

            Console.WriteLine(intdeger);
            Console.WriteLine(intdeger2);
            Console.WriteLine(intdeger3);
            //Console.WriteLine(onaltılık);
            Console.WriteLine(ondalik1);
            Console.WriteLine(pi);
            Console.WriteLine(karakter1);
            Console.ReadKey();
        }
    }
}
