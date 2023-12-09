using System.ComponentModel.DataAnnotations;

namespace Shatak.CoreLayer.Models
{
    public class Address : BaseEntity
    {
        public required string City { get; set; }
        public required string Neighborhood { get; set; }
        public required string Street { get; set; }
        public int BuildingNumber { get; set; }
        public int ApartmentNumber { get; set; }

    }
}
