using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zort();
        }

        static void Zort()
        {
            Console.WriteLine("Hoşgeldiniz, hesap oluşturmak için ENTER tuşuna basınız...");
            string welcome = Console.ReadLine();
            switch (welcome)
            {
                case "":

                    Console.WriteLine("Lütfen E-Postanızı oluşturunuz.");
                    string mem = Console.ReadLine();


                    Console.WriteLine("Lütfen şifrenizi oluşturunuz.");
                    string mp = Console.ReadLine();

                    Console.WriteLine("Hesap oluşturuldu...");
                    Console.WriteLine("");

                    //hesap oluşturma bitti 

                    //kontrol etme

                    Console.WriteLine("Lütfen E-Postanızı yazınız.");
                    string uem = Console.ReadLine();
                    Console.WriteLine("Lütfen Şifrenizi yazınız.");
                    string up = Console.ReadLine();


                    if (mem != uem || mp != up)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(
                        "Hatalı E-Posta veya Şifre girdiniz.\b Lütfen tekrar deneyiniz");
                        while (mem != uem || mp != up)
                        {
                            Console.WriteLine("Lütfen E-Postanızı yazınız.");
                            uem = Console.ReadLine();
                            Console.WriteLine("Lütfen şifrenizi giriniz...");
                            up = Console.ReadLine();
                            if (mem != uem || mp != up)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Hatalı E-Posta veya Şifre girdiniz.\b Lütfen tekrar deneyiniz");
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Giriş Yapıldı...");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Giriş Yapıldı...");
                    }

                    break;
                    default:
                    Console.WriteLine("GUNDİ neden basmadın enter'a");
                    break;
            }
        }
    }
}
