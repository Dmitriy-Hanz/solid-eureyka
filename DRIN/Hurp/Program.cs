using System;

namespace Hurp
{
    class MyAss
    {
        public int cash20, cash50, cash100,sum;
        public MyAss(int cash20, int cash50, int cash100)
        {
            this.cash20 = cash20;
            this.cash50 = cash50;
            this.cash100 = cash100;
            sum = cash20 * 20 + cash50 * 50 + cash100 * 100;
        }
        public bool GETOVERHERE(int что_хотим)
        {
            int count20 = 0, count50 = 0, count100 = 0;
            while (что_хотим >= 100 && cash100 != 0)
            {
                что_хотим -= 100;
                cash100--;
                count100++;
            }
            while (что_хотим >= 50 && cash50 != 0)
            {
                что_хотим -= 50;
                cash50--;
                count50++;
            }
            while (что_хотим >= 20)
            {
                что_хотим -= 20;
                count20++;
            }
            if (что_хотим != 0)
            {
                Console.WriteLine("\nОстальное - мелочью:");
            }
            Console.WriteLine("\nЧем и кем:");
            Console.WriteLine($"\n{count20} 20-рублевок, {count50} 50-рублевок, {count100} 100-рублевок.\n");
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyAss ass = new MyAss(10, 7, 5);
            int g = 0;
            Console.WriteLine("Сколько денег хочеца:");
            while (g == 0)
            {
                g = Convert.ToInt32(Console.ReadLine());
                if (g < 0)
                {
                    Console.WriteLine("\nТы озуел отрицательное дерьмо вводить, повторяй!");
                    g = 0;
                }
            }
            ass.GETOVERHERE(g);

            Console.ReadKey();
        }
    }
}
