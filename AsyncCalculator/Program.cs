using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncCalculator
{
    class Program
    {
        public static async Task ToplaYazdir(int i,int j,char k)
        {
            
            
            if (k == '+')
            {
                Task.Delay(5000);
                Console.Write("iki sayının toplamı = " + await Toplam(i, j) + "\n");

            }
            if (k == '/')
            {
                Task.Delay(5000);
                Console.Write("iki sayının toplamı = " + await Bol(i, j) + "\n");

            }
            if (k == '-')
            {
                Task.Delay(5000);
                Console.Write("iki sayının toplamı = " + await Cikar(i, j) + "\n");

            }
            if (k == '*')
            {
                Task.Delay(5000);
                Console.Write("iki sayının toplamı = " + await Carp(i, j) + "\n");

            }


        }


        public static Task<int> Toplam(int num1, int num2)
        {
            return Task.Run(() =>
            {
                int result = num1 + num2;
                
                return result;
            }
           );
        }
        public static Task<int> Bol(int num1, int num2)
        {
            return Task.Run(() =>
            {
                int result = num1 / num2;

                return result;
            }
           );
        }
        public static Task<int> Cikar(int num1, int num2)
        {
            return Task.Run(() =>
            {
                int result = num1 - num2;

                return result;
            }
           );
        }
        public static Task<int> Carp(int num1, int num2)
        {
            return Task.Run(() =>
            {
                int result = num1 * num2;

                return result;
            }
           );
        }

        static void Main(string[] args)
        {
            int sayi1=0;
            int sayi2=0;
            char islem;
           while (true)
            {
                Console.WriteLine("İlk sayıyı giriniz: ");
                sayi1 = int.Parse( Console.ReadLine());
                Console.WriteLine("İkinci sayıyı giriniz: ");
                sayi2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Yapmak istediğiniz işlemin sembolünü yazınız: ");
                islem = char.Parse(Console.ReadLine());
                ToplaYazdir(sayi1, sayi2,islem);
            }
            Console.ReadKey();
        }
    }
}
