using System.ComponentModel.Design;
using System.Xml.Schema;

static void BT1()

{
    Console.WriteLine("nhap x");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("nhap y");
    int y = Convert.ToInt32(Console.ReadLine());
    int Sum = 0;
    if (x < y)
    { 

        for (int i = x + 1; i < y; i++)

        {
            if (i % 2 != 0)
            {
                Sum = Sum + i;
            }

        }
    }
    
    else
    { 
        for (int i = x - 1; i > y; i--)
        {
            if (i % 2 != 0)
            {
                Sum = Sum + i;
            }
        }
    }
    
    Console.WriteLine($"Tong cac so le giua x va y la {Sum}");
}
static void BT2()
{
    Console.WriteLine("nhap so nguyen n");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 2; i <= n; i = i + 2)
    {
        if (n % 2 == 0)
        {
            Console.WriteLine($"{i}^2 = {i * i}");

        }
    }
    

}
static void BT3()
{
    Console.WriteLine("nhap so nguyen n");
    int n = Convert.ToInt32(Console.ReadLine());
    int Sum = 0;
    for (int i = 1; i < n;i++)
    {
      if (n %i ==0)
        {
            Sum = Sum + i;
        }
            
        
    }
    if ( Sum == n )
    {
        Console.WriteLine($"{n} la so hoan hao");
    }
    else
    {
        Console.WriteLine($"{n} khong phai la so hoan hao ");
    }
}
static void BT4_Mau1()
{
    Console.WriteLine("nhap n "); 
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i =1; i <= n;i++)
    {
        for (int j =1; j <= i;j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
static void BT4_Mau2()
{
    Console.WriteLine("nhap n");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n - i +1 ; j++) 
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
static void BT4_Mau3()
{
    Console.WriteLine("nhap n ");
    int n = Convert.ToInt32(Console.ReadLine()) ;
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n - i; j++)
        {
            Console.Write(" ");
        }
        for (int x = 1; x <= i ; x++) 
        {
            Console.Write(" " + x);
        }
        Console.WriteLine();
    }
}


static void BT4_Mau5()
{
    Console.WriteLine("nhap n ");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
        for (int j = 0; j <=  i; j++)
        {
            Console.Write(" " + j);
        }
        Console.WriteLine();
    }
}
//static void BT4_Mau6()
//{
//    Console.WriteLine("nhap n ");
//    int n = Convert.ToInt32(Console.ReadLine());
//    for (int i = 1; i <= n; i++)
//    {
//        for (int j = 1; j <= i; j++)
//        {
//            Console.Write(" " + j);
//        }
//        Console.WriteLine();
//    }
//}

static void BT4_Mau8()
{
    Console.WriteLine("nhap n");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            if (j == 1 || j == i || i == n)
            {
                Console.Write(j + " ");
            }
            else
                Console.Write(" ");


        }
        Console.WriteLine();
    }
}
    BT4_Mau8();

//    //}
//    static void BT5()
//{
//    Console.WriteLine("Enter product code");
//    int productCode = Convert.ToInt32(Console.ReadLine());




//    //do
//    //{
//    //    if (productCode > 0)
//    //    {

           
    //        Console.Write("Code of Product");
    //        Console.WriteLine("Enter quanity");
    //        double quanity = Convert.ToDouble(Console.ReadLine());
    //        double price = 0;
    //        double Sum = 0;
    //        string bill = " ";
    //        double total = 0;
    //        string name = " ";
    //        byte key = 0;
    //        bill = bill + string.Format("{0,-20}|{1,12}|{2,12}|{3,12}\n", "NAME", "QUANTITY", "PRICE", "TOTAL");

    //        for (int i = 1; i <= productCode; i++)
    //        {


    //            switch (productCode)
    //            {
    //                case 1:
    //                    name = "Cochorro Quente";
    //                    price = 4.00;
    //                    total = quanity * price;

    //                    break;
    //                case 2:
    //                    name = "X - Salada";
    //                    price = 4.5;
    //                    total = quanity * price;

    //                    break;
    //                case 3:
    //                    name = "X-Bacon";
    //                    price = 5.00;
    //                    total = quanity * price;

    //                    break;
    //                case 4:
    //                    name = "Torrada simples";
    //                    price = 2.00;
    //                    total = quanity * price;

    //                    break;
    //                case 5:
    //                    name = "Refrigerante";
    //                    price = 1.00;
    //                    total = quanity * price;

    //                    break;
    //                default:
    //                    Console.WriteLine("ivaild code");
    //                    break;

    //            }
    //        }
    //            Sum = Sum + total;
    //            bill =  string.Format("{0,-20}|{1,12}|{2,12}|{3,12}\n", name, quanity , Math.Round(price, 2), Math.Round(price, 2));
            

    //        bill = string.Format("{0,-6}{1,50}\n", "TOTAL:", Math.Round(total, 2));
    //        Console.WriteLine(bill);

    //    }


    //    //Console.Write($"Enter (1) to next customer, (0) to exit : ");
    //   // key = byte.Parse(Console.ReadLine());
    //} while (true );
    // //Console.WriteLine("thank you and goodbye ");












//static void BT5_1()
//{
//     byte key = 0;
//            int count = 1;
//            string bill = "";
//            do
//            {
//        Console.Write($"nhap so luong hang cua KH thu {count} da mua :");
//        int sCode = int.Parse(Console.ReadLine());
//        if (sCode > 0)
//        {
//            double total = 0;
//            bill += $"INVOICE {count}\n";
//            bill += $"--------------------------------------------------------------\n";
//            bill += string.Format("{0,-20}|{1,12}|{2,12}|{3,12}\n", "NAME", "QUANTITY", "PRICE", "TOTAL");
//            for (int i = 1; i <= sCode; i++)
//            {
//                Console.Write($"CODE ({i}) of customer ({count}) :");
//                string code = Console.ReadLine();
//                Console.Write($"QUANTITY ({i}) of customer ({count}) :");
//                int quantity = int.Parse(Console.ReadLine());
//                double price = 0, totalI = 0;
//                string name = "";
//                switch (code)
//                {
//                    case "1":
//                        name = "Cochorro Quente";
//                        price = 4;
//                        totalI = quantity * price;
//                        break;
//                    case "2":
//                        name = "X-Salada";
//                        price = 4.5;
//                        totalI = quantity * price;
//                        break;
//                    case "3":
//                        name = "Refrigerante";
//                        price = 1;
//                        totalI = quantity * price;
//                        break;
//                    default:
//                        break;
//                }
//                total += totalI;
//                bill += string.Format("{0,-20}|{1,12}|{2,12}|{3,12}\n", name, quantity, Math.Round(price, 2), Math.Round(totalI, 2));
//            }
//            bill += $"--------------------------------------------------------------\n";
//            bill += string.Format("{0,-6}{1,50}\n", "TOTAL:", Math.Round(total, 2));
//            Console.WriteLine(bill);
//            bill = "";
//            count += 1;
//        }
//        Console.Write($"Enter (1) to next customer, (0) to exit : ");
//        key = byte.Parse(Console.ReadLine());

//    } while (key == 1);

//    Console.Write($"Thanks you & good bye");
//    Console.ReadKey();

//}
