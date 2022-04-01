using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0104_終極密碼V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool flag = true;
            //do
            //{
            //    Console.Clear();
            //    flag = guessNumber();
            //} while (flag);

            while (guessNumber())
            {
                Console.Clear();
            }

            //for (; ; ) { guessNumber(); }
        }



        static bool guessNumber()
        {
            // 變數 最小 最大 密碼 猜幾次
            int ans = 22;
            int min = 1;
            int max = 100;
            int cnt = 0;
            int userInput;

            Console.WriteLine($"測試中，目前的密碼是: {ans}\n-----\n");

            //猜到答對為止 => 迴圈 => for  foreach  while  dowhile (ok)
            do
            {
                Console.Write("請輸入密碼:");
                userInput = Convert.ToInt32(Console.ReadLine());
                cnt++;

                // a. 判斷答對 => 輸入跟預設的密碼一樣的時候 (ok)
                if (userInput == ans)
                {
                    Console.WriteLine($"恭喜答對 猜了{cnt} 次");
                }
                else if (min <= userInput && userInput <= max)
                {
                    //     b. 判斷最大值的改變
                    //     c. 判斷最小值的改變 
                    int diff = ans - userInput;
                    // -  => max
                    // +  => min
                    max = diff < 0 ? userInput : max;
                    min = diff > 0 ? userInput : min;
                    Console.WriteLine($"介於 {min} 和 {max} 之間\n");
                }
                else if (userInput <= min || userInput >= max)
                {
                    string str = userInput <= min ? "小" : "大";
                    Console.WriteLine($" 輸入太{ str }  介於 {min} 和 {max} 之間\n");
                }
                else
                {
                    Console.WriteLine("必須要輸入在1-100之間的數字\n");
                }
            } while (userInput != ans);

            Console.WriteLine("是否要繼續遊戲? (Y/N)");

            //// 方法1
            //if (Console.ReadLine().ToUpper()== "Y")
            //{
            //    Console.Clear();
            //    guessNumber();
            //}

            // 方法2
            return Console.ReadLine().ToUpper() == "Y";
        }
    }
}
