

namespace LoadBrokerageApp.Models
{
    public class Loads
    {
        // General Load Information
        public required Guid LoadsId { get; set; }
        public required decimal NumberOfStops { get; set; }
        public required float LoadWeight { get; set; }
        public required string LoadDescription { get; set; }
        public required decimal LoadPieceCount { get; set; }
        public enum LoadPackaging
        {
            Pallet,
            Box,
            Carton,
            Drum,
            BulkTote,
            Bag,
            BulkTank
        }


        public enum LoadType
        {
            Truckload,
            LTL,
            Partial,
            Dryage,
            Intermodal,
            Tanker,
            FoodGrade
        }

        public enum LoadStatus
        {
            New,
            Quoted,
            Dispatched,
            InTransit,
            OnHold,
            Cancled,
            Delivered,
            Billed,
            PODRecieved,
            Paid
        }

        // Consignee Information
        public string Consignee { get; set; } = string.Empty;
        public required string ConsigneeAddressLine1 { get; set; }
        public required string ConsigneeAddressLine2 { get; set; }
        public required string ConsigneeCity { get; set; }
        public required string ConsigneeState { get; set; }
        public required string ConsigneePostalCode { get; set; }
        public required string ConsigneePhone { get; set; }
        public string? ConsigneeContactPerson { get; set; }
        public string? ConsigneeContactPersonPhone { get; set; }
        public string? ConsigneeContactPersonEmail { get; set; }

        // Shipper Information
        public required string Shipper { get; set; }
        public required string ShipperId { get; set; }
        public required string ShipperAddressLine1 { get; set; }
        public required string ShipperAddressLine2 { get; set; }
        public required string ShipperCity { get; set; }
        public required string ShipperState { get; set; }
        public required string ShipperPostalCode { get; set; }
        public required string ShipperPhone { get; set; }
        public string? ShipperContactPerson { get; set; }
        public string? ShipperContactPersonPhone { get; set; }
        public string? ShipperContactPersonEmail { get; set; }
    }
}