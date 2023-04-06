using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace APPCONNECTSQLSERVER
{
    internal class ProductItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Instock { get; set; }
        public Image Photo { get; set; }

        public ProductItem() { }

        public ProductItem(string name, double price, int instock, Image photo)
        {
            Name = name;
            Price = price;
            Instock = instock;
            Photo = photo;
        }

        public ProductItem(int id, string name, double price, int instock, Image photo)
        {
            Id = id;
            Name = name;
            Price = price;
            Instock = instock;
            Photo = photo;
        }

        public ProductItem(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public object[] Record()
        {
            return new object[] {
                $"{Id:000}",
                Name,
                $"{Price:c2}",
                $"{Instock}",
                Photo
            };
        }

        public object[] testRecord()
        {
            return new object[] {
                $"{Id:000}",
                Name
            };
        }

        internal void Save()
        {
            string insertQuery = "INSERT INTO ss20.dbo.products (name, price, in_stock, photo) VALUES (@name, @price, @in_stock, @photo)";

            SqlCommand command = new SqlCommand(insertQuery, DataConnect.DataCon);
            command.Parameters.AddWithValue("@name", Name);
            command.Parameters.AddWithValue("@price", Price);
            command.Parameters.AddWithValue("@in_stock", Instock);
            MemoryStream stream = new MemoryStream();
            Photo.Save(stream, Photo.RawFormat);
            command.Parameters.AddWithValue("@photo", stream.ToArray());
            int rowsAffected = command.ExecuteNonQuery();
        }

        internal void update()
        {
            string insertQuery = "UPDATE ss20.dbo.products SET name=@name, price=@price, in_stock=@in_stock, photo=@photo  WHERE id=@id";

            SqlCommand command = new SqlCommand(insertQuery, DataConnect.DataCon);
            command.Parameters.AddWithValue("@id", Id);
            command.Parameters.AddWithValue("@name", Name);
            command.Parameters.AddWithValue("@price", Price);
            command.Parameters.AddWithValue("@in_stock", Instock);
            MemoryStream stream = new MemoryStream();
            Photo.Save(stream, Photo.RawFormat);
            command.Parameters.AddWithValue("@photo", stream.ToArray());
            int rowsAffected = command.ExecuteNonQuery();
        }

        public static bool delete(int id)
        {
            string insertQuery = "DELETE FROM ss20.dbo.products where id=@id";

            SqlCommand command = new SqlCommand(insertQuery, DataConnect.DataCon);
            command.Parameters.AddWithValue("@id", id);
            int rowsAffected = command.ExecuteNonQuery();
            if(rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public static List<ProductItem> getProducts()
        {
            List<ProductItem> products = new List<ProductItem>();

            string sql = "SELECT * FROM ss20.dbo.products";
            SqlCommand s = new SqlCommand(sql, DataConnect.DataCon);
            SqlDataReader r = s.ExecuteReader();

            while (r.Read())
            {
                int id = int.Parse(r[0].ToString()); // get from index of record
                string name = r["name"].ToString(); // get instand column name
                double price = double.Parse(r[2].ToString());
                int instock = int.Parse(r[3].ToString());
                byte[] bytes = (byte[])(r[4]);
                MemoryStream memoryStream = new MemoryStream(bytes);
                Image photo = Image.FromStream(memoryStream);
                products.Add(
                    new ProductItem(
                        id,
                        name,
                        price,
                        instock,
                        photo
                    )
                 );
            }

            s.Dispose();
            r.Close();
            return products;
        }

        public static List<ProductItem> getFilterProducts(string q)
        {
            List<ProductItem> products = new List<ProductItem>();
            string sql = "SELECT * FROM ss20.dbo.products WHERE UPPER(name) LIKE UPPER(@q)";
            SqlCommand s = new SqlCommand(sql, DataConnect.DataCon);
            s.Parameters.AddWithValue("@q", "%" + q.ToUpper() + "%");
            SqlDataReader r = s.ExecuteReader();

            while (r.Read())
            {
                int id = int.Parse(r[0].ToString()); // get from index of record
                string name = r["name"].ToString(); // get instand column name
                double price = double.Parse(r[2].ToString());
                int instock = int.Parse(r[3].ToString());
                byte[] bytes = (byte[])(r[4]);
                MemoryStream memoryStream = new MemoryStream(bytes);
                Image photo = Image.FromStream(memoryStream);
                products.Add(
                    new ProductItem(
                        id,
                        name,
                        price,
                        instock,
                        photo
                    )
                 );
            }

            s.Dispose();
            r.Close();
            return products;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Product Name: {Name}, Price: {Price}, In Stock: {Instock}, Photo: {Photo}";
        }
    }
}
