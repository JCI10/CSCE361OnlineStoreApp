using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingApp.Models
{
    public class Checkout
    {
    [Key]
    public int OrderId { get; }
    public User User { get; }
    public List<Product> Items { get; } 
    public DateOnly Date { get; }
    public Checkout() { }
    public Checkout(int orderId,User user, List<Product> items, DateOnly date){
        this.OrderId = orderId;
        this.User = user;
        this.Items = items;
        this.Date = date;
    }
    }
}
