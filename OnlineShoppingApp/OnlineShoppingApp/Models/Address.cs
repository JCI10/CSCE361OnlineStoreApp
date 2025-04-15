using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingApp.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

        // Constructor
        public Address() { }

        public Address(int id, string street, string city, string state, string zipCode, string country)
        {
            Id = id;
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
            Country = country;
        }
    }
}