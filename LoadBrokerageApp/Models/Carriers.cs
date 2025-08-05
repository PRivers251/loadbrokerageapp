

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace LoadBrokerageApp.Models
{

    public class Carriers
    {

        // Carrier General Information
        public Guid CarriersId { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        public string CarrierName { get; set; }
        public string? DBAName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string AddressLine1 { get; set; } // Street Address
        public string AddressLine2 { get; set; } // Suite | Apt | Unit Number
        public string City { get; set; }
        public string State_Province { get; set; } // State | Province Code (Example: AL, NY, CA)
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public bool HazmatCertified { get; set; }
        public string ELDProvider { get; set; }
        public string? DOTComplianceScore { get; set; }
        public bool IsActive { get; set; }
        public string? PrimaryEquipmentType { get; set; } // Van, Reefer, Tanker, Flatbed, etc.

        // DOT Compliance Carrier Information
        public string MC_Number { get; set; } // Valid MC Number
        public string USDOT_Number { get; set; } // Valid DOT Number
        public string OperatingAuthority { get; set; } // Active, Inactive, Revoked
        public string OperatingAuthorityType { get; set; } // Common Carrier, Contract Carrier, Broker, etc.
        public string EIN_TaxID { get; set; }

        // Insurance Information
        public string InsuranceProvider { get; set; }
        public string InsurancePolicyNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime InsuranceExpirationDate { get; set; }
        public decimal CargoInsuranceCoverageAmount { get; set; }
        public decimal LiabilityInsuraceCoverageAmount { get; set; }

        // Relationship Information
        [DataType(DataType.DateTime)]
        public DateTime? ContractSignedDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? ContractExpirationDate { get; set; }
        public decimal LoadsCompleted { get; set; }

        public Carriers()
        {
            CreatedDate = DateTime.UtcNow;
        }       
    }
}