using System;

namespace ColoWebApp.Models
{
    public class Report
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int RackId { get; set; }
        public int RackUsage { get; set; } // Usage in GB or another unit
        public decimal MonthlyCharge { get; set; }
        public DateTime ReportDate { get; set; }
    }
}