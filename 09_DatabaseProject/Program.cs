using System;
using System.Data;
using System.Data.SqlClient;

namespace L09.DatabaseProject
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Ado.Net

			// İlk Açılan Ekran
			Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine();
			Console.WriteLine("1-Kategoriler");
			Console.WriteLine("2-Ürünler");
			Console.WriteLine("3-Siparişler");
			Console.WriteLine("4-Çıkış Yap");
			Console.WriteLine();
			Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
			int tableNumber = int.Parse(Console.ReadLine());
			Console.WriteLine("--------------------------------------------------------------------");

			// SQL Bağlantısı
			SqlConnection connection = new SqlConnection("Server=*****;Database=EgitimKampiDb;Trusted_Connection=true;TrustServerCertificate=True;");
			// SQL bağlantısı açılır.
			connection.Open();
			// SQL'de kullanılacak sorgu buraya yazılır.
			SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
			switch (tableNumber)
			{
				case 1:
					command = new SqlCommand("Select * From TblCategory", connection);
					break;
				case 2:
					command = new SqlCommand("Select * From TblProduct", connection);
					break;
				case 3:
					command = new SqlCommand("Select * From TblOrder", connection);
					break;
			}
			// C# tarafında oluşturulan sorgu ile SQL arasında köprü görevi görür.
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			// Veri tablolarını hafızada tutmak için ve üzerinde işlem yapmak için kullanılır.
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			// SQL bağlantısı kapatılır.
			connection.Close();

			foreach (DataRow row in dt.Rows)
			{
				foreach (var item in row.ItemArray)
				{
					Console.Write(item.ToString());
				}
				Console.WriteLine();
			}

			#endregion

			Console.Read();
		}
	}
}