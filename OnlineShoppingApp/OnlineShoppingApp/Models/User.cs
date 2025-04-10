using System.Net.Sockets;

public class User
{
    public int UserId { get; }
    public String Username { get;set; }
    public String Password { get;set; }
    public Address Address { get;set; }
    public PaymentInfo Payment { get;set; }

    public User() {}

    public User(int userId, String username, String password, Address address, Paymentinfo payment){
        this.UserId = userId;
        this.Username = username;
        this.Password = password;
        this.Address = address;
        this.Payment = payment;
    }
}