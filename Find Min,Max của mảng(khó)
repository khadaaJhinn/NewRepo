using System.ComponentModel.Design.Serialization;
using System.Security.AccessControl;

internal class Program
{
    static void NhapMang(ref int[] a, int n) 
    {

        a = new int[n]; 
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine();
            Console.Write("Nhap gia tri cua phan tu ");
            a[i] = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine($"gia tri cua phan tu a[{i}] la {a[i]}");    
        }
    }  
    static void InMang(ref int[] a )
    {
        for(int i = 0;i < a.Length;i++)
        {
            Console.Write(a[i] + " ");  
        }
    }
    

    static void test()
    {
        Console.WriteLine("nhap n ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        NhapMang(ref a, n);
        InMang(ref a);
    }

    static (int min, int max) FindMinMax(int[] a, int trai, int phai )
    {
        if (trai == phai)
        {
            return (a[trai], a[trai]);
        }

        int mid = (trai + phai) / 2;
        (int minTrai, int maxTrai) = FindMinMax(a, trai , mid);
        (int minPhai, int maxPhai) = FindMinMax(a, mid + 1, phai);

        return (Math.Min(minTrai, minPhai), Math.Max(maxTrai, maxPhai));
    }


    static void ChiaDeTRi() 
    {
        Console.WriteLine("nhap n ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n]; 
        NhapMang(ref a, n);  
        InMang(ref a  );
        (int min, int max) = FindMinMax(a, 0, n - 1);
        Console.WriteLine();
        Console.WriteLine($"gia tri nho nhat :{min}");
        Console.WriteLine($"gia tri lon nhat :{max}");
    }
    static void Main(string[] args)
    {
        ChiaDeTRi(); 
    }
   

}













    
        
    
