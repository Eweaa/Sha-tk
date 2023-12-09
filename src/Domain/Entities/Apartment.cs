using System.ComponentModel.DataAnnotations;

namespace Shatak.CoreLayer.Models
{

    public enum ApartmentStatus
    {
        ForRent,
        ForSale
    }
    public class Apartment : BaseEntity
    {
        public ApartmentStatus Status { get; set; }
        public int? RentLength { get; set; }
        public Address? Address { get; set; }
        public int AddressId { get; set; }

    }
}
