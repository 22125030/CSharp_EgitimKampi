using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {


        static void Main(string[] args)
        {

            // YazdırmaKomutları
            //Console.WriteLine("selam");
            //Console.Write("merhaba dünya");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();

            //Console.WriteLine("1-çorbalar");
            //Console.WriteLine("2-Ana yemekler");
            //Console.WriteLine("3-soğk başlangışlar");
            //Console.WriteLine("4-salatalar");
            //Console.WriteLine("5-tatlılar");
            //Console.WriteLine("6-içecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");


            //değişkenler

            //string
            //Değişken_türü değişen_adi;

            //string name;
            //name = "Murat";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Hazır";
            //customerPhone = "+905005005050";
            //customerEmail = "alihazır12@gmail.com";
            //district = "Bucak";
            //city = "Burdur";

            //Console.WriteLine("*** Rezervasyon Kartı ***");
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim : " + customerPhone);
            //Console.WriteLine("email: " + customerEmail);
            //Console.WriteLine("adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------------------");


            //customerName = "Fatma";
            //customerSurname = "Yapıcı";
            //customerPhone = "+95225244541";
            //customerEmail = "fatma@gmail.com ";
            //district = "Körfez";
            //city = "Kocaeli";

            //Console.WriteLine();
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim : " + customerPhone);
            //Console.WriteLine("email: " + customerEmail);
            //Console.WriteLine("adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------------------");


            // int değişkenler

            //int number = 25;
            //Console.WriteLine(number);  

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("*** Restoran Menü Fiyatı ***");
            Console.WriteLine();
            Console.WriteLine("--Hamburger Fiyatı:" + hamburgerPrice + "TL");
            Console.WriteLine("--Kola Fiyatı:" + cokePrice + "TL");
            Console.WriteLine("--Su Fİyatı:" + waterPrice + "TL");
            Console.WriteLine("--Pizza Fiyatı:" + pizzaPrice + "TL");
            Console.WriteLine("--Limonata Fiyatı:" + lemonadePrice + "TL");
            Console.WriteLine("--Kızartma Fiyatı:" + friesPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("*** Restoran Menü Fiyatı ***");

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;


            hamburgerCount = 3;
            cokeCount=3;
            waterCount=3;
            friesCount=1;
            pizzaCount=0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice; 
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice= lemonadeCount * lemonadePrice;  
            totalFriesPrice= friesCount * friesPrice;
            totalPizzaPrice= pizzaCount * pizzaPrice;

            Console.WriteLine("-------------------------");
            Console.WriteLine("Hamburger Tutarı : "+ totalHamburgerPrice+ " TL");
            Console.WriteLine("Pizza Tutarı : "+ totalPizzaPrice+ " TL");
            Console.WriteLine("Su Tutarı : "+ totalWaterPrice+ " TL");
            Console.WriteLine("Kızartma Tutarı : "+ friesPrice+ " TL");
            Console.WriteLine("Kola Tutarı : "+ totalCokePrice+ " TL");
            Console.WriteLine("Limonata Tutarı : "+ totalLemonadePrice+ " TL");

            Console.WriteLine();
            int totalPrice = totalPizzaPrice + totalWaterPrice + totalLemonadePrice + totalFriesPrice + totalCokePrice + totalHamburgerPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: "+ totalPrice +" TL") ;


            Console.Read();

        }
    }
}