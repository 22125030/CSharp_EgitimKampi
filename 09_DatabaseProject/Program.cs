using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ado.Net

            Console.WriteLine("***** C# Ürün Kategori Bilgi Sistemi");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Kategoriler");
            Console.WriteLine("Ürünler");
            Console.WriteLine("Siparişler");
            Console.WriteLine("Kategoriler");
            Console.WriteLine("Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz: ");
            tableNumber= Console.ReadLine();
            Console.WriteLine("---------------------------------");

            SqlConnection connection= new SqlConnection("Data Source=DESKTOP-UJPU1EF;" +
                "initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command= new SqlCommand("select * from TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable= new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach(DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }



            Console.Read();
        }
    }
}
