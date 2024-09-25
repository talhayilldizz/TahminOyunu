using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahminOyunu
{
    internal class OyunKodları
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0-10 Arasında Belirlediğimiz Sayıyı Bul..");
            ArrayList NewList = new ArrayList();

            Random rnd = new Random();
            int kod = rnd.Next(0, 10);
            NewList.Add(kod);

            int guess = 3;

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine(i + ". " + "Tahmini Yap.");
                int value1 = Convert.ToInt32(Console.ReadLine());
                bool control = NewList.Contains(value1); //Dizide o değer varmı diye bakıyor

                if (control == true)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Tahmin Doğru.. Tebrikler");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Hatalı Tahmin Yaptınız..");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    guess--;
                    Console.WriteLine("Kalan Hakkınız: " + guess);
                }
            }
            foreach (var a in NewList)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Sistemin Belirlediği Sayı: " + a);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }

            Console.ReadLine();
        }
    }
}
