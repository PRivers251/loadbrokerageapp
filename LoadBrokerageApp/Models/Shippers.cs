//Shippers.cs

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;

namespace LoadBrokerageApp.Models
{
    public class Shippers
    {
        // General Shipper Information
        [Required(ErrorMessage = "You must enter your business name.")]
        public string Shipper { get; set; } = string.Empty;
        public Guid ShippersId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ShipperAddressLine1 { get; set; } = string.Empty;
        public string? ShipperAddressLine2 { get; set; }
        public string ShipperCity { get; set; } = string.Empty;
        public string ShipperState { get; set; } = string.Empty;
        public string ShipperPostalCode { get; set; } = string.Empty;
        public string ShipperPhone { get; set; } = string.Empty;
        public string? ShipperContactPerson { get; set; }
        public string? ShipperContactPersonPhone { get; set; }
        public string? ShipperContactPersonEmail { get; set; }


        // Relationship Information
        [DataType(DataType.DateTime)]
        public DateTime? ContractSignedDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? ContractExpirationDate { get; set; }
        public decimal LoadsCompleted { get; set; } = 0;

        public Shippers()
        {
            CreatedDate = DateTime.UtcNow;
        }
    }
}