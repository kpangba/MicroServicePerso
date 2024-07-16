
namespace MSP.Common.Entities.ValueObjects
{
    public class Address
    {
        public string Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public Address() { }
        public Address(string number, string street, string city, string postalCode, string country, string phone)
        {
            Number = number;
            Street = street;
            City = city;
            PostalCode = postalCode;
            Country = country;
            Phone = phone;
        }
    }
}
