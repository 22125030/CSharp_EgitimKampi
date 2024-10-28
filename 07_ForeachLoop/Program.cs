using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach 
            //foreach(1:2:3:4)
            //1:değişken adı
            //2:değişken türü
            //3:In
            //4:Liste, Koleksiyon Dizi

            //String[] cities = { "milano", "roma", "budapeşte", "anakara", "istanbul", "varşova" };

            //foreach (String city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 33, 41, 205, 6578, 10394 };

            //foreach(int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 1)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}   

            //toplama işlemleri

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 33, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach(int number  in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //string word = "Merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}




            #endregion

            #region  Sınav Sistemi Uygulaması 

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            ////sınıftaki öğrenci sayısını kullanıcıdan alma 
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var: ");
            //int studentCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            //// öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentNames=new string[studentCount];
            //double[] studentExamAvg=new double[studentCount];

            //for (int i=0; i<studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;
            //    // her öğrenci için 3 sınav notu girilecek 

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]}adlı öğrencinin {j+1}.Sınav notunu giriniz: ");
            //        double value=double.Parse (Console.ReadLine());
            //        totalExamResult += value;//notları topluyoruz.

            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3;
            //}
            //// sınav ortalamaları
            //for(int i=0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
            //    //öğrencilerin ortalaması ve geçip kalma durumları
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]}adlı öğrenci dersi geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçemedi.");
            //    }

            //    Console.WriteLine("------------------------------");

            //}
            




            #endregion
            Console.Read();
        }
    }
}
