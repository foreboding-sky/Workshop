namespace Workshop.Models
{
    public class RepairReadDTO
    {
        public Guid Id { get; set; }
        public string? User { get; set; } //user who created the repair entry
        public SpecialistReadDTO? Specialist { get; set; } //whoever is doing the repair
        public ClientReadDTO? Client { get; set; }
        public DeviceReadDTO? Device { get; set; }
        public string? Complaint { get; set; }
        public List<RepairItemReadDTO>? Products { get; set; }
        public List<OrderReadDTO>? OrderedProducts { get; set; }
        public List<RepairServiceReadDTO>? RepairServices { get; set; }
        public string? Comment { get; set; }
        public double? Discount { get; set; }
        public double? TotalPrice { get; set; }
        public RepairStatus Status { get; set; }
    }
}