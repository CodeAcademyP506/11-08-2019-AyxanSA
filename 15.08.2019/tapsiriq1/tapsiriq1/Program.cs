using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adinizi Daxil Edin");
            string ad = (Console.ReadLine()).ToString();
            Console.WriteLine("Xos Geldiniz "+ ad);
            Console.WriteLine("Telebesiz?" + " " + "beli ve ya xeyr" );
            string cavab = (Console.ReadLine()).ToString();
            if (cavab == "beli")
            {
                Console.WriteLine("tesekkur edirik " + ad + " " + telebe());
            }else if (cavab == "xeyr")
            {
                Console.WriteLine("Isleyirsiniz?" + " " + "beli ve ya xeyr");
                string isWorker = Console.ReadLine();

                if(isWorker == "beli")
                {
                    Console.WriteLine("tesekkur edirik " + ad + " " + worker());
                }
                else if (isWorker == "xeyr")
                {
                    Console.WriteLine("tesekkur edirik " + ad + " " + sagird());
                }
            }
        }

        static string telebe()
        {
            Console.WriteLine("Hansi Universitetde oxuyursunuz?");
            string uni = Console.ReadLine().ToString();
            Console.WriteLine("Ixtisasiniz nedir?");
            string ixtisas = Console.ReadLine().ToString();
            Console.WriteLine("1 ve 100 arasinda bir reqem daxil edin");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return ("Sen"+ " " + uni + " " + ixtisas + " " + "ixtisasinda oxuyursan" + " " + "ve 1den " + number + " e \n qeder tek edelerin ceminin : " + (sum).ToString() + " oldugunu bilirsen");
        }

        static string worker()
        {
            Console.WriteLine("Vezifeniz");
            string vezife = Console.ReadLine().ToString();
            Console.WriteLine("1den 100e qeder bir reqem daxil edin");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return ("Sen" + " " + vezife + " " +"calisirsan" + " " +  "ve 1den " + number + " e \n qeder tek edelerin ceminin : " + (sum).ToString() + " oldugunu bilirsen");
        }
        static string sagird()
        {
            int sum = 0;
            for (int i = 1; i < 200; i++)
            {
                if (i % 6 == 0)
                {
                    sum += i;
                }
            }
            return ("Boyuk ehtimalla sen sagirdsen,buna baxmayaraq 1den 200e qeder olan 3e bolunen cut reqemlerin ceminin" + (sum).ToString() + " oldugunu bilirsen");
        }
    }
    
}
