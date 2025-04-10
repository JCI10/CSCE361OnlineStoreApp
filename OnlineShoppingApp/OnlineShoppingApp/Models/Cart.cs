public class Cart 
{
    public int CartId { get; }
    public List<Product> Items { get; }
    public User User { get ; }

    public Cart() {}

    public Cart(int cardId,List<Product> items,User user){
        this.CartId = cardId;
        this.Items = items;
        this.User = user;
    }


}