using System;
using System.ComponentModel;
using System.Reflection;

namespace BT1
{


    internal class Program1
    {
        static int Cong(int a, int b)
        {
            return a + b;


        }

        static int Tru(int a, int b)
        {
            return a - b;
        }


        static int Nhan(int a, int b)
        {
            return a * b;
        }
        static float Chia(float a, float b)
        {
            return a / b;
        }

        static void BT1()
        {


            Console.WriteLine("nhap a va b ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Cong {Cong(a, b)}");
            Console.WriteLine($" Tru {Tru(a, b)}");
            Console.WriteLine($" Nhan {Nhan(a, b)}");
            Console.WriteLine($" Chia {Chia(a, b)}");
            Console.ReadKey();

        }
        static void Swapping( ref int a,ref  int b)
        {


            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Swapping {a} {b}");
        }

        static void BT2()
        {
            Console.WriteLine("nhap a va b");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"before swapping {a} {b} ");
            Swapping( ref a,ref  b);
            Console.WriteLine($"after swapping {a} {b} ");
            Console.ReadKey();
        }

        static void Calculator(ref int a, ref int b, ref int Cong, ref int Tru, ref int Nhan, ref int Chia)
        {
            Cong = a + b;
            Tru = a - b;
            Nhan = a * b;
            Chia = a / b;
            Console.WriteLine($"{a} + {b} = {Cong}");
            Console.WriteLine($"{a} - {b} = {Tru} ");
            Console.WriteLine($"{a} * {b} = {Nhan}");
            Console.WriteLine($"{a} / {b} = {Chia}");
        }

        static void BT3()
        {
            Console.WriteLine("nhap a va b");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int Cong = 0;
            int Tru = 0;
            int Nhan = 0;
            int Chia = 0;
            Calculator(ref a, ref b, ref Cong, ref Tru, ref Nhan, ref Chia);
            Console.ReadKey();
        }






        static void find_Min(ref int a, ref int b, ref int c, out int Min)
        {
            Min = a;
            if (b < Min) Min = b;
            if (c < Min) Min = c;
            Console.WriteLine($"so nho nhat trong 3 so {a} {b} {c} la {Min}");

        }
        static void BT4()
        {
            Console.WriteLine("nhap a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap c");
            int c = Convert.ToInt32(Console.ReadLine());
            int Min = a;
            find_Min(ref a, ref b, ref c, out Min);

        }


        static void find_Max(ref int a, ref int b, ref int c, out int Max)
        {
            Max = a;
            if (b > a) Max = b;
            if (c > a) Max = c;
            Console.WriteLine($"so lon nhat trong 3 so {a} {b} {c} la {Max}");
        }

        static void BT5()
        {
            Console.WriteLine("nhap a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap c");
            int c = Convert.ToInt32(Console.ReadLine());
            int Max = a;
            find_Max(ref a, ref b, ref c, out Max);
        }

        static void Find_MinMax(ref int a, ref int b, ref int c, out int Max, out int Min)
        {
            Max = a;
            if (b > Max) Max = b;
            if (c > Max) Max = c;
            Min = a;
            if (b < Min) Min = b;
            if (c < Min) Min = c;
            Console.WriteLine($"So nho nhat trong 3 so {a} {b} {c} la {Min} ");
            Console.WriteLine($"So lon nhat trong 3 so {a} {b} {c} la {Max}");

        }

        static void BT6()
        {
            Console.WriteLine("nhap a b c ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int Max = 0;
            int Min = 0;
            Find_MinMax(ref a, ref b, ref c, out Max, out Min);
        }

        //static bool soNguyento(ref int n)
        //{
        //    bool soNguyento = true;
        //    for (int i = 1; i < Math.Sqrt(n); i++)
        //    {
        //        if (n % i ==0 )
        //        {
        //            soNguyento = false; break;
        //        }
        //    }
        //}
        //static void BT10()
        //{
        //    Console.WriteLine("nhap n "); 
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    soNguyento(ref n); 
        //}

        static void Sum(ref int n, out int Summary)
        {

            Summary = 0;
            for (int i = 0; i <= n; i++)
            {
                Summary = Summary + i;
            }
        }
        static void BT7()
        {
            Console.WriteLine("nhap n ");
            int n = Convert.ToInt32(Console.ReadLine());
            int Summary = 0;
            Sum(ref n, out Summary);
            Console.WriteLine($"Ham tinh tong tu 1 den {n} la {Summary}");

        }
        static int Tinh_Tong(int n, out int Sum)
        {
            int x = 0;
            Sum = 0;
            do
            {
                x = n % 10;
                n = n / 10;
                Sum = Sum + x;

            }
            while (n > 0);
            {
                return Sum;
            }

        }
        static void BT8()
        {
            Console.WriteLine("nhap n ");
            int n = Convert.ToInt32(Console.ReadLine());
            int Sum;
            Tinh_Tong(n, out Sum);
            Console.WriteLine($"Tong cac chu so cua {n} la {Sum}");
            Console.ReadKey();

        }


        static int Max_( int n,out  int max )
        {
             max = 0;
             int x = 0;
            do
            {
                x = n % 10;
                n = n / 10;
                if (x > max)
                    max = x;
            }
            while (n > 0);
            {
                return max;
            }
        }

        static void BT9()
        {
            Console.WriteLine("nhap n ");
            int n = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            Max_( n, out max);
            Console.WriteLine($"so lon nhat trong cac chu so cua {n} la {max}");




        }




        static float power(float a, float n )
        {
            float result = (float) Math.Pow(a, n);
            return result;
        }


        static void BT11()
        {
            Console.WriteLine("nhap a");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap n");
            int n = Convert.ToInt32(Console.ReadLine());
            power(a, n);
            Console.WriteLine($"result of  a to the power of n {power(a,n)}");
        }

            static void Main(string[] args)
            {
            BT11();

            }

        
    }
}