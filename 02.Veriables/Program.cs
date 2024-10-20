using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Double Değişkenler
            //double number;
            //number=4.85;
            //Console.WriteLine(number);
            //meyve sebze ekranı oluşturma

            //Console.WriteLine("*** Fiyat Listesi ***");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 21.89;
            //strawberryPrice = 45.49;
            //potatoPrice = 15.99;
            //tomatoPrice = 32.49;

            //Console.WriteLine("---- Elma Birim Fiyatı "+applePrice +" TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı "+orangePrice+" TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı "+strawberryPrice+" TL");
            //Console.WriteLine("---- Patates Birim Fiyatı "+potatoPrice+" TL");
            //Console.WriteLine("---- Domates Birim Fiyatı "+tomatoPrice+" TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.750;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma" + " Birim Fiyatı: "+ applePrice+ " Alınan Gramaj: "+ appleGram + " Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal" + " Birim Fiyatı: "+ orangePrice+ " Alınan Gramaj: "+ orangeGram + " Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek" + " Birim Fiyatı: "+ strawberryPrice+ " Alınan Gramaj: "+ strawberryGram + " Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates" + " Birim Fiyatı: "+ potatoPrice+ " Alınan Gramaj: "+ potatoGram + " Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates" + " Birim Fiyatı: "+ tomatoPrice+ " Alınan Gramaj: "+ tomatoGram + " Toplam Tutar: "+ tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL");




            //-------------------------------------------------------------------------------
            //Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #region Klavyeden Veri Gİrişleri String Değişkenler 


            //Console.WriteLine("*** CSHARP Hava Yolları Hava Bilgisi ***");
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName =Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname =Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict =Console.ReadLine();

            //Console.Write("Şehir: ");
            //passengerCity =Console.ReadLine();

            //Console.Write("Yolcunun Yaşı: ");
            //passengerAge =Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik Numarası: ");
            //passengerIdentityNumber =Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("Yolcu Bilgisi: " + passengerName +" "+ passengerSurname+" "+passengerDistrict+"/"+passengerCity+" "+passengerAge+" Yolcu TC Kimlik Numarası "+passengerIdentityNumber);


            //
            #endregion


            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse (Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoesCount*shoesPrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar : "+totalPrice+" TL");
            #endregion

            #region Klavyeden Ondalıklı Sayı işlemleri

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("lütfen 1.sınav notunu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.WriteLine("lütfen 2.sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("lütfen 3.sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result =(exam1+exam2+exam3)/3 ;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: "+result); 


            #endregion

            #region Klavyeden Karakter Girişleri 

            //char gender;
            //Console.WriteLine("Lütfen Cinsiyet Seçiniz: ");
            //gender =char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: "+gender);

            #endregion

            Console.Read();


        }
    }
}
