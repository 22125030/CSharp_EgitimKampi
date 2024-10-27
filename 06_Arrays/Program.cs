using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        private static readonly int i;

        static void Main(string[] args)
        {
            #region  temel dizi örnekleri 
            //aynı veri tipi türündeki çok sayıdaki verileri bir arada tutmak için kullanılan yapılardır
            //sarı,kırmızı,mavi,turuncu
            //adana,ankara,tekirdağ,yozgat
            //Değişken_Türü[] DiziAdı=new Değişken_Türü[ElemanSayısı]
            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);


            //int[] numbers = new int [10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 689;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[4]);


            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki tüm elemanları listeleme 

            //string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };
            //for (int i = 0; i < colors.Length; i++) 
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //     if (numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for(int i=0; i<symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            #endregion

            #region Dizideki en büyük elemanı bulan sayı yapımı

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86,100 };

            //int maxNumber = myArray[0];

            //for (int i=0; i<myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);
            #endregion

            #region Dizi Metotları

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);
            //---------------------------------

            //int[] numbers = { 45, 85, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for (int i=0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //---------------------------------

            //int[] numbers = { 45, 85, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //---------------------------------

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);
            //---------------------------------

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("dizinin en büyük elemanı: "+ numbers.Max()+" dizinin en küçük elemanı: "+numbers.Min());
            //---------------------------------



            #endregion

            #region Kullanıcıdan değer alma

            //String[] cities = new string[5];
            //for (int i =0; i< cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i + 1}. Şehri giriniz");
            //    cities[i] = Console.ReadLine(); 
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------------");

            //for (int i = 0; i< cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = {10,20,30,40,50};
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            //Console.WriteLine("Çift Sayılar: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 ==0)
            //    {
            //        Console.WriteLine(numbers[i]);
                    
            //    }
            //}
            //Console.WriteLine("Tek Sayılar: ");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);

            //    }
            //}

            #endregion
            Console.Read();
        }
    }
}
