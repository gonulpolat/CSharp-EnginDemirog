using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        // Database'den veri çekme, veri gönderme, veri silme vs. işlmelerini içerir

        // Normalde kurumsal mimaride ProductDal sınıfını IProductDal interface'inden türetmen gerekli


        SqlConnection _connection = new SqlConnection("server=(localdb)\\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");  // Bağlantı nesnesi oluşturuldu


        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("SELECT * FROM Products", _connection);  // Komut oluşturuldu
            SqlDataReader reader = command.ExecuteReader();   // Komut çalıştırıldı
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                };
                products.Add(product);
            }
            reader.Close();
            _connection.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                // Bağlantı kapalı ise if koşuluna girer
                _connection.Open(); // Bağlantı açıldı
            }
        }

        public DataTable GetAll2()
        {
            // Günümüzde artık DataTable kullanılmıyor. Pahalı

            ConnectionControl();
            SqlCommand command = new SqlCommand("SELECT * FROM Products", _connection);  // Komut oluşturuldu
            SqlDataReader reader = command.ExecuteReader();   // Komut çalıştırıldı
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO Products VALUES(@name,@unitPrice,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name",product.Name);
            command.Parameters.AddWithValue("@unitPrice",product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount",product.StockAmount);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("UPDATE Products SET Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount WHERE Id=@id", _connection);
            command.Parameters.AddWithValue("@id", product.Id);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("DELETE FROM Products WHERE Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
