using System;
using System.Globalization;
//using static System.Console;

namespace ParseMetodu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parse() metodu string bir değeri tüm ilkel türlere(değer tipler) dönüştürür
            //tür.Parse(string str)

            string str = "123";
            byte bytedeger = Byte.Parse(str);
            short shortdeger = Int16.Parse(str);
            int intdeger = Int32.Parse(str);
            float floatdeger = Single.Parse(str);
            double doubledeger = Double.Parse(str);
            //char chardeger = Char.Parse(str);

            Console.WriteLine(bytedeger);
            Console.WriteLine(shortdeger);
            Console.WriteLine(intdeger);
            Console.WriteLine(floatdeger);
            Console.WriteLine(doubledeger);
            //Console.WriteLine(chardeger);
            Console.WriteLine("---------------");
            string str2 = "(100)";
            int intdeger2 = Int32.Parse(str2, NumberStyles.AllowParentheses);
            Console.WriteLine(intdeger2);
            Console.WriteLine("---------------");

            string str3 = "10.000";
            int paradeger = Int32.Parse(str3, NumberStyles.AllowThousands, new CultureInfo("tr-TR"));
            Console.WriteLine(paradeger);
            Console.WriteLine("---------------");
            //string str4="1111111111111111111111111111111";
            // Console.WriteLine(Int32.Parse(str4));

            Console.ReadKey();
        }
    }
}