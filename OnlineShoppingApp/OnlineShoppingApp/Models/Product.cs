
using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingApp.Models
{
    public class Product
    {
 
    [Key]
    public int Id { get; }
    public String Name { get; }
    // public List<Image> Images { get; }
    public String ManInfo { get; }
    public String Description { get; }
    public String Dimensions { get; }
    public Double Weight { get; }
    public Double Rating { get; }
    public String Sku { get; }
    public Category Category { get; }
    public Product() {} 

    public Product(int id, String name, String manInfo, String description, Double weight, Double rating, String sku, Category category){
        this.Id = id;
        this.Name = name;
        this.ManInfo = manInfo;
        this.Description = description;
        this.Weight = weight;
        this.Rating = rating;
        this.Sku = sku;
        this.Category = category;
    }
    }
}

