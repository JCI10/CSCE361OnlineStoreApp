using System.Data.SqlTypes;
using OnlineShoppingApp.Models;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Drawing;

public class CartAccessor : ICartPersisting
{
    public async Task Persist(int cartId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Product>> ViewCart(int userId)
    {
        var productAccessor = new ProductAccessor();
        SqlConnection conn = productAccessor.GetConnection();
        List<Product> products = new List<Product>();
        if (conn != null)
        {
            string query = "SELECT * FROM cart WHERE user_id = @user_id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@user_id", userId);
            SqlDataReader reader = await command.ExecuteReaderAsync();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    //Images = ImageConverter.(reader.GetString(2)), // Assuming ImageConverter is a utility class to convert string to List<Image>
                    
                    ManInfo = reader.GetString(3),
                    Description = reader.GetString(4),
                    Dimensions = reader.GetString(5),   
                    Weight = reader.GetDouble(6),
                    Rating = reader.GetDouble(7),
                    Sku = reader.GetString(8),
                    Category = new Category
                    {
                        CategoryId = reader.GetInt32(9),
                        Name = reader.GetString(10)
                    }
                };
                products.Add(product);
            }
        }
        return products;
    }
}