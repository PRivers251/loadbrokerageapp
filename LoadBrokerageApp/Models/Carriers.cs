

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace LoadBrokerageApp.Models
{

    public class Carriers
    {

        // Carrier General Information
        [Required]
        public required string CarrierId { get; set; }
        [Required]
        public required string CarrierName { get; set; }
        public string? DBAName { get; set; }
        public required string ContactPerson { get; set; }
        public required string ContactEmail { get; set; }
        public required string ContactPhone { get; set; }
        public required string AddressLine1 { get; set; } // Street Address
        public required string AddressLine2 { get; set; } // Suite | Apt | Unit Number
        public required string City { get; set; }
        public required string State_Province { get; set; } // State | Province Code (Example: AL, NY, CA)
        public required string PostalCode { get; set; }
        public required string Country { get; set; }
        public required bool HazmatCertified { get; set; }
        public required string ELDProvider { get; set; }
        public string? DOTComplianceScore { get; set; }
        public required bool IsActive { get; set; }
        public string? PrimaryEquipmentType { get; set; } // Van, Reefer, Tanker, Flatbed, etc.

        // DOT Compliance Carrier Information
        public required string MC_Number { get; set; } // Valid MC Number
        public required string USDOT_Number { get; set; } // Valid DOT Number
        public required string OperatingAuthority { get; set; } // Active, Inactive, Revoked
        public required string OperatingAuthorityType { get; set; } // Common Carrier, Contract Carrier, Broker, etc.
        public required string EIN_TaxID { get; set; }

        // Insurance Information
        public required string InsuranceProvider { get; set; }
        public required string InsurancePolicyNumber { get; set; }
        [DataType(DataType.Date)]
        public required DateTime InsuranceExpirationDate { get; set; }
        public required decimal CargoInsuranceCoverageAmount { get; set; }
        public required decimal LiabilityInsuraceCoverageAmount { get; set; }

        // Relationship Information
        [DataType(DataType.DateTime)]
        public DateTime? ContractSignedDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? ContractExpirationDate { get; set; }
        public required decimal LoadsCompleted { get; set; }
        
    }
}