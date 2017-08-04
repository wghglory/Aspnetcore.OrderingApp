using System;

namespace Aspnetcore.OrderingApp.Models
{
    public class OrderSummary
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Stage { get; set; }
    }
}