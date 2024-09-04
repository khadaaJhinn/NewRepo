internal class program1
{
    static void BT1()
    {
        Console.WriteLine("Nhap n ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine($" {n} la so am ");
        }
        else
        {
            if (n % 2 == 0)
            {
                for (int i = 0; i <= n; i = i + 2)
                {
                    Console.Write(i + " ");
                }

            }



            else if (n % 2 != 0)
            {
                for (int i = 1; i <= n; i = i + 2)
                {
                    Console.Write(i + " ");
                }
            }

        }


    }
    static void NhapMang(ref int[] a , int n )
    {

        a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap gia tri cua a[{i}] ");
            a[i] = Convert.ToInt32( Console.ReadLine() );
        }
    }
    static void InMang(ref int[] a , int n )
    {
        for ( int i = 0; i < n; ++i )
        {
            Console.Write(a[i] + " ");
        }
    }
    static  void BT2_ab()
    {
        Console.WriteLine("Nhap n ");
        int n = Convert.ToInt32(Console.ReadLine()); 
        int[] a = new int[n];
        NhapMang(ref a, n ); 
        InMang(ref a , n );
    }
    static int Sum(ref int[] a, int n)
    {
        Console.WriteLine("nhap k ");
        int k = Convert.ToInt32(Console.ReadLine());
        int S = 0;
        for (int i = 0; i < n; i++)
        {
            S = S + a[i]; 

        }
        if (S < k )
        {
            Console.WriteLine(S);
        }
        return S;

        
       
    }
    static void BT2_c()
    {
        Console.WriteLine("nhap n ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        Console.WriteLine("Nhap mang: ");
        NhapMang(ref a, n );
        Console.Write("Xuat mang: ");
        InMang(ref a, n);
        Sum(ref a , n );

        
    }
    static int[] CountCharacters(string input)
    {
        int[] count = new int[26];

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                int index = (int)char.ToLower(c) - 'a';
                count[index]++;
            }
        }

        return count;
    }

    static void BT3()
    {
        Console.Write("Nhap chuoi ki tu thu nhat: ");
        string s1 = Console.ReadLine();

        Console.Write("Nhap chuoi ki tu thu hai: ");
        string s2 = Console.ReadLine();

        int[] count1 = CountCharacters(s1);
        int[] count2 = CountCharacters(s2);

        Console.WriteLine("So lan xuat hien cua cac ki tu trong chuoi 1:");
        for (int i = 0; i < 26; i++)
        {
            if (count1[i] > 0)
            {
                char c = (char)(i + 'a');
                Console.WriteLine("{0}: {1}", c, count1[i]);
            }
        }

        Console.WriteLine("So lan xuat hien cua cac ki tu trong chuoi 2:");
        for (int i = 0; i < 26; i++)
        {
            if (count2[i] > 0)
            {
                char c = (char)(i + 'a');
                Console.WriteLine("{0}: {1}", c, count2[i]);
            }
        }
        Console.ReadKey();
    }
    
    static void ChuyenThapPhanSangNhiPhan()
    {
        Console.WriteLine("Nhap n ");
        int n = Convert.ToInt32(Console.ReadLine());
        string temp = "";
        while( n > 0) 
        {
            int du = n % 2;
            temp = du.ToString() + temp;
            n = n / 2;
        }
        Console.WriteLine(temp);
    }

    static void Func(int x, int m, ref int n)
    {
        m = x * x;
        n = x * x * x;
    }
    static void lala()
    {
        int x = 2;
        int m = 0;
        int n = 0;
        Func(x, m, ref n);
        Console.WriteLine($"{m} {n}");
    }

    static void naykia()
    {
        int i = 4;
        Console.WriteLine(++i);
        Console.WriteLine(i++);
        Console.WriteLine(i);
    }








    static void Main(string[] args)
    {
       naykia();
    }
    
}