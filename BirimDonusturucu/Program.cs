using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirimDonusturucu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz! Lütfen para birimi dönüştürmek için 'p' yada ısı dönüştürücü için herhangi bir tuşa basın.");
            string cevap = Console.ReadLine();

            if (cevap == "p")
            {
                Console.WriteLine("Para dönüştürücüyü seçtiniz.");
                Console.WriteLine("Lütfen pound çevirmek için 'p' yada euro çevirmek için herhangi bir tuşa basınız.");
                string secenek = Console.ReadLine();

                if (secenek == "p")
                {
                    Console.WriteLine("Lütfen İngiliz poundu miktarını giriniz.");
                    float pound = float.Parse(Console.ReadLine());
                    float euro = pound * 1.16f;
                    Console.WriteLine("Euro cinsinden miktar " + euro.ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("Lütfen euro cinsinden miktarı giriniz.");
                    float euro = float.Parse(Console.ReadLine());
                    float pound = euro / 1.16f;
                    Console.WriteLine("İngiliz poundu cinsinden miktar " + pound.ToString("0.00"));
                }
            }
            else
            {
                Console.WriteLine("Sıcaklık dönüştürücüye hoşgeldiniz!");
                Console.WriteLine("Lütfen santigrat cinsi için 's' yada fahrenayt için herhangi bir tuşa basınız.");
                string secenek = Console.ReadLine();

                if (secenek == "s")
                {
                    Console.WriteLine("Santigrat cinsinden bir derece giriniz.");
                    float santigrat = float.Parse(Console.ReadLine());
                    float fahrenhayt = santigrat * 1.18f + 32f;
                    Console.WriteLine("Fahrenhayt cinsinden dereceniz " + fahrenhayt);

                }
                else
                {
                     Console.WriteLine("Lütfen fahrenhayt cinsi bir ısı giriniz.");
                    float fahrenhayt = float.Parse(Console.ReadLine());
                    float santigrat = (fahrenhayt - 32f) / 1.8f;
                    Console.WriteLine("Santigrat cinsinden dereceniz " + santigrat);
                }
            }
        }
    }
}
