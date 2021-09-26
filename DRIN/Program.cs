using System;
using System.Linq;

namespace DRIN
{
    class Program
    {
        static void Main(string[] args)
        {
            Ass2();

            //Console.WriteLine($"Введите SUCK:");
            //int SUCK = Convert.ToInt32(Console.ReadLine());
            //string semen = "";
            //while (SUCK != 0)
            //{
            //    semen += (SUCK % 2).ToString();
            //    SUCK = SUCK / 2;
            //}
            //string trueSemen = "";
            //for (int i = semen.Length-1; i > -1; i--)
            //{
            //    trueSemen += semen[i];
            //}


            //Console.WriteLine($"\nДвоичный оригинал: {trueSemen}");
            //Console.WriteLine($"Двоичный перевертыш: {semen}");


            ////Convert.ToString(SUCK, 2);
            ////Array Slave = semen.Reverse().ToArray();

            ////foreach (var item in Slave)
            ////{
            ////    Console.Write(item);
            ////}


            //Console.ReadKey();
        }
        public static void Ass1()
        {
            int[] array = new int[10];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10);
            }
            Console.WriteLine("initial array:");

            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine(array[i] + " ");

            }

            for (int i = 0; i < array.Length; i++)
            {

                array[i] += 10;

            }

            Console.WriteLine("new array:");

            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine(array[i] + " ");

            }
        }
        public static void Ass2()
        {
            Console.WriteLine("Введите сумму рублей:");
            int lube = Convert.ToInt32(Console.ReadLine()), temp_lube = lube % 100;

            if (temp_lube >= 11 && temp_lube <= 19)
            {
                Console.WriteLine($"{lube} рублей.");
            }
            else
            {
                switch (temp_lube)
                {
                    case 1:
                    case 2:
                    case 3:
                        { break; }
                        
                    default:
                        break;
                }
                temp_lube = temp_lube % 10;
                if (temp_lube == 1)
                {
                    Console.WriteLine($"{lube} рубль.");
                }
                if (temp_lube > 1 && temp_lube < 5)
                {
                    Console.WriteLine($"{lube} рубля.");
                }
                if (temp_lube > 4 || temp_lube == 0)
                {
                    Console.WriteLine($"{lube} рублей.");
                }
            }
        }
    }
}
