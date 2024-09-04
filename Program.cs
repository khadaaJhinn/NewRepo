

namespace KTLT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BT1(); 
        }
        static void BT1()
        {
            Console.WriteLine("nhap gia tri n:");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("kh co gia tri am");
            }
            else
            {
                Console.WriteLine($"{n} giai thua bang {GiaiThua(n)}");
            }
        }



        static void BT2()
        {
            Console.WriteLine("nhap gia tri a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap gia tri n");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("kh co luy thua so am ");
            }
            else
            {
                Console.WriteLine($"{n} la luy thua {a} la {Mu(a, n)}");
            }
        }


        static void BT3()
        {
            Console.WriteLine("nhap gia tri m");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap gia tri n");
            int n = int.Parse(Console.ReadLine());
            if (m == 0 && n == 0)
            {
                Console.WriteLine("kh co kq");
            }
            else
            {
                Console.WriteLine($"USCLN cua {n} va {m} la {USCLN(m, n)}");
            }
        }


        static void BT4()
        {
            Console.WriteLine("nhap gia tri n:");
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("co cai con cac");
            }
            else
            {
                Console.WriteLine($"{n} chuyen sang bang {Change(n)}");
            }
        }
        static void BT5()
        {
            Console.WriteLine("nhap gia tri n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"So doi tho o thang thu {n} la {fibo(n)}");
        }
        static int GiaiThua(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * GiaiThua(n - 1);
        }



        static double Mu(double a, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return (Mu(a, n - 1) * a);
            }
        }
        static double Mu1(double a, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n == 0 && n % 2 == 0)
            {
                return (Mu(a, n / 2) * Mu1(a, n / 2));
            }
            else
            {
                return (Mu(a, (n - 1) / 2) * Mu1(a, (n - 1) / 2));
            }
        }



        static int USCLN(int n, int m)
        {
            if (m == 0)
            {
                return n;
            }
            else
            {
                return USCLN(m, n % m);
            }
        }

        static int Change(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return (n % 2) + 10 * (Change(n / 2));
        }
        static int fibo(int n)
        {
            {
                if (n < 0)
                {
                    return -1;
                }
                else if (n == 0 || n == 1)
                {
                    return n;
                }
                else
                {
                    return fibo(n - 1) + fibo(n - 2);
                }
            }
        }

    }
}
