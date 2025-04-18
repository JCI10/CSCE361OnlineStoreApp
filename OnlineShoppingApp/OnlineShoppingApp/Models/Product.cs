
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace OnlineShoppingApp.Models
{
    public class Product
    {
 
    [Key]
    public int Id { get;set; }
    public String Name { get;set; }
     public List<Image> Images { get;set; }
    public String ManInfo { get;set; }
    public String Description { get;set; }
    public String Dimensions { get;set; }
    public Double Weight { get;set; }
    public Double Rating { get;set; }
    public String Sku { get;set; }
    public Category Category { get;set; }
    public Product() {} 

    public Product(int id, String name,List<Image> images, String manInfo, String description, Double weight, Double rating, String sku, Category category){
        this.Id = id;
        this.Name = name;
        this.Images = images;
        this.ManInfo = manInfo;
        this.Description = description;
        this.Weight = weight;
        this.Rating = rating;
        this.Sku = sku;
        this.Category = category;
    }
    }
}

