﻿using System.Diagnostics.CodeAnalysis;

internal class program
{
    static void InMang(ref int[] ai)
    {
        for (int i = 0; i <ai.Length; i++)
        {
            Console.Write(ai[i] + " "); 
        }
    }
    static void NhapMang(ref int[] ai)
    {
        for (int i = 0; i < ai.Length; i++)
        {
            Console.WriteLine($"nhap gia tri cua phan tu a[{i}]");
            ai[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    static void BT1()
    {
        Console.WriteLine("nhap n ");
        for (int i = 1; i < 10; i++)
        {
            if(i % 2 != 0 )
            {
                Console.Write(i + " ");
            }
        }
    }
    static void BT2() 
    {
        Console.WriteLine("nhap x");
        int x = Convert.ToInt32(Console.ReadLine());
        int n = 1;
        int sum = 4;
        while (sum <= x)
        {
            sum = sum + (n * 4);
            n++; 
        }
        Console.WriteLine($"gia tri n lon nhat cua bieu thuc la {n} ");

    }
    static void ThayMax(ref int[] ai, ref int x)
    {
       
        int max = ai[0];
        for (int i = 1; i < ai.Length; i++)
        {
            if (ai[i] >= max)
            {
                max = ai[i];



            }
           
        }
        for (int i = 0; i < ai.Length; i++)
        {
            if (ai[i] == max )
            {
                ai[i] = x;
            }

        }








    }
    static void BT4()
    {
        Console.WriteLine("nhap n ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ai = new int[n];
        NhapMang(ref ai);
        InMang(ref ai);
        Console.WriteLine("Nhap x");
        int x = Convert.ToInt32(Console.ReadLine());
        ThayMax(ref ai, ref x);
        
        for (int i = 0; i < ai.Length; i++)
        {
            Console.Write(ai[i] + " ");
        }





    }

    
    static void Main(string[] args)
    {
        BT4();
    }
}