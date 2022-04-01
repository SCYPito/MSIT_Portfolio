// See https://aka.ms/new-console-template for more information
namespace test0102.Module28 
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Lab01
            int a = 1;
            int b = 2;
            int max=(a>b)?a:b; 
            Console.WriteLine("Lab01");
            Console.WriteLine(max);
            min(b, a);
            Console.WriteLine("END");

            //Lab02
            Console.WriteLine("Lab02");
            Console.WriteLine($"a > b：{a > b}");
            Console.WriteLine($"a < b：{a < b}");
            Console.WriteLine($"a == b：{a == b}");
            Console.WriteLine($"a != b：{a != b}");
            Console.WriteLine($"a >= b：{a >= b}");
            Console.WriteLine($"a <= b：{a <= b}");
            Console.WriteLine("END");

            //Lab03
            Console.WriteLine("Lab03");
            int i = 10;
            bool result = (i > 5) && (i < 15);
            Console.WriteLine($"i 是否在 5～15 之間：{result}");
            Console.WriteLine("END");
        }
        static void min(int a,int b) 
        {
            int min = 0;
            if (b > a)
            {
                min= a;
                Console.WriteLine(min);
            }
            else
            {
                min = b;
                Console.WriteLine(min);
            }
        }
    } 
}
