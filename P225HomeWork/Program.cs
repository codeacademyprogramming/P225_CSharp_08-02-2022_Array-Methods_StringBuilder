using System;

namespace P225HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Home Work - 1
            //Gonderilmis 3 ededin en boyuyunu tapib qaytaran metod - 3 integer
            //parametr qebul edir ve iclerinde en boyuk hansidirsa onu tapib return
            //edir Eyni sekilde verilmis 4 ve 5 ededin en boyuyunu tapan metodlar da
            //yazin (method overloading)

            //int a, b, c, d, e;
            //bool check = true;
            //int choice;

            //Console.WriteLine("Nece eded daxil edeceksiniz: ");

            //while (true)
            //{
            //     check = int.TryParse(Console.ReadLine(), out choice); //true or false return

            //    if(check && choice>=3 && choice <= 5)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Warning!!! Ededi duzgun daxil edin!");
            //    }
            //}

            //switch (choice)
            //{
            //    case 3:
            //        Console.WriteLine("3 dene eded daxil edin: ");
            //        int.TryParse(Console.ReadLine(), out a);
            //        int.TryParse(Console.ReadLine(), out b);
            //        int.TryParse(Console.ReadLine(), out c);
            //        Console.WriteLine($"3 ededen en boyuyu - {LargestNum(a,b,c)}");
            //        break;
            //    case 4:
            //        Console.WriteLine("4 dene eded daxil edin: ");
            //        int.TryParse(Console.ReadLine(), out a);
            //        int.TryParse(Console.ReadLine(), out b);
            //        int.TryParse(Console.ReadLine(), out c);
            //        int.TryParse(Console.ReadLine(), out d);
            //        Console.WriteLine($"4 ededen en boyuyu - {LargestNum(a, b, c,d)}");
            //        break;
            //    case 5:
            //        Console.WriteLine("5 dene eded daxil edin: ");
            //        int.TryParse(Console.ReadLine(), out a);
            //        int.TryParse(Console.ReadLine(), out b);
            //        int.TryParse(Console.ReadLine(), out c);
            //        int.TryParse(Console.ReadLine(), out d);
            //        int.TryParse(Console.ReadLine(), out e);
            //        Console.WriteLine($"5 ededen en boyuyu - {LargestNum(a, b, c, d,e)}");
            //        break;
            //    default:
            //        break;
            //}
            #endregion

            #region Home Work - 2
            //Gonderilmis ededin reqemlerinin cemini qaytaran metod - misalcun bu metodu call
            //ederken arqument olaraq 451 gondersek metoddan geriye 10 qayitmalidir

            //Console.WriteLine("Ededi daxil edin");
            //string str = Console.ReadLine();
            //int num;
            //while (!int.TryParse(str, out num) && num == 0)
            //{
            //    Console.WriteLine("Duzgun Daxil Et");
            //    str = Console.ReadLine();
            //}
            //Console.WriteLine(SumOfNumber(num));

            #endregion

            #region Home Work - 3
            //Supermarketdə belə bir aksiya keçirilir:
            //“İstənilən iki mal alana üçüncüsü pulsuz verilir,
            //ancaq seçilmiş 3 maldan iki ən bahalısının qiyməti ödənilir”.
            //Alınacaq 3 məhsulun qiyməti verilmişdirsə ödəniləcək məbləği
            //hesbalayan metod yazin - yəni metodunuz 3 doubel parameter qebul edib en
            //boyuk ikisinin cemini hesablayib qaytarmalidir
            Console.WriteLine(MarketProduct(30.5,20.7,10.9));
            #endregion
        }

        #region Home Work - 1
        //Gonderilmis 3 ededin en boyuyunu tapib qaytaran metod - 3 integer
        //parametr qebul edir ve iclerinde en boyuk hansidirsa onu tapib return
        //edir Eyni sekilde verilmis 4 ve 5 ededin en boyuyunu tapan metodlar da
        //yazin (method overloading)
        static int LargestNum (int a, int b, int c)
        {
            if (a>=b && a >= c)
            {
                return a;
            }
            else if (b>=a && b >= c)
            {
                return b;
            }
            return c;
        }
        static int LargestNum(int a, int b, int c, int d)
        {
            int max = LargestNum(a, b, c);

            return max >= d ? max : d;
        }

        static int LargestNum(int a ,int b, int c, int d, int e)
        {
            int max = LargestNum(a, b, c, d);

            return max >= e ? max : e;
        }
        #endregion

        #region Home Work - 2
        //Gonderilmis ededin reqemlerinin cemini qaytaran metod - misalcun bu metodu call
        //ederken arqument olaraq 451 gondersek metoddan geriye 10 qayitmalidir
        static int SumOfNumber(double num)
        {
            double sum = 0;
            double temp;

            while (num != 0)
            {
                temp = num % 10;
                num = (num - temp) / 10;
                sum += temp;

            }

            return (int)sum;
        }
        #endregion

        #region Home Work - 3
        //Supermarketdə belə bir aksiya keçirilir:
        //“İstənilən iki mal alana üçüncüsü pulsuz verilir,
        //ancaq seçilmiş 3 maldan iki ən bahalısının qiyməti ödənilir”.
        //Alınacaq 3 məhsulun qiyməti verilmişdirsə ödəniləcək məbləği
        //hesbalayan metod yazin - yəni metodunuz 3 doubel parameter qebul edib en
        //boyuk ikisinin cemini hesablayib qaytarmalidir

        static double MarketProduct(double a, double b, double c)
        {
            double sum = 0;

            if (a < b && a< c)
            {
                sum += (b + c);
            }
            else if(b < a && b< c)
            {
                sum += (a + c);
            }
            else if(c < a && c<b)
            {
                sum += (a+b);
            }
            else
            {
                Console.WriteLine("Daxil Edilen Ededler arasinda beraberlik var");
            }

            return sum;
        }
        #endregion
    }
}
