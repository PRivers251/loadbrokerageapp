using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoadBrokerageApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carriers",
                columns: table => new
                {
                    CarriersId = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    CarrierName = table.Column<string>(type: "text", nullable: false),
                    DBAName = table.Column<string>(type: "text", nullable: true),
                    ContactPerson = table.Column<string>(type: "text", nullable: false),
                    ContactEmail = table.Column<string>(type: "text", nullable: false),
                    ContactPhone = table.Column<string>(type: "text", nullable: false),
                    AddressLine1 = table.Column<string>(type: "text", nullable: false),
                    AddressLine2 = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    State_Province = table.Column<string>(type: "text", nullable: false),
                    PostalCode = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    HazmatCertified = table.Column<bool>(type: "boolean", nullable: false),
                    ELDProvider = table.Column<string>(type: "text", nullable: false),
                    DOTComplianceScore = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    PrimaryEquipmentType = table.Column<string>(type: "text", nullable: true),
                    MC_Number = table.Column<string>(type: "text", nullable: false),
                    USDOT_Number = table.Column<string>(type: "text", nullable: false),
                    OperatingAuthority = table.Column<string>(type: "text", nullable: false),
                    OperatingAuthorityType = table.Column<string>(type: "text", nullable: false),
                    EIN_TaxID = table.Column<string>(type: "text", nullable: false),
                    InsuranceProvider = table.Column<string>(type: "text", nullable: false),
                    InsurancePolicyNumber = table.Column<string>(type: "text", nullable: false),
                    InsuranceExpirationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CargoInsuranceCoverageAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    LiabilityInsuraceCoverageAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    ContractSignedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ContractExpirationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LoadsCompleted = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carriers", x => x.CarriersId);
                });

            migrationBuilder.CreateTable(
                name: "Loads",
                columns: table => new
                {
                    LoadsId = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    NumberOfStops = table.Column<decimal>(type: "numeric", nullable: false),
                    LoadWeight = table.Column<float>(type: "real", nullable: false),
                    LoadDescription = table.Column<string>(type: "text", nullable: false),
                    LoadPieceCount = table.Column<decimal>(type: "numeric", nullable: false),
                    Consignee = table.Column<string>(type: "text", nullable: false),
                    ConsigneeAddressLine1 = table.Column<string>(type: "text", nullable: false),
                    ConsigneeAddressLine2 = table.Column<string>(type: "text", nullable: false),
                    ConsigneeCity = table.Column<string>(type: "text", nullable: false),
                    ConsigneeState = table.Column<string>(type: "text", nullable: false),
                    ConsigneePostalCode = table.Column<string>(type: "text", nullable: false),
                    ConsigneePhone = table.Column<string>(type: "text", nullable: false),
                    ConsigneeContactPerson = table.Column<string>(type: "text", nullable: true),
                    ConsigneeContactPersonPhone = table.Column<string>(type: "text", nullable: true),
                    ConsigneeContactPersonEmail = table.Column<string>(type: "text", nullable: true),
                    Shipper = table.Column<string>(type: "text", nullable: false),
                    ShipperId = table.Column<string>(type: "text", nullable: false),
                    ShipperAddressLine1 = table.Column<string>(type: "text", nullable: false),
                    ShipperAddressLine2 = table.Column<string>(type: "text", nullable: false),
                    ShipperCity = table.Column<string>(type: "text", nullable: false),
                    ShipperState = table.Column<string>(type: "text", nullable: false),
                    ShipperPostalCode = table.Column<string>(type: "text", nullable: false),
                    ShipperPhone = table.Column<string>(type: "text", nullable: false),
                    ShipperContactPerson = table.Column<string>(type: "text", nullable: true),
                    ShipperContactPersonPhone = table.Column<string>(type: "text", nullable: true),
                    ShipperContactPersonEmail = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loads", x => x.LoadsId);
                });

            migrationBuilder.CreateTable(
                name: "Shippers",
                columns: table => new
                {
                    ShippersId = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Shipper = table.Column<string>(type: "text", nullable: false),
                    ShipperAddressLine1 = table.Column<string>(type: "text", nullable: false),
                    ShipperAddressLine2 = table.Column<string>(type: "text", nullable: false),
                    ShipperCity = table.Column<string>(type: "text", nullable: false),
                    ShipperState = table.Column<string>(type: "text", nullable: false),
                    ShipperPostalCode = table.Column<string>(type: "text", nullable: false),
                    ShipperPhone = table.Column<string>(type: "text", nullable: false),
                    ShipperContactPerson = table.Column<string>(type: "text", nullable: true),
                    ShipperContactPersonPhone = table.Column<string>(type: "text", nullable: true),
                    ShipperContactPersonEmail = table.Column<string>(type: "text", nullable: true),
                    ContractSignedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ContractExpirationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LoadsCompleted = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippers", x => x.ShippersId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carriers");

            migrationBuilder.DropTable(
                name: "Loads");

            migrationBuilder.DropTable(
                name: "Shippers");
        }
    }
}
