using System;

namespace hello_world
{
    class Program
    {
        static int owen(int x)
        {
            return x+100;
        }

        static void Main(string[] args)
        {
            string sometext = "oopopopopoopopopop";
            Console.WriteLine(sometext);
            double d = 1.2223232323232;
            string s = "texttext";
            float f = 1.1F;
            long l = 123456789012345;
            short sh = 255;
            byte b = 8;

            for (int i=10; i<1000; i+=10)
            {
                int o = owen(i);
                Console.WriteLine(o);
            }

            Console.WriteLine(d);
        }


    }
}
