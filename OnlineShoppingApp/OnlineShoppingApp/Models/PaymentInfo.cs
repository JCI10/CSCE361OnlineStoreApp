using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingApp.Models
{
    public class PaymentInfo
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string CVV { get; set; }
        public PaymentInfo() { }

        public PaymentInfo(int id,User user, string cardNumber, string cardHolderName, DateTime expirationDate, string cvv)
        {
            Id = id;
            User = user;
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            ExpirationDate = expirationDate;
            CVV = cvv;
        }
    }
}