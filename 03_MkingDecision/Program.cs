using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MkingDecision 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password= Console.ReadLine();

            //if (password =="abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış!!!");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı.");
            //}
            //else
            //{
            //    Console.Write("Hatalı bilgi.");
            //}


            //int number;
            //Console.Write("sayı giriniz: ");
            //number=int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("sayı doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("sayı hatalı.");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "hata";
            //Console.WriteLine("sınav 1: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.WriteLine("sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average=(exam1+exam2+exam3)/3;
            //Console.WriteLine("sınavların ortalaması: " + average);

            //if (average>0 & average<=50)
            //{
            //    result = "sonuç vasat";
            //}
            //if (average>50 & average<= 70)
            //{
            //    result = "sonuç orta";
            //}
            //if (average>70 & average<=84)
            //{
            //    result = "sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "sonuç çok iyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if(city=="adana" | city=="ankara" | city=="bursa" | city=="van")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("Lütfen Kullanıcı Adını Giriniz: ");
            //string username= Console.ReadLine();
            //if (username!="admin")
            //{
            //    Console.Write("bu kullanıcı kabul edilemez.");
            //}
            //else
            //{
            //    Console.Write("hoş geldiniz");
            //}

            #endregion

            #region Mod İşlemleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("lütfen 1.sayıyı giriniz: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("lütfen 2. sayiyi giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.sayının 2.sayıya bölümünden kalan: " + result);


            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number =int.Parse(Console.ReadLine());

            //if (number %2== 0)
            //{
            //    Console.Write("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.Write("sayi tektir.");
            //}



            #endregion

            #region Char Değişkenler İle Karar Yapıları
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if (team =='g' | team=='G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team=='f' | team=='F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            //Console.Read();
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("*** C# Eğitim Kampı Restoran ***");
            //Console.WriteLine("");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorabalar");
            //Console.WriteLine("3-Pizalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menüyü seçimi: ");
            //menuItem= Console.ReadLine();

            //if (menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----Ana Yemekler----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Körü Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasülye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----Çorbalar----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Ezogelin");
            //    Console.WriteLine("2-Mercimek");
            //    Console.WriteLine("3-Kelle Paça");
            //    Console.WriteLine("4-işkembe");

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----Pizzalar----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margarita Pizza");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("4-Kavurmalı Pizza");

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----İçecekler----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----Tatlılar----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");

            //}


            //    Console.Read();

            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.Write("Ocak"); break;
            //    case 2:Console.Write("Şubat"); break;
            //    case 3:Console.Write("Mart"); break;
            //    case 4:Console.Write("Nisan"); break;
            //    case 5:Console.Write("Mayıs"); break;
            //    case 6:Console.Write("Haziran"); break;
            //    case 7:Console.Write("Temmuz"); break;
            //    case 8:Console.Write("Ağustos"); break;
            //    case 9:Console.Write("Eylül"); break;
            //    case 10:Console.Write("Ekim"); break;
            //    case 11:Console.Write("Kasım"); break;
            //    case 12:Console.Write("Aralık"); break;
            //    default:Console.Write("Hatalı Veri Girişi"); break;
            //}

            //Console.Read();

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. sayiyi giriniz: ");
            //number1=int.Parse (Console.ReadLine());

            //Console.Write("2. sayiyi giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol=char.Parse (Console.ReadLine());


            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: "+ result);
            //        break;

            //    case '-':
            //        result=number1- number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpim: " + result);
            //        break;
                
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;



            //}
            //Console.Read();
            #endregion


        }
    }
}