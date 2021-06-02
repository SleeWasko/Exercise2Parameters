using System;

namespace Exercise2Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int testVal1 = 1;
            Console.WriteLine("Original value:", testVal1);
            Test(testVal1);
            Console.WriteLine("Return value: {0}", testVal1);

            int testVal2 = 2;
            Console.WriteLine("/n")
            //Console.WriteLine("Original value:", testVal2);
            TestOut(out testVal2);
            Console.WriteLine("Return value: {0}", testVal2);

            int testVal3 = 3;
            Console.WriteLine("Original value:", testVal3);
            TestRef(ref testVal3);
            Console.WriteLine("Return value: {0}", testVal3);

            Console.WriteLine("\n calling TestOptional with a parameter");
            TestOptional(4);

            Console.WriteLine("\n calling TestOptional without a parameter");
            TestOptional();

            Console.WriteLine("\n TestMultiple");
            TestMultiple(1, 2, 3);

            Console.WriteLine("\n TestMultiple set just first 2");
            TestMultiple(1, 2);
            Console.WriteLine("\n Test multiple set just first 2");
            TestMultiple(1, cValue: 3);
        }

        public static void TestMultiple(int aValue, int bValue = 222, int cValue = 333)
        {
            Console.WriteLine("In TestMultiple Values are {0}, {1}, {2}", aValue, bValue, cValue);
        }


        public static void Test(int aValue)
        {
            aValue = 111;
            Console.WriteLine("In Test Value is {0}", aValue);
        }

        public static void TestOut(out int aValue)
        {
            aValue = 222;
            Console.WriteLine("In TestOut Value is {0}", aValue);
        }

        public static void TestRef(out int aValue)
        {
            aValue = 333;
            Console.WriteLine("In TestRef Value is {0}", aValue);
        }

        public static void TestOptional(int aValue = 444)
        {
            aValue = 333;
            Console.WriteLine("In TestOptional Value is {0}", aValue);
        }





    }
}
