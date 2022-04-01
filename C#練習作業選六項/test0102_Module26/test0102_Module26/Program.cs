// See https://aka.ms/new-console-template for more information

namespace test_Module26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lab01
            testGeneric("ABC");
            testGeneric(123);

            //Lab02
            testGeneric("XYZ", 321);

        }

        static void testGeneric<T>(T t)
        {
            Console.WriteLine(t);
        }

        static void testGeneric<T>(T t, int num)
        {
            Console.WriteLine(t);
            Console.WriteLine(num);
        }
    }
}
