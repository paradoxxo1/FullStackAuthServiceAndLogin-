using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Onboarding_API.Core.Entities.FormEntities
{
    public class OnBoardForm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? OwnerFirstName { get; set; }
        public string? OwnerLastName { get; set; }
        public string? OwnerEmail { get; set; }
        public string? OwnerPhone { get; set; }
        public string? LegalCompanyName { get; set; }
        public string? StoreName { get; set; }
        public string? StorePhone { get; set; }
        public string? StoreAdress { get; set; }
        public string? StoreCity { get; set; }
        public string? StoreState { get; set; }
        public int StoreZip { get; set; }
        public string? StoreWholesaler { get; set; }
        public string? StoreAWGWarehouse { get; set; }
        public string? StoreWholesalerAccountNum { get; set; }
        public string? POSCompanyName { get; set; }
        public string? POSCompanyEmail { get; set; }
        public string? POSCompanyPhone { get; set; }
        public string? TechContactFirstName { get; set; }
        public string? TechContactLastName { get; set; }
        public string? TechContactEmail { get; set; }
        public string? TechContactPhone { get; set; }
        public string? NotificationChckTextSms { get; set; }
        public string? NotificationChckEmail { get; set; }
        public string? NotificationPhone { get; set; }
        public string? NotificationEmail { get; set; }
        public string? OrderingDepartments { get; set; }
        public string? ElectronicDataPreferences { get; set; }
        public string? FileLocation { get; set; } // bununla ilgili ayar yapılacak dosyaları kaydetme işlemi
        public string? AwgDeliveryDays { get; set; }
        public string? AwgDeadlineDays { get; set; }
        public string? AwgDeadlineTime { get; set; }
        public string? VmcDeliveryDays { get; set; }
        public string? VmcDeadlineDays { get; set; }
        public string? VmcDeadlineTime { get; set; }
        public string? SupplyVendor { get; set; }
        public string? SupplyDeliveryDays { get; set; }
        public string? SupplyDeadlineDays { get; set; }
        public string? SupplyDeadlineTime { get; set; }
        public bool? IpAddressExist { get; set; }
        public string? IpAddress { get; set; }
        public string? SubnetMask { get; set; }
        public string? DefaultGateway { get; set; }
        public string? ShipAddress { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipState { get; set; }
        public int ShipZip { get; set; }


    }
}

