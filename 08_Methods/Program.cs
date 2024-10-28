using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metodlar

            //()
            // geriye değer döndürmeyen metodlar
            //customer-->ekle ,sil,güncelle
            //void metodlar 

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();



            #endregion

            #region geriye değer döndürmeyen parametreli metodlar

            //void WriteMethod(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);
            //}
            //WriteMethod("Mehemt Yıldırım");


            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: "+name+ " " +surName);
            //}
            //CustomerCard("Mehmet"," Yıldız");
            //CustomerCard("Ayşegül", "Kaya");

            #endregion

            #region Geriye değer döndürmeyen int parametreli metotlar

            //void sum (int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //sum(4, 5, 6);

            #endregion

            #region Geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();


            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye değer döndüren parametreli metotlar

            //string CountrCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo="Ülke: "+countryName+" "+"Başkent: "+capital +" "+"Bayrak Rengi"+flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.WriteLine("Ülke adını giriniz: ");
            //x= Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y= Console.ReadLine();

            //Console.WriteLine("Bayrak Rengini Giriniz: ");
            //z= Console.ReadLine();

            //Console.WriteLine( CountrCard(x, y, z));
            //Console.WriteLine(CountrCard("Türkiye","Ankara","Kırmızı-Beyaz"));



            #endregion

            #region Geriye değer döndüren int parametreli metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result=number1+number2; 
            //    return result;
            //}

            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(36,25));
            //Console.WriteLine(Sum(44,36));
            //Console.WriteLine(Sum(14,20));
            #endregion

            #region Örnek uygulama

            //string ExamResult(string student ,int exam1,int exam2, int exam3)
            //{
            //    int result=(exam1+exam2+ exam3)/3;
            //    if (result >= 50)
            //    {
            //        return student+ " İsimli öğrenci sınavı geçti."+ " ortalama "+result;
            //    }
            //    else
            //    {
            //        return student+ " İsimli öğrenci başarısız oldu."+ "Ortalama"+result;
            //    }
            //}
            //Console.WriteLine(ExamResult("ali",25,41,55));
            //Console.WriteLine(ExamResult("ayşe",36,88,33));

            #endregion

            Console.Read();
        }
    }
}
