
using Microsoft.Data.SqlClient;


public class ProductAccessor : IConnectionAccessor, IProductAccessor
{

    public SqlConnection GetConnection(){
        Console.WriteLine("Getting Connection");
        //Change connection string for local database
        string connectionString = "Data Source=CALEBS-LAPTOP\\SQLEXPRESS02;Initial Catalog = CSCE361OnlineStoreApp; Integrated Security = True;Encrypt=False";
        SqlConnection conn = new SqlConnection(connectionString);
        try
        {
            Console.WriteLine("Opening Connection");
            conn.Open();
            Console.WriteLine("Connection was succesful");
            return conn;
        } catch (Exception e) {
            Console.WriteLine("Unable to connect to the database");
        }
        return null;
    }

    public Product GetProduct(int product_id){
        using (var conn = GetConnection()){
            if(conn != null){
                string query = "SELECT * FROM product WHERE product_id = @product_id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@product_id", product_id);
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read()){
                    Product product = new Product
                    {
                        // TODO populate Product object from query

                    };
                    return product;
                }
            }
            return null;
        }
    }




}
